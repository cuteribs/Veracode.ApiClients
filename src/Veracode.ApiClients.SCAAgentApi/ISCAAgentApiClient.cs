// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Veracode.ApiClients.SCAAgentApi
{
    using Microsoft.Rest;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Veracode SCA Agent API Documentation.
    ///
    /// If using SourceClear API credentials, use the default host URL:
    /// api.sourceclear.io/srcclr.
    ///
    /// If using Veracode credentials, use one of the following base URLs
    /// depending on the region for your account:
    /// * https://api.veracode.com/srcclr - Veracode US Region (default)
    /// * https://api.veracode.eu/srcclr - Veracode European Region
    /// * https://api.veracode.us/srcclr - Veracode US Federal Region
    /// </summary>
    public partial interface ISCAAgentApiClient : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }


        /// <summary>
        /// Gets the IGetTeamsUsingGET.
        /// </summary>
        IGetTeamsUsingGET GetTeamsUsingGET { get; }

        /// <summary>
        /// AuditEvents for the organization.
        /// </summary>
        /// <remarks>
        /// Get audit events for your organization.
        /// </remarks>
        /// <param name='dateGte'>
        /// Filter by events occurring on or after the specified date.
        /// </param>
        /// <param name='group'>
        /// Filter by event group.
        /// </param>
        /// <param name='page'>
        /// Results page you want to retrieve (0..N).
        /// </param>
        /// <param name='size'>
        /// Number of records per page.
        /// </param>
        /// <param name='type'>
        /// Filter by event type.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<PagedResourcesAuditEvent>> GetAuditUsingGETWithHttpMessagesAsync(System.DateTime? dateGte = default(System.DateTime?), string group = default(string), int? page = default(int?), int? size = default(int?), string type = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// getIssue
        /// </summary>
        /// <param name='id'>
        /// Issue ID.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<IssueDetailed>> GetIssueUsingGETWithHttpMessagesAsync(System.Guid id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// getLibrary
        /// </summary>
        /// <param name='id'>
        /// Library instance reference ID. &lt;br/&gt; ID values have this
        /// format: coordinateType:coordinate1:coordinate2:version:platform
        /// &lt;br/&gt; Example: maven:net.minidev:json-smart:1.3.1:
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<LibraryDetailed>> GetLibraryUsingGETWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// getLicense
        /// </summary>
        /// <param name='id'>
        /// License ID.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<LicenseDetailed>> GetLicenseUsingGETWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// getComponentActivity
        /// </summary>
        /// <param name='id'>
        /// Library instance reference ID. &lt;br/&gt; ID values have this
        /// format: coordinateType:coordinate1:coordinate2:version:platform
        /// &lt;br/&gt; Example: maven:net.minidev:json-smart:1.3.1:
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<ComponentMetricsModel>> GetComponentActivityUsingGETWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// getScan
        /// </summary>
        /// <param name='id'>
        /// Scan ID.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<Scan>> GetScanUsingGETWithHttpMessagesAsync(System.Guid id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// getTeams
        /// </summary>
        /// <remarks>
        /// Get all teams for an account.
        /// </remarks>
        /// <param name='name'>
        /// Filter by team name.
        /// </param>
        /// <param name='page'>
        /// The page of results that you want to retrieve (0..N).
        /// </param>
        /// <param name='size'>
        /// The number of records per page.
        /// </param>
        /// <param name='sort'>
        /// Sorting criteria in the format: property(asc|desc). The default
        /// order is name ascending.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<ResourcesTeam>> GetTeamsUsingGETWithHttpMessagesAsync(string name = default(string), int? page = default(int?), int? size = default(int?), IList<string> sort = default(IList<string>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// getTeam
        /// </summary>
        /// <remarks>
        /// Get team information with the given team id.
        /// </remarks>
        /// <param name='id'>
        /// Team ID.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<Team>> GetTeamUsingGETWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// getVulnerability
        /// </summary>
        /// <param name='id'>
        /// Vulnerability ID.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<VulnerabilityDetailed>> GetVulnerabilityUsingGETWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// getWorkspaces
        /// </summary>
        /// <remarks>
        /// Get visible workspaces. Workspace visibility depends on workspace
        /// membership and user permissions.
        /// </remarks>
        /// <param name='filterlibrary'>
        /// The library name filter.
        /// </param>
        /// <param name='filterlicense'>
        /// The license name filter.
        /// </param>
        /// <param name='filterproject'>
        /// The project name filter.
        /// </param>
        /// <param name='filtervulnerability'>
        /// The vulnerability title filter.
        /// </param>
        /// <param name='filterworkspace'>
        /// The workspace name filter.
        /// </param>
        /// <param name='page'>
        /// The page of results that you want to retrieve (0..N).
        /// </param>
        /// <param name='size'>
        /// The number of records per page.
        /// </param>
        /// <param name='sort'>
        /// Sorting criteria in the format: property(asc|desc). The default
        /// order is ascending.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<PagedResourcesWorkspace>> GetWorkspacesUsingGETWithHttpMessagesAsync(IList<string> filterlibrary = default(IList<string>), IList<string> filterlicense = default(IList<string>), IList<string> filterproject = default(IList<string>), IList<string> filtervulnerability = default(IList<string>), IList<string> filterworkspace = default(IList<string>), int? page = default(int?), int? size = default(int?), IList<string> sort = default(IList<string>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// createWorkspace
        /// </summary>
        /// <remarks>
        /// Create a workspace using the workspace TeamInputModel.
        /// </remarks>
        /// <param name='inputModel'>
        /// Team model containing the team name, description, and memberships.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<ResponseEntity>> CreateWorkspaceUsingPOSTWithHttpMessagesAsync(CreateWorkspaceModel inputModel, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// getWorkspace
        /// </summary>
        /// <remarks>
        /// Get single workspace.
        /// </remarks>
        /// <param name='id'>
        /// Workspace ID.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<Workspace>> GetWorkspaceUsingGETWithHttpMessagesAsync(System.Guid id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// deleteWorkspace
        /// </summary>
        /// <remarks>
        /// Delete workspace.
        /// </remarks>
        /// <param name='id'>
        /// Workspace ID.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> DeleteWorkspaceUsingDELETEWithHttpMessagesAsync(System.Guid id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// getIssues
        /// </summary>
        /// <remarks>
        /// Get issues for the given workspace. Note: If a project Default
        /// Branch is set or a branch name is given, only issues from scans of
        /// that branch are displayed.
        /// </remarks>
        /// <param name='id'>
        /// Workspace ID.
        /// </param>
        /// <param name='branch'>
        /// Filter by branch name.
        /// </param>
        /// <param name='createdAfter'>
        /// Filter by issues created on or after the specified date.
        /// </param>
        /// <param name='createdBefore'>
        /// Filter by issues created on or before the specified date.
        /// </param>
        /// <param name='direct'>
        /// Filter by direct dependency.
        /// </param>
        /// <param name='ignored'>
        /// If true, show only ignored issues.
        /// </param>
        /// <param name='page'>
        /// Results page you want to retrieve (0..N).
        /// </param>
        /// <param name='projectId'>
        /// Filter 0 or more project IDs.
        /// </param>
        /// <param name='scansAfter'>
        /// Filter by issues last seen in scans on or after the specified scan
        /// date.
        /// </param>
        /// <param name='scansBefore'>
        /// Filter by issues last seen in scans on or before the specified scan
        /// date.
        /// </param>
        /// <param name='search'>
        /// Filter by issues matching the provided text search.
        /// </param>
        /// <param name='severityGt'>
        /// Filter by issue severity greater than the provided value.
        /// </param>
        /// <param name='severityGte'>
        /// Filter by issue severity greater than or equal to the provided
        /// value.
        /// </param>
        /// <param name='severityLt'>
        /// Filter by issue severity less than the provided value.
        /// </param>
        /// <param name='severityLte'>
        /// Filter by issue severity less than or equal to the provided value.
        /// </param>
        /// <param name='size'>
        /// Number of records per page.
        /// </param>
        /// <param name='sort'>
        /// Sorting criteria in the format: property(,asc|desc). Default order
        /// is created date descending.
        /// </param>
        /// <param name='status'>
        /// Filter by issue status.
        /// </param>
        /// <param name='type'>
        /// Filter by issue type.
        /// </param>
        /// <param name='vulnMethods'>
        /// Filter by vulnerable methods.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<PagedResourcesIssueSummary>> GetIssuesUsingGETWithHttpMessagesAsync(System.Guid id, string branch = default(string), System.DateTime? createdAfter = default(System.DateTime?), System.DateTime? createdBefore = default(System.DateTime?), bool? direct = default(bool?), bool? ignored = default(bool?), int? page = default(int?), IList<System.Guid?> projectId = default(IList<System.Guid?>), System.DateTime? scansAfter = default(System.DateTime?), System.DateTime? scansBefore = default(System.DateTime?), string search = default(string), double? severityGt = default(double?), double? severityGte = default(double?), double? severityLt = default(double?), double? severityLte = default(double?), int? size = default(int?), IList<string> sort = default(IList<string>), IList<string> status = default(IList<string>), IList<string> type = default(IList<string>), bool? vulnMethods = default(bool?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// getLibraries
        /// </summary>
        /// <remarks>
        /// Get libraries for the given workspace.
        /// </remarks>
        /// <param name='id'>
        /// Workspace ID.
        /// </param>
        /// <param name='direct'>
        /// Filter by direct dependencies only, false will filter by indirect
        /// dependencies.
        /// </param>
        /// <param name='hasVulnerabilities'>
        /// Filter by libraries with vulnerabilities only. If false, filter by
        /// libraries with no vulnerabilities.
        /// </param>
        /// <param name='outOfDate'>
        /// Filter by out-of-date libraries only. If false, filter by
        /// up-to-date libraries.
        /// </param>
        /// <param name='page'>
        /// Results page you want to retrieve (0..N).
        /// </param>
        /// <param name='search'>
        /// Filter by library names matching the provided text search.
        /// </param>
        /// <param name='size'>
        /// Number of records per page.
        /// </param>
        /// <param name='sort'>
        /// Sorting criteria in the format: property(asc|desc). Default order
        /// is name ascending.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<PagedResourcesLibrarySummary>> GetLibrariesUsingGETWithHttpMessagesAsync(System.Guid id, bool? direct = default(bool?), bool? hasVulnerabilities = default(bool?), bool? outOfDate = default(bool?), int? page = default(int?), string search = default(string), int? size = default(int?), IList<string> sort = default(IList<string>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// getUnmatchedLibraries
        /// </summary>
        /// <remarks>
        /// Get unmatched libraries for the given workspace.
        /// </remarks>
        /// <param name='id'>
        /// Workspace ID.
        /// </param>
        /// <param name='page'>
        /// Results page you want to retrieve (0..N).
        /// </param>
        /// <param name='search'>
        /// Filter by unmatched library names matching the provided text
        /// search.
        /// </param>
        /// <param name='size'>
        /// Number of records per page.
        /// </param>
        /// <param name='sort'>
        /// Sorting criteria in the format: property(asc|desc). Default order
        /// is name ascending.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<PagedResourcesUnmatchedLibraryReportResource>> GetUnmatchedLibrariesUsingGETWithHttpMessagesAsync(System.Guid id, int? page = default(int?), string search = default(string), int? size = default(int?), IList<string> sort = default(IList<string>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// getWorkspaceProjects
        /// </summary>
        /// <remarks>
        /// Get workspace projects.
        /// </remarks>
        /// <param name='id'>
        /// Workspace ID.
        /// </param>
        /// <param name='page'>
        /// The page of results that you want to retrieve (0..N).
        /// </param>
        /// <param name='search'>
        /// The Project name filter.
        /// </param>
        /// <param name='size'>
        /// The number of records per page.
        /// </param>
        /// <param name='sort'>
        /// Sorting criteria in the format: property(asc|desc). The default
        /// order is name ascending.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<PagedResourcesProject>> GetWorkspaceProjectsUsingGETWithHttpMessagesAsync(System.Guid id, int? page = default(int?), string search = default(string), int? size = default(int?), IList<string> sort = default(IList<string>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// getProjects
        /// </summary>
        /// <remarks>
        /// Get single project in an agent-based scan workspace.
        /// </remarks>
        /// <param name='id'>
        /// Workspace ID.
        /// </param>
        /// <param name='projectId'>
        /// Project ID.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<Project>> GetProjectsUsingGETWithHttpMessagesAsync(System.Guid id, System.Guid projectId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// getProjectIssues
        /// </summary>
        /// <remarks>
        /// Get issues from a project in an agent-based scan workspace,
        /// including the linked container project.
        /// </remarks>
        /// <param name='id'>
        /// Workspace ID.
        /// </param>
        /// <param name='projectId'>
        /// Project ID.
        /// </param>
        /// <param name='linkedProjects'>
        /// Request issues from linked projects.
        /// </param>
        /// <param name='status'>
        /// Filter by issue status.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<PagedResourcesIssueSummary>> GetProjectIssuesUsingGETWithHttpMessagesAsync(System.Guid id, System.Guid projectId, bool? linkedProjects = default(bool?), IList<string> status = default(IList<string>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// getProjectLibraries
        /// </summary>
        /// <remarks>
        /// Get libraries from a project in an agent-based scan workspace.
        /// </remarks>
        /// <param name='id'>
        /// Workspace ID.
        /// </param>
        /// <param name='projectId'>
        /// Project ID.
        /// </param>
        /// <param name='direct'>
        /// Filter by direct dependencies only. If false, filter by indirect
        /// dependencies only.
        /// </param>
        /// <param name='hasVulnerabilities'>
        /// Filter by libraries with vulnerabilities only. If false, filter by
        /// libraries with no vulnerabilities.
        /// </param>
        /// <param name='outOfDate'>
        /// Filter by out-of-date libraries only. If false, filter by
        /// up-to-date libraries only.
        /// </param>
        /// <param name='page'>
        /// Results page you want to retrieve (0..N).
        /// </param>
        /// <param name='search'>
        /// Filter by library names matching the provided text search.
        /// </param>
        /// <param name='size'>
        /// Number of records per page.
        /// </param>
        /// <param name='sort'>
        /// Sorting criteria in the format: property(asc|desc). Default order
        /// is name ascending.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<PagedResourcesLibrarySummary>> GetProjectLibrariesUsingGETWithHttpMessagesAsync(System.Guid id, System.Guid projectId, bool? direct = default(bool?), bool? hasVulnerabilities = default(bool?), bool? outOfDate = default(bool?), int? page = default(int?), string search = default(string), int? size = default(int?), IList<string> sort = default(IList<string>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// addTeam
        /// </summary>
        /// <remarks>
        /// Add teams to a workspace.
        /// </remarks>
        /// <param name='id'>
        /// Workspace ID.
        /// </param>
        /// <param name='teamId'>
        /// Team ID.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<ResponseEntity>> AddTeamUsingPUTWithHttpMessagesAsync(System.Guid id, string teamId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// deleteTeam
        /// </summary>
        /// <remarks>
        /// Remove teams from a workspace.
        /// </remarks>
        /// <param name='id'>
        /// Workspace ID.
        /// </param>
        /// <param name='teamId'>
        /// Team ID.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> DeleteTeamUsingDELETEWithHttpMessagesAsync(System.Guid id, string teamId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// getWorkspaceAgents
        /// </summary>
        /// <remarks>
        /// Get a list of agents tied to the given workspace.
        /// </remarks>
        /// <param name='workspaceId'>
        /// Workspace ID.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<ResourcesAgentSummary>> GetWorkspaceAgentsUsingGETWithHttpMessagesAsync(System.Guid workspaceId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// createWorkspaceAgent
        /// </summary>
        /// <remarks>
        /// Create a new agent in the given workspace.
        /// </remarks>
        /// <param name='createModel'>
        /// Agent create model including name and agent_type.
        /// </param>
        /// <param name='workspaceId'>
        /// Workspace ID.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<CreatedAgent>> CreateWorkspaceAgentUsingPOSTWithHttpMessagesAsync(AgentCreate createModel, System.Guid workspaceId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// getWorkspaceAgent
        /// </summary>
        /// <remarks>
        /// Get a single AgentSummaryResource.
        /// </remarks>
        /// <param name='agentId'>
        /// Agent ID.
        /// </param>
        /// <param name='workspaceId'>
        /// Workspace ID.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<AgentSummary>> GetWorkspaceAgentUsingGETWithHttpMessagesAsync(System.Guid agentId, System.Guid workspaceId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Delete Workspace Agent
        /// </summary>
        /// <remarks>
        /// Delete an agent in a given workspace, with the provided workspace
        /// identifier and agent identifier.
        /// </remarks>
        /// <param name='agentId'>
        /// Agent ID.
        /// </param>
        /// <param name='workspaceId'>
        /// Workspace ID.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> DeleteAgentInWorkspaceUsingDELETEWithHttpMessagesAsync(System.Guid agentId, System.Guid workspaceId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// renewWorkspaceAgentToken
        /// </summary>
        /// <remarks>
        /// Create a new agent token for the given agent ID. This request
        /// invalidates the existing tokens for this agent.
        /// </remarks>
        /// <param name='agentId'>
        /// Agent ID.
        /// </param>
        /// <param name='workspaceId'>
        /// Workspace ID.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<AgentToken>> RenewWorkspaceAgentTokenUsingPOSTWithHttpMessagesAsync(System.Guid agentId, System.Guid workspaceId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// getWorkspaceAgentTokens
        /// </summary>
        /// <remarks>
        /// Get a list of the tokens tied to a specific agent.
        /// </remarks>
        /// <param name='agentId'>
        /// Agent ID.
        /// </param>
        /// <param name='workspaceId'>
        /// Workspace ID.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<ResourcesAgentTokenWithoutAccessToken>> GetWorkspaceAgentTokensUsingGETWithHttpMessagesAsync(System.Guid agentId, System.Guid workspaceId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// getWorkspaceAgentToken
        /// </summary>
        /// <remarks>
        /// Get a single agent token.
        /// </remarks>
        /// <param name='agentId'>
        /// Agent ID.
        /// </param>
        /// <param name='tokenId'>
        /// Token ID.
        /// </param>
        /// <param name='workspaceId'>
        /// Workspace ID.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<AgentTokenWithoutAccessToken>> GetWorkspaceAgentTokenUsingGETWithHttpMessagesAsync(System.Guid agentId, System.Guid tokenId, System.Guid workspaceId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// revokeWorkspaceAgentToken
        /// </summary>
        /// <param name='agentId'>
        /// Agent ID.
        /// </param>
        /// <param name='tokenId'>
        /// Token ID.
        /// </param>
        /// <param name='workspaceId'>
        /// Workspace ID.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> RevokeWorkspaceAgentTokenUsingDELETEWithHttpMessagesAsync(System.Guid agentId, System.Guid tokenId, System.Guid workspaceId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// getApplicationProjects
        /// </summary>
        /// <remarks>
        /// Get application projects.
        /// </remarks>
        /// <param name='appGuid'>
        /// Application GUID.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<LinkedProjects>> GetApplicationProjectsUsingGETWithHttpMessagesAsync(System.Guid appGuid, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// getSbomCyclonedx
        /// </summary>
        /// <param name='targetUuid'>
        /// target ID.
        /// </param>
        /// <param name='type'>
        /// Filter by scan type. Possible values include: 'application',
        /// 'agent'
        /// </param>
        /// <param name='vulnerability'>
        /// Include vulnerability infomation.
        /// </param>
        /// <param name='linked'>
        /// Include results from linked projects.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<Sbom>> GetSbomCyclonedxUsingGETWithHttpMessagesAsync(System.Guid targetUuid, string type, bool? vulnerability = true, bool? linked = false, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// getSbomSpdx
        /// </summary>
        /// <param name='targetUuid'>
        /// target ID.
        /// </param>
        /// <param name='type'>
        /// Filter by scan type. Possible values include: 'application',
        /// 'agent'
        /// </param>
        /// <param name='vulnerability'>
        /// Include vulnerability information.
        /// </param>
        /// <param name='dependency'>
        /// Include dependecy information.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<SbomSpdx>> GetSbomSpdxUsingGETWithHttpMessagesAsync(System.Guid targetUuid, string type, bool? vulnerability = true, bool? dependency = true, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

    }
}
