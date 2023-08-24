// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Veracode.ApiClients.SCAAgentApi.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// License(s)
    /// </summary>
    public partial class LicenseChoice
    {
        /// <summary>
        /// Initializes a new instance of the LicenseChoice class.
        /// </summary>
        public LicenseChoice()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LicenseChoice class.
        /// </summary>
        public LicenseChoice(License license = default(License), string expression = default(string))
        {
            License = license;
            Expression = expression;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "license")]
        public License License { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "expression")]
        public string Expression { get; set; }

    }
}
