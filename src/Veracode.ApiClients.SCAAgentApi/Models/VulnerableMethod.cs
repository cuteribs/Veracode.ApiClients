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
    /// VulnerableMethod
    /// </summary>
    public partial class VulnerableMethod
    {
        /// <summary>
        /// Initializes a new instance of the VulnerableMethod class.
        /// </summary>
        public VulnerableMethod()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VulnerableMethod class.
        /// </summary>
        public VulnerableMethod(MethodSummary method = default(MethodSummary), IList<IList<CallSite>> callChains = default(IList<IList<CallSite>>))
        {
            Method = method;
            CallChains = callChains;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "method")]
        public MethodSummary Method { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "call_chains")]
        public IList<IList<CallSite>> CallChains { get; set; }

    }
}
