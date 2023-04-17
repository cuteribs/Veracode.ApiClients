using AutoRest.ApiClients.Common;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;

namespace Veracode.ApiClients.Helper;

public static class ServiceClientServiceCollectionExtensions
{
	public static IServiceCollection AddApiClient<TClient, TImplementation>(
		this IServiceCollection services,
		Action<ApiClientOptions> configureOptions,
		Action<TClient>? configureClient = null
	) where TClient : class
		where TImplementation : class, IApiClient, TClient
	{
		ApiClientOptions options = new();
		configureOptions(options);
		return services.AddApiClient<TClient, TImplementation>(options, configureClient);
	}

	public static IServiceCollection AddApiClient<TClient, TImplementation>(
		this IServiceCollection services,
		ApiClientOptions clientOptions,
		Action<TClient>? configureClient = null
	) where TClient : class
		where TImplementation : class, IApiClient, TClient
	{
		var clientName = typeof(TClient).Name;
		services.AddHttpClient<TClient>(clientName)
			.AddHttpMessageHandler(createHandler);
		services.AddTransient<TClient>(factory);
		return services;

		DelegatingHandler createHandler() => new ApiClientHandler(clientOptions);

		TClient factory(IServiceProvider serviceProvider)
		{
			var httpClientFactory = serviceProvider.GetRequiredService<IHttpClientFactory>();
			var httpClient = httpClientFactory.CreateClient(clientName);
			var client = ActivatorUtilities.CreateInstance<TImplementation>(serviceProvider, httpClient, true)!;
			client.BaseUri = clientOptions.BaseUri;
			configureClient?.Invoke(client);
			return client;
		}
	}
}