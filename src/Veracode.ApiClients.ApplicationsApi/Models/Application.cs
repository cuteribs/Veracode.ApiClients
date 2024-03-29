// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Veracode.ApiClients.ApplicationsApi.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Application
    /// </summary>
    public partial class Application
    {
        /// <summary>
        /// Initializes a new instance of the Application class.
        /// </summary>
        public Application()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Application class.
        /// </summary>
        /// <param name="appProfileUrl">Unique path to the application
        /// profile.</param>
        /// <param name="created">The date and time when the application was
        /// created. The date/time format is per RFC3339 and ISO-8601, and the
        /// timezone is UTC. Example: 2019-04-12T23:20:50.52Z.</param>
        /// <param name="lastCompletedScanDate">Date and time of the last
        /// completed scan for this application. The date/time format is per
        /// RFC3339 and ISO-8601, and the timezone is UTC. Example:
        /// 2019-04-12T23:20:50.52Z.</param>
        /// <param name="modified">The date and time when the application was
        /// modified. The date/time format is per RFC3339 and ISO-8601, and the
        /// timezone is UTC. Example: 2019-04-12T23:20:50.52Z.</param>
        /// <param name="resultsUrl">Unique path to the latest results.</param>
        public Application(string appProfileUrl = default(string), System.DateTime? created = default(System.DateTime?), string guid = default(string), int? id = default(int?), System.DateTime? lastCompletedScanDate = default(System.DateTime?), System.DateTime? modified = default(System.DateTime?), int? oid = default(int?), int? organizationId = default(int?), ApplicationProfile profile = default(ApplicationProfile), string resultsUrl = default(string), IList<ApplicationScan> scans = default(IList<ApplicationScan>))
        {
            AppProfileUrl = appProfileUrl;
            Created = created;
            Guid = guid;
            Id = id;
            LastCompletedScanDate = lastCompletedScanDate;
            Modified = modified;
            Oid = oid;
            OrganizationId = organizationId;
            Profile = profile;
            ResultsUrl = resultsUrl;
            Scans = scans;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets unique path to the application profile.
        /// </summary>
        [JsonProperty(PropertyName = "app_profile_url")]
        public string AppProfileUrl { get; private set; }

        /// <summary>
        /// Gets the date and time when the application was created. The
        /// date/time format is per RFC3339 and ISO-8601, and the timezone is
        /// UTC. Example: 2019-04-12T23:20:50.52Z.
        /// </summary>
        [JsonProperty(PropertyName = "created")]
        public System.DateTime? Created { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "guid")]
        public string Guid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// Gets date and time of the last completed scan for this application.
        /// The date/time format is per RFC3339 and ISO-8601, and the timezone
        /// is UTC. Example: 2019-04-12T23:20:50.52Z.
        /// </summary>
        [JsonProperty(PropertyName = "last_completed_scan_date")]
        public System.DateTime? LastCompletedScanDate { get; private set; }

        /// <summary>
        /// Gets the date and time when the application was modified. The
        /// date/time format is per RFC3339 and ISO-8601, and the timezone is
        /// UTC. Example: 2019-04-12T23:20:50.52Z.
        /// </summary>
        [JsonProperty(PropertyName = "modified")]
        public System.DateTime? Modified { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "oid")]
        public int? Oid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organization_id")]
        public int? OrganizationId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "profile")]
        public ApplicationProfile Profile { get; set; }

        /// <summary>
        /// Gets unique path to the latest results.
        /// </summary>
        [JsonProperty(PropertyName = "results_url")]
        public string ResultsUrl { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "scans")]
        public IList<ApplicationScan> Scans { get; set; }

    }
}
