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


namespace Oci.WaaService.Models
{
    /// <summary>
    /// An object that specifies the gzip compression policy.
    /// 
    /// </summary>
    public class GzipCompressionPolicy 
    {
        
        /// <value>
        /// When true, support for gzip compression is enabled. HTTP responses will be compressed with gzip only if the
        /// client indicates support for gzip via the \"Accept-Encoding: gzip\" request header.
        /// <br/>
        /// When false, support for gzip compression is disabled and HTTP responses will not be compressed with gzip
        /// even if the client indicates support for gzip.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isEnabled")]
        public System.Nullable<bool> IsEnabled { get; set; }
        
    }
}
