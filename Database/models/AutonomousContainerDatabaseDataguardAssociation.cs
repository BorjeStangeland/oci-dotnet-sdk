/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
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
    /// The properties that define Autonomous Data Guard association between two different Autonomous Container Databases.
    /// 
    /// </summary>
    public class AutonomousContainerDatabaseDataguardAssociation 
    {
        
        /// <value>
        /// The OCID of the Autonomous Data Guard created for a given Autonomous Container Database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Autonomous Container Database that has a relationship with the peer Autonomous Container Database.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AutonomousContainerDatabaseId is required.")]
        [JsonProperty(PropertyName = "autonomousContainerDatabaseId")]
        public string AutonomousContainerDatabaseId { get; set; }
                ///
        /// <value>
        /// The Data Guard role of the Autonomous Container Database or Autonomous Database, if Autonomous Data Guard is enabled.
        /// 
        /// </value>
        ///
        public enum RoleEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "PRIMARY")]
            Primary,
            [EnumMember(Value = "STANDBY")]
            Standby,
            [EnumMember(Value = "DISABLED_STANDBY")]
            DisabledStandby,
            [EnumMember(Value = "SNAPSHOT_STANDBY")]
            SnapshotStandby
        };

        /// <value>
        /// The Data Guard role of the Autonomous Container Database or Autonomous Database, if Autonomous Data Guard is enabled.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Role is required.")]
        [JsonProperty(PropertyName = "role")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<RoleEnum> Role { get; set; }
                ///
        /// <value>
        /// The current state of Autonomous Data Guard.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "PROVISIONING")]
            Provisioning,
            [EnumMember(Value = "AVAILABLE")]
            Available,
            [EnumMember(Value = "ROLE_CHANGE_IN_PROGRESS")]
            RoleChangeInProgress,
            [EnumMember(Value = "TERMINATING")]
            Terminating,
            [EnumMember(Value = "TERMINATED")]
            Terminated,
            [EnumMember(Value = "FAILED")]
            Failed,
            [EnumMember(Value = "UNAVAILABLE")]
            Unavailable,
            [EnumMember(Value = "UPDATING")]
            Updating
        };

        /// <value>
        /// The current state of Autonomous Data Guard.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// Additional information about the current lifecycleState, if available.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
        
        /// <value>
        /// The OCID of the peer Autonomous Container Database-Autonomous Data Guard association.
        /// </value>
        [JsonProperty(PropertyName = "peerAutonomousContainerDatabaseDataguardAssociationId")]
        public string PeerAutonomousContainerDatabaseDataguardAssociationId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the peer Autonomous Container Database.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "peerAutonomousContainerDatabaseId")]
        public string PeerAutonomousContainerDatabaseId { get; set; }
                ///
        /// <value>
        /// The Data Guard role of the Autonomous Container Database or Autonomous Database, if Autonomous Data Guard is enabled.
        /// 
        /// </value>
        ///
        public enum PeerRoleEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "PRIMARY")]
            Primary,
            [EnumMember(Value = "STANDBY")]
            Standby,
            [EnumMember(Value = "DISABLED_STANDBY")]
            DisabledStandby,
            [EnumMember(Value = "SNAPSHOT_STANDBY")]
            SnapshotStandby
        };

        /// <value>
        /// The Data Guard role of the Autonomous Container Database or Autonomous Database, if Autonomous Data Guard is enabled.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PeerRole is required.")]
        [JsonProperty(PropertyName = "peerRole")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<PeerRoleEnum> PeerRole { get; set; }
                ///
        /// <value>
        /// The current state of Autonomous Data Guard.
        /// </value>
        ///
        public enum PeerLifecycleStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "PROVISIONING")]
            Provisioning,
            [EnumMember(Value = "AVAILABLE")]
            Available,
            [EnumMember(Value = "ROLE_CHANGE_IN_PROGRESS")]
            RoleChangeInProgress,
            [EnumMember(Value = "TERMINATING")]
            Terminating,
            [EnumMember(Value = "TERMINATED")]
            Terminated,
            [EnumMember(Value = "FAILED")]
            Failed,
            [EnumMember(Value = "UNAVAILABLE")]
            Unavailable,
            [EnumMember(Value = "UPDATING")]
            Updating
        };

        /// <value>
        /// The current state of Autonomous Data Guard.
        /// </value>
        [JsonProperty(PropertyName = "peerLifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<PeerLifecycleStateEnum> PeerLifecycleState { get; set; }
                ///
        /// <value>
        /// The protection mode of this Autonomous Data Guard association. For more information, see
        /// [Oracle Data Guard Protection Modes](http://docs.oracle.com/database/122/SBYDB/oracle-data-guard-protection-modes.htm#SBYDB02000)
        /// in the Oracle Data Guard documentation.
        /// 
        /// </value>
        ///
        public enum ProtectionModeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "MAXIMUM_AVAILABILITY")]
            MaximumAvailability,
            [EnumMember(Value = "MAXIMUM_PERFORMANCE")]
            MaximumPerformance
        };

        /// <value>
        /// The protection mode of this Autonomous Data Guard association. For more information, see
        /// [Oracle Data Guard Protection Modes](http://docs.oracle.com/database/122/SBYDB/oracle-data-guard-protection-modes.htm#SBYDB02000)
        /// in the Oracle Data Guard documentation.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "protectionMode")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ProtectionModeEnum> ProtectionMode { get; set; }
        
        /// <value>
        /// The lag time for my preference based on data loss tolerance in seconds.
        /// </value>
        [JsonProperty(PropertyName = "fastStartFailOverLagLimitInSeconds")]
        public System.Nullable<int> FastStartFailOverLagLimitInSeconds { get; set; }
        
        /// <value>
        /// The lag time between updates to the primary Autonomous Container Database and application of the redo data on the standby Autonomous Container Database,
        /// as computed by the reporting database.
        /// <br/>
        /// Example: 9 seconds
        /// </value>
        [JsonProperty(PropertyName = "applyLag")]
        public string ApplyLag { get; set; }
        
        /// <value>
        /// The rate at which redo logs are synchronized between the associated Autonomous Container Databases.
        /// <br/>
        /// Example: 180 Mb per second
        /// </value>
        [JsonProperty(PropertyName = "applyRate")]
        public string ApplyRate { get; set; }
        
        /// <value>
        /// Indicates whether Automatic Failover is enabled for Autonomous Container Database Dataguard Association
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isAutomaticFailoverEnabled")]
        public System.Nullable<bool> IsAutomaticFailoverEnabled { get; set; }
        
        /// <value>
        /// The approximate number of seconds of redo data not yet available on the standby Autonomous Container Database,
        /// as computed by the reporting database.
        /// <br/>
        /// Example: 7 seconds
        /// </value>
        [JsonProperty(PropertyName = "transportLag")]
        public string TransportLag { get; set; }
        
        /// <value>
        /// The date and time of the last update to the apply lag, apply rate, and transport lag values.
        /// </value>
        [JsonProperty(PropertyName = "timeLastSynced")]
        public System.Nullable<System.DateTime> TimeLastSynced { get; set; }
        
        /// <value>
        /// The date and time the Autonomous DataGuard association was created.
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The date and time when the last role change action happened.
        /// </value>
        [JsonProperty(PropertyName = "timeLastRoleChanged")]
        public System.Nullable<System.DateTime> TimeLastRoleChanged { get; set; }
        
    }
}
