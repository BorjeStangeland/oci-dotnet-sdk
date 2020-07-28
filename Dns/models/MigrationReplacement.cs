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


namespace Oci.DnsService.Models
{
    /// <summary>
    /// A record to add to a zone in replacement of contents that cannot be migrated.
    /// 
    /// </summary>
    public class MigrationReplacement 
    {
        
        /// <value>
        /// The canonical name for the type of the replacement record, such as A or CNAME.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Rtype is required.")]
        [JsonProperty(PropertyName = "rtype")]
        public string Rtype { get; set; }

        /// <value>
        /// The canonical name for a substitute type of the replacement record to be used if the specified `rtype` is not allowed at the domain. The specified `ttl` and `rdata` will still apply with the substitute type.
        /// </value>
        [JsonProperty(PropertyName = "substituteRtype")]
        public string SubstituteRtype { get; set; }

        /// <value>
        /// The Time To Live of the replacement record, in seconds.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Ttl is required.")]
        [JsonProperty(PropertyName = "ttl")]
        public System.Nullable<int> Ttl { get; set; }

        /// <value>
        /// The record data of the replacement record, as whitespace-delimited tokens in
        /// type-specific presentation format.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Rdata is required.")]
        [JsonProperty(PropertyName = "rdata")]
        public string Rdata { get; set; }
    }
}