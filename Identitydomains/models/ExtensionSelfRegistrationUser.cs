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
    /// This extension defines attributes used to manage self registration profile linked to the user.
    /// </summary>
    public class ExtensionSelfRegistrationUser 
    {
        
        /// <value>
        /// A boolean value that indicates whether the consent is granted.
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsSearchable: true
        ///  - multiValued: false
        ///  - mutability: immutable
        ///  - required: false
        ///  - returned: default
        ///  - type: boolean
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "consentGranted")]
        public System.Nullable<bool> ConsentGranted { get; set; }
        
        /// <value>
        /// User token used for auto-login.
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readOnly
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "userToken")]
        public string UserToken { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SelfRegistrationProfile is required.")]
        [JsonProperty(PropertyName = "selfRegistrationProfile")]
        public UserExtSelfRegistrationProfile SelfRegistrationProfile { get; set; }
        
    }
}