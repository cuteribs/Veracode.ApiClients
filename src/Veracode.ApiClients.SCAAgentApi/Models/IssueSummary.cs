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
    /// IssueSummary
    /// </summary>
    public partial class IssueSummary
    {
        /// <summary>
        /// Initializes a new instance of the IssueSummary class.
        /// </summary>
        public IssueSummary()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IssueSummary class.
        /// </summary>
        /// <param name="issueStatus">Possible values include: 'fixed',
        /// 'open'</param>
        /// <param name="issueType">Possible values include: 'library',
        /// 'license', 'vulnerability'</param>
        /// <param name="issueCreationSource">Possible values include: 'scan',
        /// 'vulnerability'</param>
        /// <param name="libraryUpdatedReleaseDate">Library update release
        /// date. Only set for issue_type=library.</param>
        /// <param name="libraryUpdatedVersion">Library update version. Only
        /// set for issue_type=library.</param>
        /// <param name="licenseCount">License count. Only set for
        /// issue_type=license.</param>
        /// <param name="vulnerableMethod">Only set for
        /// issue_type=vulnerability.</param>
        /// <param name="vulnerableMethodInformation">Only set for
        /// issue_type=vulnerability.</param>
        public IssueSummary(IList<Link> _links = default(IList<Link>), System.DateTime? createdDate = default(System.DateTime?), System.Guid? id = default(System.Guid?), bool? ignored = default(bool?), string issueStatus = default(string), string issueType = default(string), string issueCreationSource = default(string), LibrarySummary library = default(LibrarySummary), System.DateTime? libraryUpdatedReleaseDate = default(System.DateTime?), string libraryUpdatedVersion = default(string), LicenseSummary license = default(LicenseSummary), int? licenseCount = default(int?), string projectBranch = default(string), System.Guid? projectId = default(System.Guid?), string projectName = default(string), string projectTag = default(string), double? severity = default(double?), long? siteId = default(long?), VulnerabilitySummary vulnerability = default(VulnerabilitySummary), bool? vulnerableMethod = default(bool?), string vulnerableMethodInformation = default(string), System.Guid? workspaceId = default(System.Guid?))
        {
            this._links = _links;
            CreatedDate = createdDate;
            Id = id;
            Ignored = ignored;
            IssueStatus = issueStatus;
            IssueType = issueType;
            IssueCreationSource = issueCreationSource;
            Library = library;
            LibraryUpdatedReleaseDate = libraryUpdatedReleaseDate;
            LibraryUpdatedVersion = libraryUpdatedVersion;
            License = license;
            LicenseCount = licenseCount;
            ProjectBranch = projectBranch;
            ProjectId = projectId;
            ProjectName = projectName;
            ProjectTag = projectTag;
            Severity = severity;
            SiteId = siteId;
            Vulnerability = vulnerability;
            VulnerableMethod = vulnerableMethod;
            VulnerableMethodInformation = vulnerableMethodInformation;
            WorkspaceId = workspaceId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_links")]
        public IList<Link> _links { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "created_date")]
        public System.DateTime? CreatedDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public System.Guid? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ignored")]
        public bool? Ignored { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'fixed', 'open'
        /// </summary>
        [JsonProperty(PropertyName = "issue_status")]
        public string IssueStatus { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'library', 'license',
        /// 'vulnerability'
        /// </summary>
        [JsonProperty(PropertyName = "issue_type")]
        public string IssueType { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'scan', 'vulnerability'
        /// </summary>
        [JsonProperty(PropertyName = "issue_creation_source")]
        public string IssueCreationSource { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "library")]
        public LibrarySummary Library { get; set; }

        /// <summary>
        /// Gets or sets library update release date. Only set for
        /// issue_type=library.
        /// </summary>
        [JsonProperty(PropertyName = "library_updated_release_date")]
        public System.DateTime? LibraryUpdatedReleaseDate { get; set; }

        /// <summary>
        /// Gets or sets library update version. Only set for
        /// issue_type=library.
        /// </summary>
        [JsonProperty(PropertyName = "library_updated_version")]
        public string LibraryUpdatedVersion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "license")]
        public LicenseSummary License { get; set; }

        /// <summary>
        /// Gets or sets license count. Only set for issue_type=license.
        /// </summary>
        [JsonProperty(PropertyName = "license_count")]
        public int? LicenseCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "project_branch")]
        public string ProjectBranch { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "project_id")]
        public System.Guid? ProjectId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "project_name")]
        public string ProjectName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "project_tag")]
        public string ProjectTag { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "severity")]
        public double? Severity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "site_id")]
        public long? SiteId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "vulnerability")]
        public VulnerabilitySummary Vulnerability { get; set; }

        /// <summary>
        /// Gets or sets only set for issue_type=vulnerability.
        /// </summary>
        [JsonProperty(PropertyName = "vulnerable_method")]
        public bool? VulnerableMethod { get; set; }

        /// <summary>
        /// Gets or sets only set for issue_type=vulnerability.
        /// </summary>
        [JsonProperty(PropertyName = "vulnerable_method_information")]
        public string VulnerableMethodInformation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "workspace_id")]
        public System.Guid? WorkspaceId { get; set; }

    }
}
