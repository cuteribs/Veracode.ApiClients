// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Veracode.ApiClients.SummaryReportApi.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Details about the vulnerable components.
    /// </summary>
    public partial class VulnerableComponentList
    {
        /// <summary>
        /// Initializes a new instance of the VulnerableComponentList class.
        /// </summary>
        public VulnerableComponentList()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VulnerableComponentList class.
        /// </summary>
        public VulnerableComponentList(IList<Component> component = default(IList<Component>))
        {
            Component = component;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "component")]
        public IList<Component> Component { get; set; }

    }
}
