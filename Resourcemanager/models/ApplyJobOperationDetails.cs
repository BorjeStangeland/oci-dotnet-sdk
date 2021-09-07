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


namespace Oci.ResourcemanagerService.Models
{
    /// <summary>
    /// Job details that are specific to apply operations.
    /// 
    /// </summary>
    public class ApplyJobOperationDetails : JobOperationDetails
    {
        
        [JsonProperty(PropertyName = "terraformAdvancedOptions")]
        public TerraformAdvancedOptions TerraformAdvancedOptions { get; set; }
                ///
        /// <value>
        /// Specifies the source of the execution plan to apply.
        /// Use `AUTO_APPROVED` to run the job without an execution plan.
        /// 
        /// </value>
        ///
        public enum ExecutionPlanStrategyEnum {
            [EnumMember(Value = "FROM_PLAN_JOB_ID")]
            FromPlanJobId,
            [EnumMember(Value = "FROM_LATEST_PLAN_JOB")]
            FromLatestPlanJob,
            [EnumMember(Value = "AUTO_APPROVED")]
            AutoApproved
        };

        /// <value>
        /// Specifies the source of the execution plan to apply.
        /// Use `AUTO_APPROVED` to run the job without an execution plan.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ExecutionPlanStrategy is required.")]
        [JsonProperty(PropertyName = "executionPlanStrategy")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ExecutionPlanStrategyEnum> ExecutionPlanStrategy { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the plan job that contains the execution plan used for this job,
        /// or `null` if no execution plan was used.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "executionPlanJobId")]
        public string ExecutionPlanJobId { get; set; }
        
        [JsonProperty(PropertyName = "operation")]
        private readonly string operation = "APPLY";
    }
}
