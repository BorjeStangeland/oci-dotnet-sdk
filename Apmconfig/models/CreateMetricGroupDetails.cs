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


namespace Oci.ApmconfigService.Models
{
    /// <summary>
    /// A metric group defines a set of metrics to collect from a span. It uses a span filter to specify which spans to
    /// process. The set is then published to a namespace, which is a product level subdivision of metrics.
    /// 
    /// </summary>
    public class CreateMetricGroupDetails : CreateConfigDetails
    {
        
        /// <value>
        /// The name of the metric group.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of a Span Filter. The filterId is mandatory for the creation
        /// of MetricGroups. A filterId is generated when a Span Filter is created.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "FilterId is required.")]
        [JsonProperty(PropertyName = "filterId")]
        public string FilterId { get; set; }
        
        /// <value>
        /// The namespace to which the metrics are published. It must be one of several predefined namespaces.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "namespace")]
        public string Namespace { get; set; }
        
        /// <value>
        /// A list of dimensions for the metric. This variable should not be used.
        /// </value>
        [JsonProperty(PropertyName = "dimensions")]
        public System.Collections.Generic.List<Dimension> Dimensions { get; set; }
        
        /// <value>
        /// The list of metrics in this group.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Metrics is required.")]
        [JsonProperty(PropertyName = "metrics")]
        public System.Collections.Generic.List<Metric> Metrics { get; set; }
        
        [JsonProperty(PropertyName = "configType")]
        private readonly string configType = "METRIC_GROUP";
    }
}
