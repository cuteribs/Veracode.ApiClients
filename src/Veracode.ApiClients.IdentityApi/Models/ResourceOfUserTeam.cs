// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Veracode.ApiClients.IdentityApi.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ResourceOfUserTeam
    {
        /// <summary>
        /// Initializes a new instance of the ResourceOfUserTeam class.
        /// </summary>
        public ResourceOfUserTeam()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResourceOfUserTeam class.
        /// </summary>
        /// <param name="relationship">Enum to indicate the relationship this
        /// user has with this team. Possible values include: 'ADMIN',
        /// 'MEMBER'</param>
        /// <param name="teamId">The team ID in the Veracode Identity
        /// API.</param>
        /// <param name="teamLegacyId">The team ID in the Veracode
        /// database.</param>
        /// <param name="teamName">The team name.</param>
        /// <param name="userId">The user ID in the Veracode Identity
        /// API.</param>
        /// <param name="userLegacyId">The user ID in the Veracode
        /// database.</param>
        /// <param name="userName">The username of the user.</param>
        public ResourceOfUserTeam(object _links = default(object), string relationship = default(string), string teamId = default(string), int? teamLegacyId = default(int?), string teamName = default(string), string userId = default(string), int? userLegacyId = default(int?), string userName = default(string))
        {
            this._links = _links;
            Relationship = relationship;
            TeamId = teamId;
            TeamLegacyId = teamLegacyId;
            TeamName = teamName;
            UserId = userId;
            UserLegacyId = userLegacyId;
            UserName = userName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_links")]
        public object _links { get; set; }

        /// <summary>
        /// Gets or sets enum to indicate the relationship this user has with
        /// this team. Possible values include: 'ADMIN', 'MEMBER'
        /// </summary>
        [JsonProperty(PropertyName = "relationship")]
        public string Relationship { get; set; }

        /// <summary>
        /// Gets or sets the team ID in the Veracode Identity API.
        /// </summary>
        [JsonProperty(PropertyName = "team_id")]
        public string TeamId { get; set; }

        /// <summary>
        /// Gets or sets the team ID in the Veracode database.
        /// </summary>
        [JsonProperty(PropertyName = "team_legacy_id")]
        public int? TeamLegacyId { get; set; }

        /// <summary>
        /// Gets or sets the team name.
        /// </summary>
        [JsonProperty(PropertyName = "team_name")]
        public string TeamName { get; set; }

        /// <summary>
        /// Gets or sets the user ID in the Veracode Identity API.
        /// </summary>
        [JsonProperty(PropertyName = "user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// Gets or sets the user ID in the Veracode database.
        /// </summary>
        [JsonProperty(PropertyName = "user_legacy_id")]
        public int? UserLegacyId { get; set; }

        /// <summary>
        /// Gets or sets the username of the user.
        /// </summary>
        [JsonProperty(PropertyName = "user_name")]
        public string UserName { get; set; }

    }
}
