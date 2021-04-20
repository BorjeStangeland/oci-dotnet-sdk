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


namespace Oci.OpsiService.Models
{
    /// <summary>
    /// Product metric for the host
    /// 
    /// </summary>
    public class HostProduct : HostConfigurationMetricGroup
    {
        
        /// <value>
        /// Vendor of the product
        /// </value>
        [JsonProperty(PropertyName = "vendor")]
        public string Vendor { get; set; }
        
        /// <value>
        /// Name of the product
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// Version of the product
        /// </value>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }
        
        [JsonProperty(PropertyName = "metricName")]
        private readonly string metricName = "HOST_PRODUCT";
    }
}