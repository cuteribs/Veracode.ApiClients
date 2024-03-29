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
    /// Scan
    /// </summary>
    public partial class Scan
    {
        /// <summary>
        /// Initializes a new instance of the Scan class.
        /// </summary>
        public Scan()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Scan class.
        /// </summary>
        public Scan(IList<Link> _links = default(IList<Link>), string branch = default(string), string commit = default(string), System.DateTime? date = default(System.DateTime?), System.Guid? id = default(System.Guid?), string tag = default(string))
        {
            this._links = _links;
            Branch = branch;
            Commit = commit;
            Date = date;
            Id = id;
            Tag = tag;
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
        [JsonProperty(PropertyName = "branch")]
        public string Branch { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "commit")]
        public string Commit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "date")]
        public System.DateTime? Date { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public System.Guid? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tag")]
        public string Tag { get; set; }

    }
}
