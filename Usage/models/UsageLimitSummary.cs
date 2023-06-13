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


namespace Oci.UsageService.Models
{
    /// <summary>
    /// Encapsulates a collection of Hard and Soft Limits for a resource within a subscription.
    /// </summary>
    public class UsageLimitSummary 
    {
        
        /// <value>
        /// Time when the usage limit was created
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// Entitlement ID of the usage limit
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "EntitlementId is required.")]
        [JsonProperty(PropertyName = "entitlementId")]
        public string EntitlementId { get; set; }
        
        /// <value>
        /// The usage limit ID
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// Time when the usage limit was modified
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeModified is required.")]
        [JsonProperty(PropertyName = "timeModified")]
        public System.Nullable<System.DateTime> TimeModified { get; set; }
        
        /// <value>
        /// The resource for which the limit is defined
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResourceName is required.")]
        [JsonProperty(PropertyName = "resourceName")]
        public string ResourceName { get; set; }
        
        /// <value>
        /// The service for which the limit is defined
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ServiceName is required.")]
        [JsonProperty(PropertyName = "serviceName")]
        public string ServiceName { get; set; }
        
        /// <value>
        /// The limit value
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Limit is required.")]
        [JsonProperty(PropertyName = "limit")]
        public string Limit { get; set; }
        
        /// <value>
        /// The user who created the limit
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CreatedBy is required.")]
        [JsonProperty(PropertyName = "createdBy")]
        public string CreatedBy { get; set; }
        
        /// <value>
        /// The user who modified the limit
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ModifiedBy is required.")]
        [JsonProperty(PropertyName = "modifiedBy")]
        public string ModifiedBy { get; set; }
                ///
        /// <value>
        /// The action when usage limit is hit
        /// </value>
        ///
        public enum ActionEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "QUOTA_BREACH")]
            QuotaBreach,
            [EnumMember(Value = "QUOTA_ALERT")]
            QuotaAlert
        };

        /// <value>
        /// The action when usage limit is hit
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Action is required.")]
        [JsonProperty(PropertyName = "action")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ActionEnum> Action { get; set; }
        
        /// <value>
        /// The alert level of the usage limit
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AlertLevel is required.")]
        [JsonProperty(PropertyName = "alertLevel")]
        public System.Nullable<decimal> AlertLevel { get; set; }
                ///
        /// <value>
        /// The limit type of the usage limit
        /// </value>
        ///
        public enum LimitTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "HARD")]
            Hard,
            [EnumMember(Value = "SOFT")]
            Soft
        };

        /// <value>
        /// The limit type of the usage limit
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LimitType is required.")]
        [JsonProperty(PropertyName = "limitType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LimitTypeEnum> LimitType { get; set; }
                ///
        /// <value>
        /// The value type of the usage limit
        /// </value>
        ///
        public enum ValueTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "ABSOLUTE")]
            Absolute,
            [EnumMember(Value = "PERCENTAGE")]
            Percentage
        };

        /// <value>
        /// The value type of the usage limit
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ValueType is required.")]
        [JsonProperty(PropertyName = "valueType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ValueTypeEnum> ValueType { get; set; }
                ///
        /// <value>
        /// The usage limit lifecycle state.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "ACTIVE")]
            Active
        };

        /// <value>
        /// The usage limit lifecycle state.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// The maximum hard limit set for the usage limit
        /// </value>
        [JsonProperty(PropertyName = "maxHardLimit")]
        public string MaxHardLimit { get; set; }
        
        /// <value>
        /// The SKU for which the usage limit is set
        /// </value>
        [JsonProperty(PropertyName = "skuPartId")]
        public string SkuPartId { get; set; }
        
    }
}