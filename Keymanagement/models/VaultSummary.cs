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


namespace Oci.KeymanagementService.Models
{
    
    public class VaultSummary 
    {
        
        /// <value>
        /// The OCID of the compartment that contains a particular vault.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }

        /// <value>
        /// The service endpoint to perform cryptographic operations against. Cryptographic operations include
        /// [Encrypt](https://docs.cloud.oracle.com/api/#/en/key/release/EncryptedData/Encrypt), [Decrypt](https://docs.cloud.oracle.com/api/#/en/key/release/DecryptedData/Decrypt),
        /// and [GenerateDataEncryptionKey](https://docs.cloud.oracle.com/api/#/en/key/release/GeneratedKey/GenerateDataEncryptionKey) operations.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CryptoEndpoint is required.")]
        [JsonProperty(PropertyName = "cryptoEndpoint")]
        public string CryptoEndpoint { get; set; }

        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }

        /// <value>
        /// A user-friendly name for a vault. It does not have to be unique, and it is changeable.
        /// Avoid entering confidential information.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }

        /// <value>
        /// The OCID of a vault.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        ///
        /// <value>
        /// A vault's current lifecycle state.
        /// <br/>
        /// Example: ACTIVE
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
            [EnumMember(Value = "PENDING_DELETION")]
            PendingDeletion,
            [EnumMember(Value = "SCHEDULING_DELETION")]
            SchedulingDeletion,
            [EnumMember(Value = "CANCELLING_DELETION")]
            CancellingDeletion,
            [EnumMember(Value = "UPDATING")]
            Updating,
            [EnumMember(Value = "BACKUP_IN_PROGRESS")]
            BackupInProgress,
            [EnumMember(Value = "RESTORING")]
            Restoring
        };

        /// <value>
        /// A vault's current lifecycle state.
        /// <br/>
        /// Example: ACTIVE
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }

        /// <value>
        /// The service endpoint to perform management operations against. Management operations include \"Create,\" \"Update,\" \"List,\" \"Get,\" and \"Delete\" operations.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ManagementEndpoint is required.")]
        [JsonProperty(PropertyName = "managementEndpoint")]
        public string ManagementEndpoint { get; set; }

        /// <value>
        /// The date and time a vault was created, expressed in [RFC 3339](https://tools.ietf.org/html/rfc3339) timestamp format.
        /// <br/>
        /// Example: 2018-04-03T21:10:29.600Z
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        ///
        /// <value>
        /// The type of vault. Each type of vault stores keys with different
        /// degrees of isolation and has different options and pricing.
        /// 
        /// </value>
        ///
        public enum VaultTypeEnum {
            [EnumMember(Value = "VIRTUAL_PRIVATE")]
            VirtualPrivate,
            [EnumMember(Value = "DEFAULT")]
            Default
        };

        /// <value>
        /// The type of vault. Each type of vault stores keys with different
        /// degrees of isolation and has different options and pricing.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "VaultType is required.")]
        [JsonProperty(PropertyName = "vaultType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<VaultTypeEnum> VaultType { get; set; }
    }
}