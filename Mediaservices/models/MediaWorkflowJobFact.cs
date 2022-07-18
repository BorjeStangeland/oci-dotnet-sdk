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


namespace Oci.MediaservicesService.Models
{
    /// <summary>
    /// One fact of a list of facts associated to a MediaWorkflowJob that presents a point-in-time
    /// snapshot of the resources, data and events that were composed to generate a runnable job.
    /// This information will be used internally to trouble-shoot problematic workflows or jobs.
    /// 
    /// </summary>
    public class MediaWorkflowJobFact 
    {
        
        /// <value>
        /// Reference to the parent job.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MediaWorkflowJobId is required.")]
        [JsonProperty(PropertyName = "mediaWorkflowJobId")]
        public string MediaWorkflowJobId { get; set; }
        
        /// <value>
        /// System generated serial number to uniquely identify a detail in order within a MediaWorkflowJob.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Key is required.")]
        [JsonProperty(PropertyName = "key")]
        public System.Nullable<long> Key { get; set; }
        
        /// <value>
        /// Unique name. It is read-only and generated for the fact.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The type of information contained in this detail.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Type is required.")]
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
        
        /// <value>
        /// The body of the detail captured as JSON.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Detail is required.")]
        [JsonProperty(PropertyName = "detail")]
        public System.Collections.Generic.Dictionary<string, string> Detail { get; set; }
        
    }
}
