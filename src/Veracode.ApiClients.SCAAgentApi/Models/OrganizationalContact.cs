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
        /// <param name="name">The name of a contact.</param>
        /// <param name="email">The email address of the contact.</param>
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
        /// Gets or sets the name of a contact.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the email address of the contact.
        /// </summary>
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

    }
}
