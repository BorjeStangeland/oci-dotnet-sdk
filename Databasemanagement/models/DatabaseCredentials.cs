/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
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
    /// The database credentials used to perform management activity.
    /// </summary>
    public class DatabaseCredentials 
    {
        
        /// <value>
        /// The database user name used to perform management activity.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "userName")]
        public string UserName { get; set; }
        
        /// <value>
        /// The password for the database user name.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the secret containing the user password.
        /// </value>
        [JsonProperty(PropertyName = "secretId")]
        public string SecretId { get; set; }
                ///
        /// <value>
        /// The role of the database user. Indicates whether the database user is a normal user or sysdba.
        /// </value>
        ///
        public enum RoleEnum {
            [EnumMember(Value = "NORMAL")]
            Normal,
            [EnumMember(Value = "SYSDBA")]
            Sysdba
        };

        /// <value>
        /// The role of the database user. Indicates whether the database user is a normal user or sysdba.
        /// </value>
        [JsonProperty(PropertyName = "role")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<RoleEnum> Role { get; set; }
        
    }
}
