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


namespace Oci.OnesubscriptionService.Models
{
    /// <summary>
    /// Payment Term details
    /// 
    /// </summary>
    public class InvoicingPaymentTerm 
    {
        
        /// <value>
        /// Payment Term name
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// Payment Term value
        /// 
        /// </value>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
        
        /// <value>
        /// Payment term Description
        /// 
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// Payment term active flag
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isActive")]
        public System.Nullable<bool> IsActive { get; set; }
        
        /// <value>
        /// Payment term last update date
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// User that created the Payment term
        /// 
        /// </value>
        [JsonProperty(PropertyName = "createdBy")]
        public string CreatedBy { get; set; }
        
        /// <value>
        /// Payment term last update date
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// User that updated the Payment term
        /// 
        /// </value>
        [JsonProperty(PropertyName = "updatedBy")]
        public string UpdatedBy { get; set; }
        
    }
}
