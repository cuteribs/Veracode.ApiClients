using System;

namespace Veracode.ApiClients.Helper;

#nullable disable
public class ApiClientOptions
{
	public string ApiId { get; set; }
	public string ApiKey { get; set; }
	public Uri BaseUri { get; set; }
}
