using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Veracode.ApiClients.ApplicationsApi;
using Veracode.ApiClients.Helper;
using Veracode.ApiClients.IdentityApi;
using Veracode.ApiClients.SCAAgentApi;
using Veracode.ApiClients.SCAAgentApi.Patches;
using Veracode.ApiClients.SummaryReportApi;

namespace ApiTester;

class Program
{
	private static IConfigurationRoot? Configuration;

	static void Main(string[] args)
	{
		/*
		Imagine your have a secrets.json like this:
		{
			"VeracodeClientOptions": {
				"ApiId": "blablablablabla",
				"ApiKey": "fooobaaafooobaaa"
			}
		}
		*/
		Configuration = new ConfigurationBuilder()
			.AddUserSecrets<Program>()
			.Build();

		GetUsers();

		GetApplications();

		GetSCAs();
	}

	static void GetUsers()
	{
		ServiceCollection services = new();
		services.AddApiClient<IIdentityApiClient, IdentityApiClient>(o =>
		{
			Configuration.Bind("VeracodeClientOptions", o);
			o.BaseUri = new("https://api.veracode.com/api/authn");
		});
		var serviceProvider = services.BuildServiceProvider();
		var client = serviceProvider.GetRequiredService<IIdentityApiClient>();

		var response = client.GetUserApiCredsUsingGET();
		var result = response;
		Console.WriteLine("Users");
		Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
	}

	static void GetApplications()
	{
		ServiceCollection services = new();
		services.AddApiClient<IApplicationsApiClient, ApplicationsApiClient>(o =>
		{
			Configuration.Bind("VeracodeClientOptions", o);
			o.BaseUri = new("https://api.veracode.com");
		});
		var serviceProvider = services.BuildServiceProvider();
		var client = serviceProvider.GetRequiredService<IApplicationsApiClient>();

		var response = client.GetApplicationsUsingGET(team: "Veracity-Maritime-OVD");
		var result = response._embedded.Applications.Select(a => new
		{
			AppId = a.Id,
			AppGuid = a.Guid,
			ApplicationName = a.Profile.Name,
			LastCompletedScan = a.LastCompletedScanDate?.ToString("s"),
			Policy = a.Profile.Policies.Select(p => $"{p.PolicyComplianceStatus} {p.Name}"),
			ScanStatus = a.Scans.Select(s => $"{s.ScanType}: {s.Status}")
		});
		Console.WriteLine("Applications");
		Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));

		if (result.Any())
		{
			GetSummaryReport(result.First().AppGuid);
		}
	}

	static void GetSummaryReport(string appGuid)
	{
		ServiceCollection services = new();
		services.AddApiClient<ISummaryReportApiClient, SummaryReportApiClient>(o =>
		{
			Configuration.Bind("VeracodeClientOptions", o);
			o.BaseUri = new("https://api.veracode.com");
		});
		var serviceProvider = services.BuildServiceProvider();
		var client = serviceProvider.GetRequiredService<ISummaryReportApiClient>();

		var response = client.GetSummaryReport(appGuid);
		var result = response;
		Console.WriteLine("Summary Report");
		Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
	}

	static void GetSCAs()
	{
		ServiceCollection services = new();
		services.AddApiClient<ISCAAgentApiClient, SCAAgentApiClient>(o =>
		{
			Configuration.Bind("VeracodeClientOptions", o);
			o.BaseUri = new("https://api.veracode.com/srcclr");
		}, client =>
		{
			client.DeserializationSettings.Converters.Add(new EmbeddedPropertyConverter());
			client.DeserializationSettings.Converters.Add(new LinksPropertyConverter());
		});
		var serviceProvider = services.BuildServiceProvider();
		var client = serviceProvider.GetRequiredService<ISCAAgentApiClient>();

		var response = client.GetWorkspacesUsingGET();
		var result = response._embedded.Select(a => new
		{
			Name = a.Name,
			TotalProjects = a.ProjectsCount,
			TotalIssues = a.TotalIssuesCount,
			VulnerabilityIssues = a.VulnerabilityIssuesCount,
			LibraryIssues = a.LibraryIssuesCount,
			LicenseIssues = a.LicenseIssuesCount,
			LastScan = a.LastScanDate?.ToString("s")
		});
		Console.WriteLine("SCA Agent Workspaces");
		Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
	}
}