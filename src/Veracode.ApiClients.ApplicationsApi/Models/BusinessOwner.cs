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
    /// BusinessOwner
    /// </summary>
    public partial class BusinessOwner
    {
        /// <summary>
        /// Initializes a new instance of the BusinessOwner class.
        /// </summary>
        public BusinessOwner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BusinessOwner class.
        /// </summary>
        public BusinessOwner(string email = default(string), string name = default(string))
        {
            Email = email;
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

    }
}
