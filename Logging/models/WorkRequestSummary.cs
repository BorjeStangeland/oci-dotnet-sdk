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


namespace Oci.LoggingService.Models
{
    /// <summary>
    /// A summary of a work request.
    /// </summary>
    public class WorkRequestSummary 
    {
        
        /// <value>
        /// The OCID of the work request.
        /// </value>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The type of work the work request is doing.
        /// </value>
        [JsonProperty(PropertyName = "operationType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<OperationTypes> OperationType { get; set; }
        
        /// <value>
        /// The current status of the work request.
        /// </value>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<OperationStatus> Status { get; set; }
        
        /// <value>
        /// The OCID of the work request\u2019s compartment.
        /// </value>
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The resources this work request affects.
        /// </value>
        [JsonProperty(PropertyName = "resources")]
        public System.Collections.Generic.List<WorkRequestResource> Resources { get; set; }
        
        /// <value>
        /// Percentage of the request completed.
        /// </value>
        [JsonProperty(PropertyName = "percentComplete")]
        public System.Nullable<float> PercentComplete { get; set; }
        
        /// <value>
        /// The time the work request was accepted.
        /// </value>
        [JsonProperty(PropertyName = "timeAccepted")]
        public System.Nullable<System.DateTime> TimeAccepted { get; set; }
        
        /// <value>
        /// The time the work request was started.
        /// </value>
        [JsonProperty(PropertyName = "timeStarted")]
        public System.Nullable<System.DateTime> TimeStarted { get; set; }
        
        /// <value>
        /// The time the work request was finished.
        /// </value>
        [JsonProperty(PropertyName = "timeFinished")]
        public System.Nullable<System.DateTime> TimeFinished { get; set; }
        
    }
}