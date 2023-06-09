// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Veracode.ApiClients.IdentityApi.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class BusinessUnitResource
    {
        /// <summary>
        /// Initializes a new instance of the BusinessUnitResource class.
        /// </summary>
        public BusinessUnitResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BusinessUnitResource class.
        /// </summary>
        public BusinessUnitResource(string buId = default(string), string buName = default(string), bool? isDefault = default(bool?), ResourceOfOrganization organization = default(ResourceOfOrganization), IList<ResourceOfTeam> teams = default(IList<ResourceOfTeam>))
        {
            BuId = buId;
            BuName = buName;
            IsDefault = isDefault;
            Organization = organization;
            Teams = teams;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bu_id")]
        public string BuId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bu_name")]
        public string BuName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "is_default")]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organization")]
        public ResourceOfOrganization Organization { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "teams")]
        public IList<ResourceOfTeam> Teams { get; set; }

    }
}
