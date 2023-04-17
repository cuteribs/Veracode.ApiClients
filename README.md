# Veracode.ApiClients

- C# Wrappers for Veracode Rest API.
- Generated with autorest and some manually fixes.
- There are many bugs/errors in the swagger/openapi documentation provided by Veracode.

# Example

```csharp
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Veracode.ApiClients.Helper;
using Veracode.ApiClients.SCAAgent.Api;
using Veracode.ApiClients.SCAAgent.Api.Patches;

static void Main()
{
    ServiceCollection services = new();
    services.AddApiClient<ISCAAgentApiClient, SCAAgentApiClient>(o =>
    {
        o.ApiId = "xxxxxxxxxxxxxx";
        o.ApiKey = "xxxxxxxxxxxxxx";
        o.BaseUri = new("https://api.veracode.com/srcclr");
    }, client =>
    {
        // These custom converters are required for Veracode SCA Agent Api response deserialization.
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
```