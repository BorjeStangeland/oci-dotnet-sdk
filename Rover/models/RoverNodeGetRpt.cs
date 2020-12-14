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


namespace Oci.RoverService.Models
{
    /// <summary>
    /// The resource principal token response.
    /// </summary>
    public class RoverNodeGetRpt 
    {
        
        /// <value>
        /// The resource principal token blob that contains claims about the resource.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResourcePrincipalToken is required.")]
        [JsonProperty(PropertyName = "resourcePrincipalToken")]
        public string ResourcePrincipalToken { get; set; }
        
        /// <value>
        /// The service principal session token
        /// </value>
        [JsonProperty(PropertyName = "servicePrincipalSessionToken")]
        public string ServicePrincipalSessionToken { get; set; }
        
    }
}
