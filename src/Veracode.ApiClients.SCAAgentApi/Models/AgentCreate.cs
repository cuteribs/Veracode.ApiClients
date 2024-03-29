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
    /// AgentCreate
    /// </summary>
    public partial class AgentCreate
    {
        /// <summary>
        /// Initializes a new instance of the AgentCreate class.
        /// </summary>
        public AgentCreate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AgentCreate class.
        /// </summary>
        /// <param name="agentType">Possible values include: 'CLI', 'MAVEN',
        /// 'GRADLE', 'JENKINS', 'BAMBOO', 'CIRCLECI', 'CODESHIP', 'PIPELINES',
        /// 'TRAVIS', 'WINDOWSCI'</param>
        public AgentCreate(string agentType = default(string), string name = default(string))
        {
            AgentType = agentType;
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'CLI', 'MAVEN', 'GRADLE',
        /// 'JENKINS', 'BAMBOO', 'CIRCLECI', 'CODESHIP', 'PIPELINES', 'TRAVIS',
        /// 'WINDOWSCI'
        /// </summary>
        [JsonProperty(PropertyName = "agent_type")]
        public string AgentType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

    }
}
