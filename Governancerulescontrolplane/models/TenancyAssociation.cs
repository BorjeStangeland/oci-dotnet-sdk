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


namespace Oci.GovernancerulescontrolplaneService.Models
{
    /// <summary>
    /// Tenancy association represents the tenancy id to which the governance rule will be applied.
    /// 
    /// </summary>
    public class TenancyAssociation : Association
    {
        
        /// <value>
        /// The Oracle ID ([OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm)) of the tenancy to which the governance rule will be applied as part of this tenancy inclusion criterion.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TenancyId is required.")]
        [JsonProperty(PropertyName = "tenancyId")]
        public string TenancyId { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "TENANCY";
    }
}