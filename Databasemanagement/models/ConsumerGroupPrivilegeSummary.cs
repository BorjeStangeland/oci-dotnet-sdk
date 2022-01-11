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


namespace Oci.DatabasemanagementService.Models
{
    /// <summary>
    /// Summary of consumerGroupPrivileges.
    /// </summary>
    public class ConsumerGroupPrivilegeSummary 
    {
        
        /// <value>
        /// The name of granted consumer group.
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
                ///
        /// <value>
        /// Indicates whether the grant was with the GRANT option (YES) or not (NO).
        /// </value>
        ///
        public enum GrantOptionEnum {
            [EnumMember(Value = "YES")]
            Yes,
            [EnumMember(Value = "NO")]
            No
        };

        /// <value>
        /// Indicates whether the grant was with the GRANT option (YES) or not (NO).
        /// </value>
        [JsonProperty(PropertyName = "grantOption")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<GrantOptionEnum> GrantOption { get; set; }
                ///
        /// <value>
        /// Indicates whether the consumer group is designated as the default for this user or role (YES) or not (NO)
        /// </value>
        ///
        public enum InitialGroupEnum {
            [EnumMember(Value = "YES")]
            Yes,
            [EnumMember(Value = "NO")]
            No
        };

        /// <value>
        /// Indicates whether the consumer group is designated as the default for this user or role (YES) or not (NO)
        /// </value>
        [JsonProperty(PropertyName = "initialGroup")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<InitialGroupEnum> InitialGroup { get; set; }
        
    }
}