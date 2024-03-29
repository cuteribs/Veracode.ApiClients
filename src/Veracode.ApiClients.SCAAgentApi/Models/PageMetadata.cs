// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Veracode.ApiClients.SCAAgentApi.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// PageMetadata
    /// </summary>
    public partial class PageMetadata
    {
        /// <summary>
        /// Initializes a new instance of the PageMetadata class.
        /// </summary>
        public PageMetadata()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PageMetadata class.
        /// </summary>
        public PageMetadata(long? number = default(long?), long? size = default(long?), long? totalElements = default(long?), long? totalPages = default(long?))
        {
            Number = number;
            Size = size;
            TotalElements = totalElements;
            TotalPages = totalPages;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "number")]
        public long? Number { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "size")]
        public long? Size { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "total_elements")]
        public long? TotalElements { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "total_pages")]
        public long? TotalPages { get; set; }

    }
}
