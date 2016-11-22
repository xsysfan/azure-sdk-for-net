// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Sql.Fluent.Models
{
    using System.Linq;

    /// <summary>
    /// Represents an Azure SQL Database Service Objective.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class ServiceObjectiveInner : SqlSubResource
    {
        /// <summary>
        /// Initializes a new instance of the ServiceObjectiveInner class.
        /// </summary>
        public ServiceObjectiveInner() { }

        /// <summary>
        /// Initializes a new instance of the ServiceObjectiveInner class.
        /// </summary>
        /// <param name="name">Resource name</param>
        /// <param name="id">The resource ID.</param>
        /// <param name="serviceObjectiveName">The name for the service
        /// objective.</param>
        /// <param name="isDefault">Gets whether the service level objective
        /// is the default service objective.</param>
        /// <param name="isSystem">Gets whether the service level objective is
        /// a system service objective.</param>
        /// <param name="description">The description for the service level
        /// objective.</param>
        /// <param name="enabled">Gets whether the service level objective is
        /// enabled.</param>
        public ServiceObjectiveInner(string name = default(string), string id = default(string), string serviceObjectiveName = default(string), bool? isDefault = default(bool?), bool? isSystem = default(bool?), string description = default(string), bool? enabled = default(bool?))
            : base(name, id)
        {
            ServiceObjectiveName = serviceObjectiveName;
            IsDefault = isDefault;
            IsSystem = isSystem;
            Description = description;
            Enabled = enabled;
        }

        /// <summary>
        /// Gets the name for the service objective.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.serviceObjectiveName")]
        public string ServiceObjectiveName { get; private set; }

        /// <summary>
        /// Gets whether the service level objective is the default service
        /// objective.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.isDefault")]
        public bool? IsDefault { get; private set; }

        /// <summary>
        /// Gets whether the service level objective is a system service
        /// objective.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.isSystem")]
        public bool? IsSystem { get; private set; }

        /// <summary>
        /// Gets the description for the service level objective.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.description")]
        public string Description { get; private set; }

        /// <summary>
        /// Gets whether the service level objective is enabled.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.enabled")]
        public bool? Enabled { get; private set; }

    }
}