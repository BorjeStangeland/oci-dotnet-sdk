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


namespace Oci.VnmonitoringService.Models
{
    /// <summary>
    /// Defines details for the security action taken on denied traffic.
    /// 
    /// </summary>
    public class DeniedSecurityActionDetails 
    {
        
        /// <value>
        /// If true, the evaluated security list and network security group ID details are incomplete.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsRestrictedOrPartial is required.")]
        [JsonProperty(PropertyName = "isRestrictedOrPartial")]
        public System.Nullable<bool> IsRestrictedOrPartial { get; set; }
        
        /// <value>
        /// The list of [OCIDs](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of evaluated security lists associcated
        /// with the OCI resource's subnet.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "evaluatedSecurityListIds")]
        public System.Collections.Generic.List<string> EvaluatedSecurityListIds { get; set; }
        
        /// <value>
        /// List of [OCIDs](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of evaluated network security groups
        /// associated with the OCI resource's VNIC.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "evaluatedNsgIds")]
        public System.Collections.Generic.List<string> EvaluatedNsgIds { get; set; }
        
    }
}