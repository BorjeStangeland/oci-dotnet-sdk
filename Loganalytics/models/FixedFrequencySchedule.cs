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


namespace Oci.LoganalyticsService.Models
{
    /// <summary>
    /// Fixed frequency schedule for a scheduled task.
    /// </summary>
    public class FixedFrequencySchedule : Schedule
    {
        
        /// <value>
        /// Recurring interval in ISO 8601 extended format as described in
        /// https://en.wikipedia.org/wiki/ISO_8601#Durations.
        /// The largest supported unit is D, e.g. P14D (not P2W).
        /// The value must be at least 5 minutes (PT5M) and at most 3 weeks (P21D or PT30240M).
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RecurringInterval is required.")]
        [JsonProperty(PropertyName = "recurringInterval")]
        public string RecurringInterval { get; set; }
        
        /// <value>
        /// Number of times (0-based) to execute until auto-stop.
        /// Default value -1 will execute indefinitely.
        /// Value 0 will execute once.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "repeatCount")]
        public System.Nullable<int> RepeatCount { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "FIXED_FREQUENCY";
    }
}