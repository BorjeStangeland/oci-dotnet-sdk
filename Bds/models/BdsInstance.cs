/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.BdsService.Models
{
    /// <summary>
    /// Description of the cluster.
    /// </summary>
    public class BdsInstance 
    {
        
        /// <value>
        /// The OCID of the Big Data Service resource.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The OCID of the compartment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The name of the cluster.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
                ///
        /// <value>
        /// The state of the cluster.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "CREATING")]
            Creating,
            [EnumMember(Value = "ACTIVE")]
            Active,
            [EnumMember(Value = "UPDATING")]
            Updating,
            [EnumMember(Value = "SUSPENDING")]
            Suspending,
            [EnumMember(Value = "SUSPENDED")]
            Suspended,
            [EnumMember(Value = "RESUMING")]
            Resuming,
            [EnumMember(Value = "DELETING")]
            Deleting,
            [EnumMember(Value = "DELETED")]
            Deleted,
            [EnumMember(Value = "FAILED")]
            Failed,
            [EnumMember(Value = "INACTIVE")]
            Inactive
        };

        /// <value>
        /// The state of the cluster.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
                ///
        /// <value>
        /// Version of the Hadoop distribution.
        /// </value>
        ///
        public enum ClusterVersionEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "CDH5")]
            Cdh5,
            [EnumMember(Value = "CDH6")]
            Cdh6,
            [EnumMember(Value = "ODH1")]
            Odh1,
            [EnumMember(Value = "ODH0_9")]
            Odh09,
            [EnumMember(Value = "ODH2_0")]
            Odh20
        };

        /// <value>
        /// Version of the Hadoop distribution.
        /// </value>
        [JsonProperty(PropertyName = "clusterVersion")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ClusterVersionEnum> ClusterVersion { get; set; }
        
        /// <value>
        /// Boolean flag specifying whether or not the cluster is highly available (HA)
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsHighAvailability is required.")]
        [JsonProperty(PropertyName = "isHighAvailability")]
        public System.Nullable<bool> IsHighAvailability { get; set; }
        
        /// <value>
        /// Boolean flag specifying whether or not the cluster should be set up as secure.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsSecure is required.")]
        [JsonProperty(PropertyName = "isSecure")]
        public System.Nullable<bool> IsSecure { get; set; }
        
        /// <value>
        /// Boolean flag specifying whether or not Cloud SQL should be configured.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsCloudSqlConfigured is required.")]
        [JsonProperty(PropertyName = "isCloudSqlConfigured")]
        public System.Nullable<bool> IsCloudSqlConfigured { get; set; }
        
        [JsonProperty(PropertyName = "networkConfig")]
        public NetworkConfig NetworkConfig { get; set; }
        
        [JsonProperty(PropertyName = "clusterDetails")]
        public ClusterDetails ClusterDetails { get; set; }
        
        /// <value>
        /// The list of nodes in the cluster.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Nodes is required.")]
        [JsonProperty(PropertyName = "nodes")]
        public System.Collections.Generic.List<Node> Nodes { get; set; }
        
        [JsonProperty(PropertyName = "cloudSqlDetails")]
        public CloudSqlDetails CloudSqlDetails { get; set; }
        
        /// <value>
        /// The user who created the cluster.
        /// </value>
        [JsonProperty(PropertyName = "createdBy")]
        public string CreatedBy { get; set; }
        
        /// <value>
        /// The time the cluster was created, shown as an RFC 3339 formatted datetime string.
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The time the cluster was updated, shown as an RFC 3339 formatted datetime string.
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// Number of nodes that forming the cluster
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "NumberOfNodes is required.")]
        [JsonProperty(PropertyName = "numberOfNodes")]
        public System.Nullable<int> NumberOfNodes { get; set; }
        
        /// <value>
        /// pre-authenticated URL of the bootstrap script in Object Store that can be downloaded and executed.
        /// </value>
        [JsonProperty(PropertyName = "bootstrapScriptUrl")]
        public string BootstrapScriptUrl { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type, or scope.
        /// Exists for cross-compatibility only. For example, `{\"bar-key\": \"value\"}`
        /// 
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// For example, `{\"foo-namespace\": {\"bar-key\": \"value\"}}`
        /// 
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// The OCID of the Key Management master encryption key.
        /// </value>
        [JsonProperty(PropertyName = "kmsKeyId")]
        public string KmsKeyId { get; set; }
                ///
        /// <value>
        /// Profile of the Big Data Service cluster.
        /// </value>
        ///
        public enum ClusterProfileEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "HADOOP_EXTENDED")]
            HadoopExtended,
            [EnumMember(Value = "HADOOP")]
            Hadoop,
            [EnumMember(Value = "HIVE")]
            Hive,
            [EnumMember(Value = "SPARK")]
            Spark,
            [EnumMember(Value = "HBASE")]
            Hbase,
            [EnumMember(Value = "TRINO")]
            Trino
        };

        /// <value>
        /// Profile of the Big Data Service cluster.
        /// </value>
        [JsonProperty(PropertyName = "clusterProfile")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ClusterProfileEnum> ClusterProfile { get; set; }
        
    }
}
