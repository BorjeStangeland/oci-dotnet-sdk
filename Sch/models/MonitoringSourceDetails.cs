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


namespace Oci.SchService.Models
{
    /// <summary>
    /// The Monitoring source.
    /// For configuration instructions, see
    /// [To create a service connector](https://docs.cloud.oracle.com/iaas/Content/service-connector-hub/managingconnectors.htm#create).
    /// 
    /// </summary>
    public class MonitoringSourceDetails : SourceDetails
    {
        
        /// <value>
        /// The list of metric namespaces to retrieve data from.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MonitoringSources is required.")]
        [JsonProperty(PropertyName = "monitoringSources")]
        public System.Collections.Generic.List<MonitoringSource> MonitoringSources { get; set; }
        
        [JsonProperty(PropertyName = "kind")]
        private readonly string kind = "monitoring";
    }
}
