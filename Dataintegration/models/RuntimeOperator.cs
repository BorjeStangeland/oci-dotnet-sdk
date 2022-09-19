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


namespace Oci.DataintegrationService.Models
{
    /// <summary>
    /// Runtime operator model which holds the runtime metadata of the task operator executed.
    /// </summary>
    public class RuntimeOperator 
    {
        
        /// <value>
        /// The TaskRun key.
        /// </value>
        [JsonProperty(PropertyName = "taskRunKey")]
        public string TaskRunKey { get; set; }
        
        /// <value>
        /// The runtime operator start time.
        /// </value>
        [JsonProperty(PropertyName = "startTimeInMillis")]
        public System.Nullable<long> StartTimeInMillis { get; set; }
        
        /// <value>
        /// The runtime operator end time.
        /// </value>
        [JsonProperty(PropertyName = "endTimeInMillis")]
        public System.Nullable<long> EndTimeInMillis { get; set; }
                ///
        /// <value>
        /// status
        /// </value>
        ///
        public enum StatusEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "NOT_STARTED")]
            NotStarted,
            [EnumMember(Value = "QUEUED")]
            Queued,
            [EnumMember(Value = "RUNNING")]
            Running,
            [EnumMember(Value = "TERMINATING")]
            Terminating,
            [EnumMember(Value = "TERMINATED")]
            Terminated,
            [EnumMember(Value = "SUCCESS")]
            Success,
            [EnumMember(Value = "ERROR")]
            Error
        };

        /// <value>
        /// status
        /// </value>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<StatusEnum> Status { get; set; }
                ///
        /// <value>
        /// status
        /// </value>
        ///
        public enum ExecutionStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "NOT_STARTED")]
            NotStarted,
            [EnumMember(Value = "RUNNING")]
            Running,
            [EnumMember(Value = "TERMINATED")]
            Terminated,
            [EnumMember(Value = "SUCCESS")]
            Success,
            [EnumMember(Value = "ERROR")]
            Error,
            [EnumMember(Value = "SKIPPED")]
            Skipped,
            [EnumMember(Value = "UNKNOWN")]
            Unknown
        };

        /// <value>
        /// status
        /// </value>
        [JsonProperty(PropertyName = "executionState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ExecutionStateEnum> ExecutionState { get; set; }
        
        /// <value>
        /// A list of parameters for the pipeline, this allows certain aspects of the pipeline to be configured when the pipeline is executed.
        /// </value>
        [JsonProperty(PropertyName = "parameters")]
        public System.Collections.Generic.List<Parameter> Parameters { get; set; }
        
        /// <value>
        /// The configuration provider bindings.
        /// </value>
        [JsonProperty(PropertyName = "inputs")]
        public System.Collections.Generic.Dictionary<string, ParameterValue> Inputs { get; set; }
        
        /// <value>
        /// The configuration provider bindings.
        /// </value>
        [JsonProperty(PropertyName = "outputs")]
        public System.Collections.Generic.Dictionary<string, ParameterValue> Outputs { get; set; }
        
        /// <value>
        /// A map metrics for the task run.
        /// </value>
        [JsonProperty(PropertyName = "metrics")]
        public System.Collections.Generic.Dictionary<string, float> Metrics { get; set; }
        
    }
}
