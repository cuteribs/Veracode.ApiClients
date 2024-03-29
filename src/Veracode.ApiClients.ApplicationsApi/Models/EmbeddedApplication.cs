// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Veracode.ApiClients.ApplicationsApi.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// EmbeddedApplication
    /// </summary>
    public partial class EmbeddedApplication
    {
        /// <summary>
        /// Initializes a new instance of the EmbeddedApplication class.
        /// </summary>
        public EmbeddedApplication()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EmbeddedApplication class.
        /// </summary>
        public EmbeddedApplication(IList<Application> applications = default(IList<Application>))
        {
            Applications = applications;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "applications")]
        public IList<Application> Applications { get; set; }

    }
}
