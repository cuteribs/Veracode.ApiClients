// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Veracode.ApiClients.ApplicationsApi.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// PagedResourceOfApplication
    /// </summary>
    public partial class PagedResourceOfApplication
    {
        /// <summary>
        /// Initializes a new instance of the PagedResourceOfApplication class.
        /// </summary>
        public PagedResourceOfApplication()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PagedResourceOfApplication class.
        /// </summary>
        public PagedResourceOfApplication(EmbeddedApplication _embedded = default(EmbeddedApplication), Link _links = default(Link), PageMetadata page = default(PageMetadata))
        {
            this._embedded = _embedded;
            this._links = _links;
            Page = page;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_embedded")]
        public EmbeddedApplication _embedded { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_links")]
        public Link _links { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "page")]
        public PageMetadata Page { get; set; }

    }
}
