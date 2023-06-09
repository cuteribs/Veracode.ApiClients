// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Veracode.ApiClients.DynamicFlawApi.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class DynamicFlaw
    {
        /// <summary>
        /// Initializes a new instance of the DynamicFlaw class.
        /// </summary>
        public DynamicFlaw()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DynamicFlaw class.
        /// </summary>
        public DynamicFlaw(IssueSummary issueSummary = default(IssueSummary), DynamicSpecificFlawInfo dynamicFlawInfo = default(DynamicSpecificFlawInfo), ErrorLinks _links = default(ErrorLinks))
        {
            IssueSummary = issueSummary;
            DynamicFlawInfo = dynamicFlawInfo;
            this._links = _links;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "issue_summary")]
        public IssueSummary IssueSummary { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dynamic_flaw_info")]
        public DynamicSpecificFlawInfo DynamicFlawInfo { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_links")]
        public ErrorLinks _links { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (_links != null)
            {
                _links.Validate();
            }
        }
    }
}
