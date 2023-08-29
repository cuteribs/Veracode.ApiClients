using System;
using System.Net.Http;

namespace Veracode.ApiClients.Helper;

public class ApiClientOptions
{
#nullable disable
	public string ApiId { get; set; }
	public string ApiKey { get; set; }
	public Uri BaseUri { get; set; }
#nullable restore

	public Action<HttpRequestMessage>? PreSendConfigure { get; set; }
}
