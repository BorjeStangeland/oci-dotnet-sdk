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


namespace Oci.DatabaseService.Models
{
    /// <summary>
    /// A database backup.
    /// To use any of the API operations, you must be authorized in an IAM policy. If you're not authorized, talk to an administrator. If you're an administrator who needs to write policies to give users access, see [Getting Started with Policies](https://docs.cloud.oracle.com/Content/Identity/Concepts/policygetstarted.htm).
    /// <br/>
    /// **Warning:** Oracle recommends that you avoid using any confidential information when you supply string values using the API.
    /// 
    /// </summary>
    public class BackupSummary 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the backup.
        /// </value>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the compartment.
        /// </value>
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the database.
        /// </value>
        [JsonProperty(PropertyName = "databaseId")]
        public string DatabaseId { get; set; }
        
        /// <value>
        /// The user-friendly name for the backup. The name does not have to be unique.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
                ///
        /// <value>
        /// The type of backup.
        /// </value>
        ///
        public enum TypeEnum {
            [EnumMember(Value = "INCREMENTAL")]
            Incremental,
            [EnumMember(Value = "FULL")]
            Full,
            [EnumMember(Value = "VIRTUAL_FULL")]
            VirtualFull
        };

        /// <value>
        /// The type of backup.
        /// </value>
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<TypeEnum> Type { get; set; }
        
        /// <value>
        /// The date and time the backup started.
        /// </value>
        [JsonProperty(PropertyName = "timeStarted")]
        public System.Nullable<System.DateTime> TimeStarted { get; set; }
        
        /// <value>
        /// The date and time the backup was completed.
        /// </value>
        [JsonProperty(PropertyName = "timeEnded")]
        public System.Nullable<System.DateTime> TimeEnded { get; set; }
        
        /// <value>
        /// Additional information about the current lifecycle state.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
        
        /// <value>
        /// The name of the availability domain where the database backup is stored.
        /// </value>
        [JsonProperty(PropertyName = "availabilityDomain")]
        public string AvailabilityDomain { get; set; }
                ///
        /// <value>
        /// The current state of the backup.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            [EnumMember(Value = "CREATING")]
            Creating,
            [EnumMember(Value = "ACTIVE")]
            Active,
            [EnumMember(Value = "DELETING")]
            Deleting,
            [EnumMember(Value = "DELETED")]
            Deleted,
            [EnumMember(Value = "FAILED")]
            Failed,
            [EnumMember(Value = "RESTORING")]
            Restoring
        };

        /// <value>
        /// The current state of the backup.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
                ///
        /// <value>
        /// The Oracle Database edition of the DB system from which the database backup was taken.
        /// 
        /// </value>
        ///
        public enum DatabaseEditionEnum {
            [EnumMember(Value = "STANDARD_EDITION")]
            StandardEdition,
            [EnumMember(Value = "ENTERPRISE_EDITION")]
            EnterpriseEdition,
            [EnumMember(Value = "ENTERPRISE_EDITION_HIGH_PERFORMANCE")]
            EnterpriseEditionHighPerformance,
            [EnumMember(Value = "ENTERPRISE_EDITION_EXTREME_PERFORMANCE")]
            EnterpriseEditionExtremePerformance
        };

        /// <value>
        /// The Oracle Database edition of the DB system from which the database backup was taken.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "databaseEdition")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<DatabaseEditionEnum> DatabaseEdition { get; set; }
        
        /// <value>
        /// The size of the database in gigabytes at the time the backup was taken.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "databaseSizeInGBs")]
        public System.Double DatabaseSizeInGBs { get; set; }
        
        /// <value>
        /// Shape of the backup's source database.
        /// </value>
        [JsonProperty(PropertyName = "shape")]
        public string Shape { get; set; }
        
        /// <value>
        /// Version of the backup's source database
        /// </value>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }
        
        /// <value>
        /// The OCID of the key container that is used as the master encryption key in database transparent data encryption (TDE) operations.
        /// </value>
        [JsonProperty(PropertyName = "kmsKeyId")]
        public string KmsKeyId { get; set; }
        
    }
}
