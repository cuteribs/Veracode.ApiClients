// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Veracode.ApiClients.SCAAgentApi.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Hash Objects
    /// </summary>
    public partial class Hash
    {
        /// <summary>
        /// Initializes a new instance of the Hash class.
        /// </summary>
        public Hash()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Hash class.
        /// </summary>
        /// <param name="alg">Possible values include: 'MD5', 'SHA-1',
        /// 'SHA-256', 'SHA-384', 'SHA-512', 'SHA3-256', 'SHA3-384',
        /// 'SHA3-512', 'BLAKE2b-256', 'BLAKE2b-384', 'BLAKE2b-512',
        /// 'BLAKE3'</param>
        public Hash(string alg, string content)
        {
            Alg = alg;
            Content = content;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'MD5', 'SHA-1', 'SHA-256',
        /// 'SHA-384', 'SHA-512', 'SHA3-256', 'SHA3-384', 'SHA3-512',
        /// 'BLAKE2b-256', 'BLAKE2b-384', 'BLAKE2b-512', 'BLAKE3'
        /// </summary>
        [JsonProperty(PropertyName = "alg")]
        public string Alg { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "content")]
        public string Content { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Alg == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Alg");
            }
            if (Content == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Content");
            }
        }
    }
}
