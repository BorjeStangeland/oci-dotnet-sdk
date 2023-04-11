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


namespace Oci.IdentitydomainsService.Models
{
    /// <summary>
    /// Settings related to Duo Security
    /// <br/>
    /// **Added In:** 19.2.1
    /// <br/>
    /// **SCIM++ Properties:**
    ///  - idcsSearchable: false
    ///  - multiValued: false
    ///  - mutability: readWrite
    ///  - required: false
    ///  - returned: default
    ///  - type: complex
    ///  - uniqueness: none
    /// </summary>
    public class AuthenticationFactorSettingsDuoSecuritySettings 
    {
        
        /// <value>
        /// Integration key from Duo Security authenticator
        /// <br/>
        /// **Added In:** 19.2.1
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: true
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IntegrationKey is required.")]
        [JsonProperty(PropertyName = "integrationKey")]
        public string IntegrationKey { get; set; }
        
        /// <value>
        /// Secret key from Duo Security authenticator
        /// <br/>
        /// **Added In:** 19.2.1
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: true
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SecretKey is required.")]
        [JsonProperty(PropertyName = "secretKey")]
        public string SecretKey { get; set; }
        
        /// <value>
        /// Attestation key to attest the request and response between Duo Security
        /// <br/>
        /// **Added In:** 19.2.1
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: never
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "attestationKey")]
        public string AttestationKey { get; set; }
        
        /// <value>
        /// Hostname to access the Duo security account
        /// <br/>
        /// **Added In:** 19.2.1
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: true
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ApiHostname is required.")]
        [JsonProperty(PropertyName = "apiHostname")]
        public string ApiHostname { get; set; }
                ///
        /// <value>
        /// User attribute mapping value
        /// <br/>
        /// **Added In:** 19.2.1
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: true
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        ///
        public enum UserMappingAttributeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "primaryEmail")]
            PrimaryEmail,
            [EnumMember(Value = "userName")]
            UserName,
            [EnumMember(Value = "givenName")]
            GivenName
        };

        /// <value>
        /// User attribute mapping value
        /// <br/>
        /// **Added In:** 19.2.1
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: true
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "UserMappingAttribute is required.")]
        [JsonProperty(PropertyName = "userMappingAttribute")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<UserMappingAttributeEnum> UserMappingAttribute { get; set; }
        
    }
}