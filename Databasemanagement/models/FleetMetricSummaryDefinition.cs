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


namespace Oci.DatabasemanagementService.Models
{
    /// <summary>
    /// A summary of the fleet metrics, which provides the metric aggregated value of the databases in the fleet.
    /// </summary>
    public class FleetMetricSummaryDefinition 
    {
        
        /// <value>
        /// The name of the metric.
        /// </value>
        [JsonProperty(PropertyName = "metricName")]
        public string MetricName { get; set; }
        
        /// <value>
        /// The metric aggregated value at the baseline date and time.
        /// </value>
        [JsonProperty(PropertyName = "baselineValue")]
        public System.Double BaselineValue { get; set; }
        
        /// <value>
        /// The metric aggregated value at the target date and time.
        /// </value>
        [JsonProperty(PropertyName = "targetValue")]
        public System.Double TargetValue { get; set; }
        
        /// <value>
        /// The unit of the value.
        /// </value>
        [JsonProperty(PropertyName = "unit")]
        public string Unit { get; set; }
        
        /// <value>
        /// The percentage change in the metric aggregated value compared to the baseline value.
        /// </value>
        [JsonProperty(PropertyName = "percentageChange")]
        public System.Double PercentageChange { get; set; }
        
        /// <value>
        /// The unique dimension key and values of the baseline metric.
        /// </value>
        [JsonProperty(PropertyName = "dimensions")]
        public System.Collections.Generic.List<MetricDimensionDefinition> Dimensions { get; set; }
        
    }
}