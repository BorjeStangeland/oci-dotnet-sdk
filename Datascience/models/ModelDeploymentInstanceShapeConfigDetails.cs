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


namespace Oci.DatascienceService.Models
{
    /// <summary>
    /// Details for the model-deployment instance shape configuration.
    /// </summary>
    public class ModelDeploymentInstanceShapeConfigDetails 
    {
        
        /// <value>
        /// A model-deployment instance of type VM.Standard.E3.Flex or VM.Standard.E4.Flex allows the ocpu count to be specified with in the range of 1 to 64 ocpu. VM.Standard3.Flex OCPU range is between 1 to 32 ocpu and for VM.Optimized3.Flex OCPU range is 1 to 18 ocpu.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "ocpus")]
        public System.Nullable<float> Ocpus { get; set; }
        
        /// <value>
        /// A model-deployment instance of type VM.Standard.E3.Flex or VM.Standard.E4.Flex allows the memory to be specified with in the range of 6 to 1024 GB. VM.Standard3.Flex memory range is between 6 to 512 GB and VM.Optimized3.Flex memory range is between 6 to 256 GB.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "memoryInGBs")]
        public System.Nullable<float> MemoryInGBs { get; set; }
        
    }
}
