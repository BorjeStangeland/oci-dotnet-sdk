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


namespace Oci.DevopsService.Models
{
    /// <summary>
    /// Specifies the Container Engine for Kubernetes (OKE) cluster canary deployment traffic shift stage.
    /// </summary>
    public class OkeCanaryTrafficShiftDeployStage : DeployStage
    {
        
        /// <value>
        /// The OCID of an upstream OKE canary deployment stage in this pipeline.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OkeCanaryDeployStageId is required.")]
        [JsonProperty(PropertyName = "okeCanaryDeployStageId")]
        public string OkeCanaryDeployStageId { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RolloutPolicy is required.")]
        [JsonProperty(PropertyName = "rolloutPolicy")]
        public LoadBalancerTrafficShiftRolloutPolicy RolloutPolicy { get; set; }
        
        [JsonProperty(PropertyName = "deployStageType")]
        private readonly string deployStageType = "OKE_CANARY_TRAFFIC_SHIFT";
    }
}