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


namespace Oci.AianomalydetectionService.Models
{
    /// <summary>
    /// Base class for the DetectAnomalies async call. It contains the identifier that is
    /// used for deciding what type of request this is.
    /// 
    /// </summary>
    public class CreateDetectAnomalyJobDetails 
    {
        
        /// <value>
        /// The OCID of the compartment that starts the job.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// A short description of the detect anomaly job.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// Detect anomaly job display name.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The OCID of the trained model.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ModelId is required.")]
        [JsonProperty(PropertyName = "modelId")]
        public string ModelId { get; set; }
        
        /// <value>
        /// The value that customer can adjust to control the sensitivity of anomaly detection
        /// </value>
        [JsonProperty(PropertyName = "sensitivity")]
        public System.Nullable<float> Sensitivity { get; set; }
        
        /// <value>
        /// Flag to enable the service to return estimates for all data points rather than just the anomalous data points.
        /// </value>
        [JsonProperty(PropertyName = "areAllEstimatesRequired")]
        public System.Nullable<bool> AreAllEstimatesRequired { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "InputDetails is required.")]
        [JsonProperty(PropertyName = "inputDetails")]
        public InputDetails InputDetails { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OutputDetails is required.")]
        [JsonProperty(PropertyName = "outputDetails")]
        public OutputDetails OutputDetails { get; set; }
        
    }
}
