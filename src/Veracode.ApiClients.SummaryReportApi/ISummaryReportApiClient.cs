// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Veracode.ApiClients.SummaryReportApi
{
    using Microsoft.Rest;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Veracode Summary Report API Documentation
    /// </summary>
    public partial interface ISummaryReportApiClient : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }


        /// <summary>
        /// Returns a Summary Report of a scan.
        /// </summary>
        /// <remarks>
        /// Returns a Summary Report of a static analysis, dynamic analysis or
        /// manual penetration test.
        /// </remarks>
        /// <param name='appGuid'>
        /// GUID of the application.
        /// </param>
        /// <param name='buildId'>
        /// ID of the build in which the scan ran. Default is the latest
        /// build_id.
        /// </param>
        /// <param name='context'>
        /// GUID of the associated development sandbox, if specified. The
        /// Summary Report is relative to this context parameter.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<SummaryReport>> GetSummaryReportWithHttpMessagesAsync(string appGuid, IList<string> buildId = default(IList<string>), IList<string> context = default(IList<string>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

    }
}
