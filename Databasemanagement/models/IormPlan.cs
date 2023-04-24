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


namespace Oci.DatabasemanagementService.Models
{
    /// <summary>
    /// The IORM plan from a storage server.
    /// </summary>
    public class IormPlan 
    {
        
        /// <value>
        /// The status of the IORM plan.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PlanStatus is required.")]
        [JsonProperty(PropertyName = "planStatus")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<IormPlanStatusEnum> PlanStatus { get; set; }
        
        /// <value>
        /// The objective of the IORM plan.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PlanObjective is required.")]
        [JsonProperty(PropertyName = "planObjective")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<IormPlanObjectiveEnum> PlanObjective { get; set; }
        
        [JsonProperty(PropertyName = "dbPlan")]
        public DatabasePlan DbPlan { get; set; }
        
    }
}
