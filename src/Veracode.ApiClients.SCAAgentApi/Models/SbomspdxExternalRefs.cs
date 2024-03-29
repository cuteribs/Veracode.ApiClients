// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Veracode.ApiClients.SCAAgentApi.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class SbomspdxExternalRefs
    {
        /// <summary>
        /// Initializes a new instance of the SbomspdxExternalRefs class.
        /// </summary>
        public SbomspdxExternalRefs()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SbomspdxExternalRefs class.
        /// </summary>
        /// <param name="comment">Vulnerability details wrapped in a json
        /// string. json schema refer to following link:
        /// #/definitions/spdxvulnerability</param>
        /// <param name="referenceCategory">SPDX package external reference
        /// category. It will be fixed value SECURITY in Veracode SPDX
        /// document</param>
        /// <param name="referenceLocator">Vulnerability reference web
        /// page</param>
        /// <param name="referenceType">PDX package external reference type, It
        /// will be fixed value advisory in Veracode SPDX document</param>
        public SbomspdxExternalRefs(string comment = default(string), string referenceCategory = default(string), string referenceLocator = default(string), string referenceType = default(string))
        {
            Comment = comment;
            ReferenceCategory = referenceCategory;
            ReferenceLocator = referenceLocator;
            ReferenceType = referenceType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets vulnerability details wrapped in a json string. json
        /// schema refer to following link: #/definitions/spdxvulnerability
        /// </summary>
        [JsonProperty(PropertyName = "comment")]
        public string Comment { get; set; }

        /// <summary>
        /// Gets or sets SPDX package external reference category. It will be
        /// fixed value SECURITY in Veracode SPDX document
        /// </summary>
        [JsonProperty(PropertyName = "referenceCategory")]
        public string ReferenceCategory { get; set; }

        /// <summary>
        /// Gets or sets vulnerability reference web page
        /// </summary>
        [JsonProperty(PropertyName = "referenceLocator")]
        public string ReferenceLocator { get; set; }

        /// <summary>
        /// Gets or sets PDX package external reference type, It will be fixed
        /// value advisory in Veracode SPDX document
        /// </summary>
        [JsonProperty(PropertyName = "referenceType")]
        public string ReferenceType { get; set; }

    }
}
