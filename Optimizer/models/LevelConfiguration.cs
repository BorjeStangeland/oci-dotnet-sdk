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


namespace Oci.OptimizerService.Models
{
    /// <summary>
    /// Details about the configuration level for the recommendation.
    /// </summary>
    public class LevelConfiguration 
    {
        
        /// <value>
        /// The unique OCID of the recommendation.
        /// </value>
        [JsonProperty(PropertyName = "recommendationId")]
        public string RecommendationId { get; set; }
        
        /// <value>
        /// The pre-defined profile level.
        /// </value>
        [JsonProperty(PropertyName = "level")]
        public string Level { get; set; }
        
    }
}