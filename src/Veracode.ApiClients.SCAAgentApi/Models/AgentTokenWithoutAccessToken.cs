// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Veracode.ApiClients.SCAAgentApi.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// AgentToken
    /// </summary>
    public partial class AgentTokenWithoutAccessToken
    {
        /// <summary>
        /// Initializes a new instance of the AgentTokenWithoutAccessToken
        /// class.
        /// </summary>
        public AgentTokenWithoutAccessToken()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AgentTokenWithoutAccessToken
        /// class.
        /// </summary>
        public AgentTokenWithoutAccessToken(IList<Link> _links = default(IList<Link>), string createdBy = default(string), System.DateTime? createdDate = default(System.DateTime?), string id = default(string))
        {
            this._links = _links;
            CreatedBy = createdBy;
            CreatedDate = createdDate;
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_links")]
        public IList<Link> _links { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "created_by")]
        public string CreatedBy { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "created_date")]
        public System.DateTime? CreatedDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

    }
}