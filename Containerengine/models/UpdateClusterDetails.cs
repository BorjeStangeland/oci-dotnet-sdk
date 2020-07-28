/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.ContainerengineService.Models
{
    /// <summary>
    /// The properties that define a request to update a cluster.
    /// </summary>
    public class UpdateClusterDetails 
    {
        
        /// <value>
        /// The new name for the cluster. Avoid entering confidential information.
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <value>
        /// The version of Kubernetes to which the cluster masters should be upgraded.
        /// </value>
        [JsonProperty(PropertyName = "kubernetesVersion")]
        public string KubernetesVersion { get; set; }

        [JsonProperty(PropertyName = "options")]
        public UpdateClusterOptionsDetails Options { get; set; }
    }
}