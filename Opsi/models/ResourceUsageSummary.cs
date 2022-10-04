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


namespace Oci.OpsiService.Models
{
    /// <summary>
    /// Contains resource usage summary
    /// </summary>
    public class ResourceUsageSummary 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the Exadata insight.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ExadataInsightId is required.")]
        [JsonProperty(PropertyName = "exadataInsightId")]
        public string ExadataInsightId { get; set; }
        
        /// <value>
        /// The user-friendly name for the Exadata system. The name does not have to be unique.
        /// </value>
        [JsonProperty(PropertyName = "exadataDisplayName")]
        public string ExadataDisplayName { get; set; }
        
        /// <value>
        /// Total amount used of the resource metric type (CPU, STORAGE).
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Usage is required.")]
        [JsonProperty(PropertyName = "usage")]
        public System.Double Usage { get; set; }
        
        /// <value>
        /// The maximum allocated amount of the resource metric type  (CPU, STORAGE) for a set of databases.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Capacity is required.")]
        [JsonProperty(PropertyName = "capacity")]
        public System.Double Capacity { get; set; }
        
        /// <value>
        /// Resource utilization in percentage
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "UtilizationPercent is required.")]
        [JsonProperty(PropertyName = "utilizationPercent")]
        public System.Double UtilizationPercent { get; set; }
        
        /// <value>
        /// Change in resource utilization in percentage
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "UsageChangePercent is required.")]
        [JsonProperty(PropertyName = "usageChangePercent")]
        public System.Double UsageChangePercent { get; set; }
        
        /// <value>
        /// The maximum host CPUs (cores x threads/core) on the underlying infrastructure. This only applies to CPU and does not not apply for Autonomous Databases.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "totalHostCapacity")]
        public System.Double TotalHostCapacity { get; set; }
        
    }
}
