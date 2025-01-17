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


namespace Oci.ContainerinstancesService.Models
{
    /// <summary>
    /// The resource configuration for a Container. The resource configuration determines
    /// the guaranteed resources allocated to the container and the maximum allowed resources for a container.
    /// 
    /// </summary>
    public class ContainerResourceConfig 
    {
        
        /// <value>
        /// The maximum amount of CPU utilization which may be consumed by the Container's
        /// process. If no value is provided, then the process may consume
        /// all CPU resources on the Instance.
        /// CPU usage is defined in terms of logical CPUs. This means that the
        /// maximum possible value on an E3 ContainerInstance with 1 OCPU is 2.0.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "vcpusLimit")]
        public System.Nullable<float> VcpusLimit { get; set; }
        
        /// <value>
        /// The maximum amount of memory which may be consumed by the Container's
        /// process. If no value is provided, then the process
        /// may use all available memory on the Instance.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "memoryLimitInGBs")]
        public System.Nullable<float> MemoryLimitInGBs { get; set; }
        
    }
}
