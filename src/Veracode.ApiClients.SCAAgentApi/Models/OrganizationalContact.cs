// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Veracode.ApiClients.SCAAgent.Api.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Organizational Contact Object
    /// </summary>
    public partial class OrganizationalContact
    {
        /// <summary>
        /// Initializes a new instance of the OrganizationalContact class.
        /// </summary>
        public OrganizationalContact()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OrganizationalContact class.
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="email">Email Address</param>
        public OrganizationalContact(string name = default(string), string email = default(string))
        {
            Name = name;
            Email = email;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name
        /// </summary>
        /// <remarks>
        /// The name of a contact.
        /// </remarks>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets email Address
        /// </summary>
        /// <remarks>
        /// The email address of the contact.
        /// </remarks>
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

    }
}
