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
    /// LicenseSummary
    /// </summary>
    /// <remarks>
    /// License Summary. Only set for issue_type=license.
    /// </remarks>
    public partial class LicenseSummary
    {
        /// <summary>
        /// Initializes a new instance of the LicenseSummary class.
        /// </summary>
        public LicenseSummary()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LicenseSummary class.
        /// </summary>
        /// <param name="risk">Possible values include: 'UNKNOWN', 'LOW',
        /// 'MEDIUM', 'HIGH'</param>
        public LicenseSummary(IList<Link> _links = default(IList<Link>), string id = default(string), string name = default(string), string risk = default(string))
        {
            this._links = _links;
            Id = id;
            Name = name;
            Risk = risk;
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
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'UNKNOWN', 'LOW', 'MEDIUM',
        /// 'HIGH'
        /// </summary>
        [JsonProperty(PropertyName = "risk")]
        public string Risk { get; set; }

    }
}
