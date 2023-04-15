using System;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Veracode.ApiClients.Helper;

public class ApiClientHandler : DelegatingHandler
{
	private readonly ApiClientOptions _options;

	public ApiClientHandler(ApiClientOptions options)
	{
		_options = options;
	}

	protected override Task<HttpResponseMessage> SendAsync(
		HttpRequestMessage request,
		CancellationToken cancellationToken
	)
	{
		var uri = request.RequestUri!;
		var authorization = GenerateAuthorization(
			_options.ApiId,
			_options.ApiKey,
			uri.Host,
			uri.AbsolutePath,
			uri.Query,
			request.Method.Method
		);
		request.Headers.Authorization = new("VERACODE-HMAC-SHA-256", authorization);
		return base.SendAsync(request, cancellationToken);
	}

	private static string GenerateAuthorization(
		string apiId,
		string apiKey,
		string hostName,
		string path,
		string queryString,
		string httpMethod
	)
	{
		try
		{
			var url = path + (queryString ?? string.Empty);
			var data = $"id={apiId}&host={hostName}&url={url}&method={httpMethod}";
			var ts = (DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalMilliseconds.ToString("F0");
			var apiKeyBytes = Convert.FromHexString(apiKey);
			var nonceBytes = RandomNumberGenerator.GetBytes(16);
			var sign = GenerateSignature(apiKeyBytes, nonceBytes, ts, data);

			var authorization = $"id={apiId},ts={ts:F0},nonce={Convert.ToHexString(nonceBytes)},sig={Convert.ToHexString(sign)}";
			return authorization;
		}
		catch (Exception e)
		{
			throw new Exception(e.Message, e);
		}
	}

	private static byte[] GenerateSignature(byte[] apiKeyBytes, byte[] nonceBytes, string ts, string data)
	{
		var kNonce = HMACSHA256.HashData(apiKeyBytes, nonceBytes);
		var kDate = HMACSHA256.HashData(kNonce, Encoding.UTF8.GetBytes(ts));
		var kSign = HMACSHA256.HashData(kDate, Encoding.UTF8.GetBytes("vcode_request_version_1"));
		return HMACSHA256.HashData(kSign, Encoding.UTF8.GetBytes(data));
	}
}
