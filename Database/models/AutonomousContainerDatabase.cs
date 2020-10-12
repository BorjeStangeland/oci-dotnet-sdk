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
    
    public class AutonomousContainerDatabase 
    {
        
        /// <value>
        /// The OCID of the Autonomous Container Database.
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
        /// The user-provided name for the Autonomous Container Database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <value>
        /// The `DB_UNIQUE_NAME` of the Oracle Database being backed up.
        /// </value>
        [JsonProperty(PropertyName = "dbUniqueName")]
        public string DbUniqueName { get; set; }
        ///
        /// <value>
        /// The service level agreement type of the container database. The default is STANDARD.
        /// </value>
        ///
        public enum ServiceLevelAgreementTypeEnum {
            [EnumMember(Value = "STANDARD")]
            Standard,
            [EnumMember(Value = "MISSION_CRITICAL")]
            MissionCritical,
            [EnumMember(Value = "AUTONOMOUS_DATAGUARD")]
            AutonomousDataguard
        };

        /// <value>
        /// The service level agreement type of the container database. The default is STANDARD.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ServiceLevelAgreementType is required.")]
        [JsonProperty(PropertyName = "serviceLevelAgreementType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ServiceLevelAgreementTypeEnum> ServiceLevelAgreementType { get; set; }

        /// <value>
        /// The OCID of the Autonomous Exadata Infrastructure.
        /// </value>
        [JsonProperty(PropertyName = "autonomousExadataInfrastructureId")]
        public string AutonomousExadataInfrastructureId { get; set; }

        /// <value>
        /// The OCID of the Autonomous VM Cluster.
        /// </value>
        [JsonProperty(PropertyName = "autonomousVmClusterId")]
        public string AutonomousVmClusterId { get; set; }
        ///
        /// <value>
        /// The infrastructure type this resource belongs to.
        /// </value>
        ///
        public enum InfrastructureTypeEnum {
            [EnumMember(Value = "CLOUD")]
            Cloud,
            [EnumMember(Value = "CLOUD_AT_CUSTOMER")]
            CloudAtCustomer
        };

        /// <value>
        /// The infrastructure type this resource belongs to.
        /// </value>
        [JsonProperty(PropertyName = "infrastructureType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<InfrastructureTypeEnum> InfrastructureType { get; set; }

        /// <value>
        /// The OCID of the key container that is used as the master encryption key in database transparent data encryption (TDE) operations.
        /// </value>
        [JsonProperty(PropertyName = "kmsKeyId")]
        public string KmsKeyId { get; set; }

        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Oracle Cloud Infrastructure [vault](https://docs.cloud.oracle.com/Content/KeyManagement/Concepts/keyoverview.htm#concepts).
        /// </value>
        [JsonProperty(PropertyName = "vaultId")]
        public string VaultId { get; set; }
        ///
        /// <value>
        /// The current state of the Autonomous Container Database.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            [EnumMember(Value = "PROVISIONING")]
            Provisioning,
            [EnumMember(Value = "AVAILABLE")]
            Available,
            [EnumMember(Value = "UPDATING")]
            Updating,
            [EnumMember(Value = "TERMINATING")]
            Terminating,
            [EnumMember(Value = "TERMINATED")]
            Terminated,
            [EnumMember(Value = "FAILED")]
            Failed,
            [EnumMember(Value = "BACKUP_IN_PROGRESS")]
            BackupInProgress,
            [EnumMember(Value = "RESTORING")]
            Restoring,
            [EnumMember(Value = "RESTORE_FAILED")]
            RestoreFailed,
            [EnumMember(Value = "RESTARTING")]
            Restarting,
            [EnumMember(Value = "MAINTENANCE_IN_PROGRESS")]
            MaintenanceInProgress,
            [EnumMember(Value = "ROLE_CHANGE_IN_PROGRESS")]
            RoleChangeInProgress
        };

        /// <value>
        /// The current state of the Autonomous Container Database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }

        /// <value>
        /// Additional information about the current lifecycleState.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }

        /// <value>
        /// The date and time the Autonomous Container Database was created.
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        ///
        /// <value>
        /// Database patch model preference.
        /// </value>
        ///
        public enum PatchModelEnum {
            [EnumMember(Value = "RELEASE_UPDATES")]
            ReleaseUpdates,
            [EnumMember(Value = "RELEASE_UPDATE_REVISIONS")]
            ReleaseUpdateRevisions
        };

        /// <value>
        /// Database patch model preference.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PatchModel is required.")]
        [JsonProperty(PropertyName = "patchModel")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<PatchModelEnum> PatchModel { get; set; }

        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the last patch applied on the system.
        /// </value>
        [JsonProperty(PropertyName = "patchId")]
        public string PatchId { get; set; }

        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the last maintenance run.
        /// </value>
        [JsonProperty(PropertyName = "lastMaintenanceRunId")]
        public string LastMaintenanceRunId { get; set; }

        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the next maintenance run.
        /// </value>
        [JsonProperty(PropertyName = "nextMaintenanceRunId")]
        public string NextMaintenanceRunId { get; set; }

        [JsonProperty(PropertyName = "maintenanceWindow")]
        public MaintenanceWindow MaintenanceWindow { get; set; }

        /// <value>
        /// The scheduling detail for the quarterly maintenance window of standby Autonomous Container Database.
        /// This value represents the number of days before the primary database maintenance schedule.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "standbyMaintenanceBufferInDays")]
        public System.Nullable<int> StandbyMaintenanceBufferInDays { get; set; }

        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }

        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        ///
        /// <value>
        /// The role of the Autonomous Data Guard-enabled Autonomous Container Database.
        /// </value>
        ///
        public enum RoleEnum {
            [EnumMember(Value = "PRIMARY")]
            Primary,
            [EnumMember(Value = "STANDBY")]
            Standby,
            [EnumMember(Value = "DISABLED_STANDBY")]
            DisabledStandby
        };

        /// <value>
        /// The role of the Autonomous Data Guard-enabled Autonomous Container Database.
        /// </value>
        [JsonProperty(PropertyName = "role")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<RoleEnum> Role { get; set; }

        /// <value>
        /// The availability domain of the Autonomous Container Database.
        /// </value>
        [JsonProperty(PropertyName = "availabilityDomain")]
        public string AvailabilityDomain { get; set; }

        /// <value>
        /// Oracle Database version of the Autonomous Container Database.
        /// </value>
        [JsonProperty(PropertyName = "dbVersion")]
        public string DbVersion { get; set; }

        [JsonProperty(PropertyName = "backupConfig")]
        public AutonomousContainerDatabaseBackupConfig BackupConfig { get; set; }
    }
}
