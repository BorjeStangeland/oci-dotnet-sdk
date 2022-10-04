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


namespace Oci.OpsiService.Models
{
    /// <summary>
    /// Summary of a MACS-managed cloud host insight resource.
    /// </summary>
    public class MacsManagedCloudHostInsightSummary : HostInsightSummary
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the Compute Instance
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ComputeId is required.")]
        [JsonProperty(PropertyName = "computeId")]
        public string ComputeId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the Management Agent
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ManagementAgentId is required.")]
        [JsonProperty(PropertyName = "managementAgentId")]
        public string ManagementAgentId { get; set; }
                ///
        /// <value>
        /// Platform type.
        /// Supported platformType(s) for MACS-managed external host insight: [LINUX].
        /// Supported platformType(s) for MACS-managed cloud host insight: [LINUX].
        /// Supported platformType(s) for EM-managed external host insight: [LINUX, SOLARIS, SUNOS, ZLINUX].
        /// 
        /// </value>
        ///
        public enum PlatformTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "LINUX")]
            Linux,
            [EnumMember(Value = "SOLARIS")]
            Solaris,
            [EnumMember(Value = "SUNOS")]
            Sunos,
            [EnumMember(Value = "ZLINUX")]
            Zlinux
        };

        /// <value>
        /// Platform type.
        /// Supported platformType(s) for MACS-managed external host insight: [LINUX].
        /// Supported platformType(s) for MACS-managed cloud host insight: [LINUX].
        /// Supported platformType(s) for EM-managed external host insight: [LINUX, SOLARIS, SUNOS, ZLINUX].
        /// 
        /// </value>
        [JsonProperty(PropertyName = "platformType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<PlatformTypeEnum> PlatformType { get; set; }
        
        [JsonProperty(PropertyName = "entitySource")]
        private readonly string entitySource = "MACS_MANAGED_CLOUD_HOST";
    }
}
