/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.DatabasemigrationService.Models
{
    /// <summary>
    /// Migration resource
    /// 
    /// </summary>
    public class Migration 
    {
        
        /// <value>
        /// The OCID of the resource
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// Migration Display Name
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// OCID of the compartment
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Migration type.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Type is required.")]
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<MigrationTypes> Type { get; set; }
        
        /// <value>
        /// Name of a migration phase. The Job will wait after executing this
        /// phase until the Resume Job endpoint is called.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "waitAfter")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<OdmsJobPhases> WaitAfter { get; set; }
        
        /// <value>
        /// The OCID of the registered On-Prem ODMS Agent. Required for Offline Migrations.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "agentId")]
        public string AgentId { get; set; }
        
        /// <value>
        /// OCID of the Secret in the OCI vault containing the Migration credentials. Used to store Golden Gate admin user credentials.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "credentialsSecretId")]
        public string CredentialsSecretId { get; set; }
        
        /// <value>
        /// The OCID of the Source Database Connection.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SourceDatabaseConnectionId is required.")]
        [JsonProperty(PropertyName = "sourceDatabaseConnectionId")]
        public string SourceDatabaseConnectionId { get; set; }
        
        /// <value>
        /// The OCID of the Source Container Database Connection.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "sourceContainerDatabaseConnectionId")]
        public string SourceContainerDatabaseConnectionId { get; set; }
        
        /// <value>
        /// The OCID of the Target Database Connection.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TargetDatabaseConnectionId is required.")]
        [JsonProperty(PropertyName = "targetDatabaseConnectionId")]
        public string TargetDatabaseConnectionId { get; set; }
        
        /// <value>
        /// OCID of the current ODMS Job in execution for the Migration, if any.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "executingJobId")]
        public string ExecutingJobId { get; set; }
        
        [JsonProperty(PropertyName = "dataTransferMediumDetails")]
        public DataTransferMediumDetails DataTransferMediumDetails { get; set; }
        
        [JsonProperty(PropertyName = "datapumpSettings")]
        public DataPumpSettings DatapumpSettings { get; set; }
        
        /// <value>
        /// Database objects to exclude from migration.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "excludeObjects")]
        public System.Collections.Generic.List<DatabaseObject> ExcludeObjects { get; set; }
        
        [JsonProperty(PropertyName = "goldenGateDetails")]
        public GoldenGateDetails GoldenGateDetails { get; set; }
        
        [JsonProperty(PropertyName = "vaultDetails")]
        public VaultDetails VaultDetails { get; set; }
        
        /// <value>
        /// The time the Migration was created. An RFC3339 formatted datetime string.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The time of the last Migration details update. An RFC3339 formatted datetime string.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// The time of last Migration. An RFC3339 formatted datetime string.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeLastMigration")]
        public System.Nullable<System.DateTime> TimeLastMigration { get; set; }
        
        /// <value>
        /// The current state of the Migration Resource.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LifecycleStates> LifecycleState { get; set; }
        
        /// <value>
        /// Additional status related to the execution and current state of the Migration.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<MigrationStatus> LifecycleDetails { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// Usage of system tag keys. These predefined keys are scoped to namespaces.
        /// Example: {&quot;orcl-cloud&quot;: {&quot;free-tier-retained&quot;: &quot;true&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "systemTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> SystemTags { get; set; }
        
    }
}