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


namespace Oci.DataconnectivityService.Models
{
    /// <summary>
    /// Response of executeOperationJob.
    /// </summary>
    public class ExecuteOperationJob 
    {
        
        /// <value>
        /// Status of the operation job for all sets of input.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OperationStatus is required.")]
        [JsonProperty(PropertyName = "operationStatus")]
        public string OperationStatus { get; set; }
        
        /// <value>
        /// Error message, if whole operation is failed.
        /// </value>
        [JsonProperty(PropertyName = "errorMessage")]
        public string ErrorMessage { get; set; }
        
        /// <value>
        /// Name of the operation.
        /// </value>
        [JsonProperty(PropertyName = "operationName")]
        public string OperationName { get; set; }
        
        /// <value>
        /// List of names of OUT/INOUT params.
        /// </value>
        [JsonProperty(PropertyName = "outParams")]
        public System.Collections.Generic.List<string> OutParams { get; set; }
        
        /// <value>
        /// List of operation execution result for each input set.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OperationResult is required.")]
        [JsonProperty(PropertyName = "operationResult")]
        public System.Collections.Generic.List<OperationExecResult> OperationResult { get; set; }
        
    }
}