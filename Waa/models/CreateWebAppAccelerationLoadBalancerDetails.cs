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


namespace Oci.WaaService.Models
{
    /// <summary>
    /// The information about new WebAppAccelerationLoadBalancer.
    /// </summary>
    public class CreateWebAppAccelerationLoadBalancerDetails : CreateWebAppAccelerationDetails
    {
        
        /// <value>
        /// LoadBalancer [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) to which the WebAppAccelerationPolicy is attached to.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LoadBalancerId is required.")]
        [JsonProperty(PropertyName = "loadBalancerId")]
        public string LoadBalancerId { get; set; }
        
        [JsonProperty(PropertyName = "backendType")]
        private readonly string backendType = "LOAD_BALANCER";
    }
}
