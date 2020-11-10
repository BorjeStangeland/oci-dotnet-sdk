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


namespace Oci.ApigatewayService.Models
{
    /// <summary>
    /// The value will be a copy of the original value of the source header and will not be affected by any other
    /// transformation policies applied to that header.
    /// 
    /// </summary>
    public class RenameHeaderPolicyItem 
    {
        
        /// <value>
        /// The original case-insensitive name of the header.  This name must be unique across transformation policies.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "From is required.")]
        [JsonProperty(PropertyName = "from")]
        public string From { get; set; }
        
        /// <value>
        /// The new name of the header.  This name must be unique across transformation policies.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "To is required.")]
        [JsonProperty(PropertyName = "to")]
        public string To { get; set; }
        
    }
}