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
    /// kmsKeyInfo
    /// </summary>
    public class KmsKeyInfo 
    {
        
        /// <value>
        /// current BYOK keyId facp is using
        /// </value>
        [JsonProperty(PropertyName = "activeKeyId")]
        public string ActiveKeyId { get; set; }
        
        /// <value>
        /// current key version facp is using
        /// </value>
        [JsonProperty(PropertyName = "activeKeyVersion")]
        public string ActiveKeyVersion { get; set; }
        
        /// <value>
        /// scheduled keyId to be updated
        /// </value>
        [JsonProperty(PropertyName = "scheduledKeyId")]
        public string ScheduledKeyId { get; set; }
        
        /// <value>
        /// scheduled key version to be updated.
        /// </value>
        [JsonProperty(PropertyName = "scheduledKeyVersion")]
        public string ScheduledKeyVersion { get; set; }
        
        /// <value>
        /// current key lifeCycleState
        /// </value>
        [JsonProperty(PropertyName = "currentKeyLifecycleState")]
        public string CurrentKeyLifecycleState { get; set; }
        
        /// <value>
        /// scheduled key lifeCycle state to be updated.
        /// </value>
        [JsonProperty(PropertyName = "scheduledLifecycleState")]
        public string ScheduledLifecycleState { get; set; }
                ///
        /// <value>
        /// the scheduled key status
        /// </value>
        ///
        public enum ScheduledKeyStatusEnum {
            [EnumMember(Value = "SCHEDULING")]
            Scheduling,
            [EnumMember(Value = "UPDATING")]
            Updating,
            [EnumMember(Value = "FAILED")]
            Failed,
            [EnumMember(Value = "NONE")]
            None
        };

        /// <value>
        /// the scheduled key status
        /// </value>
        [JsonProperty(PropertyName = "scheduledKeyStatus")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ScheduledKeyStatusEnum> ScheduledKeyStatus { get; set; }
        
    }
}