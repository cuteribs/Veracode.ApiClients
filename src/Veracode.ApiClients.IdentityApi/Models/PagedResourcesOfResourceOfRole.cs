// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Veracode.ApiClients.IdentityApi.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class PagedResourcesOfResourceOfRole
    {
        /// <summary>
        /// Initializes a new instance of the PagedResourcesOfResourceOfRole
        /// class.
        /// </summary>
        public PagedResourcesOfResourceOfRole()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PagedResourcesOfResourceOfRole
        /// class.
        /// </summary>
        public PagedResourcesOfResourceOfRole(object embedded = default(object), object links = default(object), PageMetadata page = default(PageMetadata))
        {
            Embedded = embedded;
            Links = links;
            Page = page;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "embedded")]
        public object Embedded { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "links")]
        public object Links { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "page")]
        public PageMetadata Page { get; set; }

    }
}
