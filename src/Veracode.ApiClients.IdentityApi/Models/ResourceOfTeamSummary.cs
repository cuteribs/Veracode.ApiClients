// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Veracode.ApiClients.IdentityApi.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ResourceOfTeamSummary
    {
        /// <summary>
        /// Initializes a new instance of the ResourceOfTeamSummary class.
        /// </summary>
        public ResourceOfTeamSummary()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResourceOfTeamSummary class.
        /// </summary>
        /// <param name="teamId">The team ID in the Veracode Identity
        /// API.</param>
        /// <param name="teamLegacyId">The ID in the Veracode database.</param>
        /// <param name="teamName">The team name.</param>
        /// <param name="relationship">Enum to indicate the relationship this
        /// user has with this team. Possible values include: 'ADMIN',
        /// 'MEMBER'</param>
        public ResourceOfTeamSummary(string teamId = default(string), int? teamLegacyId = default(int?), string teamName = default(string), string relationship = default(string), ResourceOfOrganizationSummary organization = default(ResourceOfOrganizationSummary), ResourceOfBusinessUnitSummary businessUnit = default(ResourceOfBusinessUnitSummary), object _links = default(object))
        {
            TeamId = teamId;
            TeamLegacyId = teamLegacyId;
            TeamName = teamName;
            Relationship = relationship;
            Organization = organization;
            BusinessUnit = businessUnit;
            this._links = _links;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the team ID in the Veracode Identity API.
        /// </summary>
        [JsonProperty(PropertyName = "team_id")]
        public string TeamId { get; set; }

        /// <summary>
        /// Gets or sets the ID in the Veracode database.
        /// </summary>
        [JsonProperty(PropertyName = "team_legacy_id")]
        public int? TeamLegacyId { get; set; }

        /// <summary>
        /// Gets or sets the team name.
        /// </summary>
        [JsonProperty(PropertyName = "team_name")]
        public string TeamName { get; set; }

        /// <summary>
        /// Gets or sets enum to indicate the relationship this user has with
        /// this team. Possible values include: 'ADMIN', 'MEMBER'
        /// </summary>
        [JsonProperty(PropertyName = "relationship")]
        public string Relationship { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organization")]
        public ResourceOfOrganizationSummary Organization { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "business_unit")]
        public ResourceOfBusinessUnitSummary BusinessUnit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_links")]
        public object _links { get; set; }

    }
}
