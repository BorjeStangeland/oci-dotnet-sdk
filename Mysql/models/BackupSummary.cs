/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.MysqlService.Models
{
    /// <summary>
    /// Details of Backups such as OCID, description, backupType, and so on.
    /// <br/>
    /// To use any of the API operations, you must be authorized in an IAM
    /// policy. If you're not authorized, talk to an administrator. If you're an
    /// administrator who needs to write policies to give users access, see
    /// [Getting Started with Policies](https://docs.cloud.oracle.com/Content/Identity/Concepts/policygetstarted.htm).
    /// 
    /// </summary>
    public class BackupSummary 
    {
        
        /// <value>
        /// OCID of the backup.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// A user-supplied display name for the backup.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// A user-supplied description of the backup.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The time the backup was created.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The state of the backup.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<Backup.LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// The type of backup.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "BackupType is required.")]
        [JsonProperty(PropertyName = "backupType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<Backup.BackupTypeEnum> BackupType { get; set; }
        
        /// <value>
        /// If the backup was created automatically, or by a manual request.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CreationType is required.")]
        [JsonProperty(PropertyName = "creationType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<Backup.CreationTypeEnum> CreationType { get; set; }
        
        /// <value>
        /// The OCID of the DB System the Backup is associated with.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DbSystemId is required.")]
        [JsonProperty(PropertyName = "dbSystemId")]
        public string DbSystemId { get; set; }
        
        /// <value>
        /// Size of the data volume in GiBs.
        /// </value>
        [JsonProperty(PropertyName = "dataStorageSizeInGBs")]
        public System.Nullable<int> DataStorageSizeInGBs { get; set; }
        
        /// <value>
        /// The size of the backup in GiBs.
        /// </value>
        [JsonProperty(PropertyName = "backupSizeInGBs")]
        public System.Nullable<int> BackupSizeInGBs { get; set; }
        
        /// <value>
        /// Number of days to retain this backup.
        /// </value>
        [JsonProperty(PropertyName = "retentionInDays")]
        public System.Nullable<int> RetentionInDays { get; set; }
        
        /// <value>
        /// The version of the DB System used for backup.
        /// </value>
        [JsonProperty(PropertyName = "mysqlVersion")]
        public string MysqlVersion { get; set; }
        
        /// <value>
        /// The shape of the DB System instance used for backup.
        /// </value>
        [JsonProperty(PropertyName = "shapeName")]
        public string ShapeName { get; set; }
        
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
        
    }
}
