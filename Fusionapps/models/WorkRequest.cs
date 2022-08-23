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


namespace Oci.FusionappsService.Models
{
    /// <summary>
    /// A description of workrequest status
    /// </summary>
    public class WorkRequest 
    {
                ///
        /// <value>
        /// Possible operation types.
        /// </value>
        ///
        public enum OperationTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "CREATE_FUSION_ENVIRONMENT")]
            CreateFusionEnvironment,
            [EnumMember(Value = "UPDATE_FUSION_ENVIRONMENT")]
            UpdateFusionEnvironment,
            [EnumMember(Value = "RESET_FUSION_ENVIRONMENT_ADMIN_PASSWORD")]
            ResetFusionEnvironmentAdminPassword,
            [EnumMember(Value = "SCALE_FUSION_ENVIRONMENT")]
            ScaleFusionEnvironment,
            [EnumMember(Value = "ARCHIVE_FUSION_ENVIRONMENT")]
            ArchiveFusionEnvironment,
            [EnumMember(Value = "RESTORE_FUSION_ENVIRONMENT")]
            RestoreFusionEnvironment,
            [EnumMember(Value = "CREATE_SERVICE_INSTANCE")]
            CreateServiceInstance,
            [EnumMember(Value = "UPDATE_SERVICE_INSTANCE")]
            UpdateServiceInstance,
            [EnumMember(Value = "DETACH_SERVICE_INSTANCE")]
            DetachServiceInstance,
            [EnumMember(Value = "ADD_USER")]
            AddUser,
            [EnumMember(Value = "REMOVE_USER")]
            RemoveUser,
            [EnumMember(Value = "DELETE_FUSION_ENVIRONMENT")]
            DeleteFusionEnvironment,
            [EnumMember(Value = "CHANGE_FUSION_ENVIRONMENT_COMPARTMENT")]
            ChangeFusionEnvironmentCompartment,
            [EnumMember(Value = "UPGRADE_FUSION_ENVIRONMENT")]
            UpgradeFusionEnvironment,
            [EnumMember(Value = "CREATE_FUSION_ENVIRONMENT_FAMILY")]
            CreateFusionEnvironmentFamily,
            [EnumMember(Value = "DELETE_FUSION_ENVIRONMENT_FAMILY")]
            DeleteFusionEnvironmentFamily,
            [EnumMember(Value = "UPDATE_FUSION_ENVIRONMENT_FAMILY")]
            UpdateFusionEnvironmentFamily,
            [EnumMember(Value = "CHANGE_FUSION_ENVIRONMENT_FAMILY_COMPARTMENT")]
            ChangeFusionEnvironmentFamilyCompartment,
            [EnumMember(Value = "REFRESH_FUSION_ENVIRONMENT")]
            RefreshFusionEnvironment,
            [EnumMember(Value = "EXECUTE_COLD_PATCH")]
            ExecuteColdPatch
        };

        /// <value>
        /// Possible operation types.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OperationType is required.")]
        [JsonProperty(PropertyName = "operationType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<OperationTypeEnum> OperationType { get; set; }
                ///
        /// <value>
        /// Possible operation status.
        /// </value>
        ///
        public enum StatusEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "ACCEPTED")]
            Accepted,
            [EnumMember(Value = "IN_PROGRESS")]
            InProgress,
            [EnumMember(Value = "FAILED")]
            Failed,
            [EnumMember(Value = "SUCCEEDED")]
            Succeeded,
            [EnumMember(Value = "CANCELING")]
            Canceling,
            [EnumMember(Value = "CANCELED")]
            Canceled
        };

        /// <value>
        /// Possible operation status.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Status is required.")]
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<StatusEnum> Status { get; set; }
        
        /// <value>
        /// The id of the work request.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The ocid of the compartment that contains the work request. Work requests should be scoped to
        /// the same compartment as the resource the work request affects. If the work request affects multiple resources,
        /// and those resources are not in the same compartment, it is up to the service team to pick the primary
        /// resource whose compartment should be used
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The resources affected by this work request.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Resources is required.")]
        [JsonProperty(PropertyName = "resources")]
        public System.Collections.Generic.List<WorkRequestResource> Resources { get; set; }
        
        /// <value>
        /// Percentage of the request completed.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PercentComplete is required.")]
        [JsonProperty(PropertyName = "percentComplete")]
        public System.Nullable<float> PercentComplete { get; set; }
        
        /// <value>
        /// The date and time the request was created, as described in
        /// [RFC 3339](https://tools.ietf.org/rfc/rfc3339), section 14.29.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeAccepted is required.")]
        [JsonProperty(PropertyName = "timeAccepted")]
        public System.Nullable<System.DateTime> TimeAccepted { get; set; }
        
        /// <value>
        /// The date and time the request was started, as described in [RFC 3339](https://tools.ietf.org/rfc/rfc3339),
        /// section 14.29.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeStarted")]
        public System.Nullable<System.DateTime> TimeStarted { get; set; }
        
        /// <value>
        /// The date and time the object was finished, as described in [RFC 3339](https://tools.ietf.org/rfc/rfc3339).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeFinished")]
        public System.Nullable<System.DateTime> TimeFinished { get; set; }
        
    }
}