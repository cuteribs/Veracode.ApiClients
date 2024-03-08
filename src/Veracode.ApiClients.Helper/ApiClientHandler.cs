using System;
using System.Linq;
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
		_options.PreSendConfigure?.Invoke(request);

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
		var url = path + (queryString ?? string.Empty);
		var data = $"id={apiId}&host={hostName}&url={url}&method={httpMethod}";
		var ts = (DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalMilliseconds.ToString("F0");
		var apiKeyBytes = MyHelper.FromHexString(apiKey);
		var nonceBytes = MyHelper.GetRandomBytes(16);
		var sign = GenerateSignature(apiKeyBytes, nonceBytes, ts, data);

		var authorization = $"id={apiId},ts={ts:F0},nonce={MyHelper.ToHexString(nonceBytes)},sig={MyHelper.ToHexString(sign)}";
		return authorization;
	}

	private static byte[] GenerateSignature(byte[] apiKeyBytes, byte[] nonceBytes, string ts, string data)
	{
		var kNonce = MyHelper.HashData(apiKeyBytes, nonceBytes);
		var kDate = MyHelper.HashData(kNonce, Encoding.UTF8.GetBytes(ts));
		var kSign = MyHelper.HashData(kDate, Encoding.UTF8.GetBytes("vcode_request_version_1"));
		return MyHelper.HashData(kSign, Encoding.UTF8.GetBytes(data));
	}
}


public static class MyHelper
{
#if NET5_0_OR_GREATER
	public static byte[] FromHexString(string str) => Convert.FromHexString(str);
	public static string ToHexString(byte[] bytes) => Convert.ToHexString(bytes);
	public static byte[] GetRandomBytes(int length) => RandomNumberGenerator.GetBytes(length);
	public static byte[] HashData(byte[] key, byte[] data) => HMACSHA256.HashData(key, data);
#else
	/// <summary>
	/// Converts hex format string to byte array
	/// Such as "0A1B2C3D" to { 0x0A, 0x1B, 0x2C, 0x3D }
	/// </summary>
	/// <param name="str"></param>
	/// <returns></returns>
	/// <exception cref="ArgumentNullException"></exception>
	/// <exception cref="FormatException"></exception>
	public static byte[] FromHexString(string str)
	{
		if (str == null)
		{
			throw new ArgumentNullException(nameof(str));
		}

		if (str.Length == 0)
		{
			return Array.Empty<byte>();
		}

		if (str.Length % 2 != 0)
		{
			throw new FormatException("Invalid hex string length");
		}

		var result = Enumerable.Range(0, str.Length)
			.Where(x => x % 2 == 0)
			.Select(x => Convert.ToByte(str.Substring(x, 2), 16))
			.ToArray();

		return result;
	}

	/// <summary>
	/// Converts byte array to hex string
	/// </summary>
	/// <param name="bytes"></param>
	/// <returns></returns>
	/// <exception cref="ArgumentNullException"></exception>
	public static string ToHexString(byte[] bytes)
	{
		if (bytes == null)
		{
			throw new ArgumentNullException(nameof(bytes));
		}

		if (bytes.Length == 0)
		{
			return string.Empty;
		}

		var result = string.Join(string.Empty, bytes.Select(x => x.ToString("X2")));
		return result;
	}

	/// <summary>
	/// Generates random byte array
	/// </summary>
	/// <param name="length"></param>
	/// <returns></returns>
	public static byte[] GetRandomBytes(int length)
	{
		using var rng = RandomNumberGenerator.Create();
		var bytes = new byte[length];
		rng.GetBytes(bytes);
		return bytes;
	}

	/// <summary>
	/// Hashs data with key using HMACSHA256
	/// </summary>
	/// <param name="key"></param>
	/// <param name="data"></param>
	/// <returns></returns>
	public static byte[] HashData(byte[] key, byte[] data)
	{
		using var hmac = new HMACSHA256(key);
		return hmac.ComputeHash(data);
	}
#endif
}