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
    /// BusinessUnit
    /// </summary>
    public partial class BusinessUnit
    {
        /// <summary>
        /// Initializes a new instance of the BusinessUnit class.
        /// </summary>
        public BusinessUnit()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BusinessUnit class.
        /// </summary>
        /// <param name="guid">The business unit GUID.</param>
        /// <param name="id">The business unit ID in the Veracode
        /// database.</param>
        /// <param name="name">The business unit name.</param>
        public BusinessUnit(string guid = default(string), int? id = default(int?), string name = default(string))
        {
            Guid = guid;
            Id = id;
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the business unit GUID.
        /// </summary>
        [JsonProperty(PropertyName = "guid")]
        public string Guid { get; set; }

        /// <summary>
        /// Gets the business unit ID in the Veracode database.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; private set; }

        /// <summary>
        /// Gets the business unit name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

    }
}
