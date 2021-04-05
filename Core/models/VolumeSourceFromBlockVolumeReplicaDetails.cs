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


namespace Oci.CoreService.Models
{
    /// <summary>
    /// Specifies the source block volume replica which the block volume will be created from.
    /// The block volume replica shoulbe be in the same availability domain as the block volume.
    /// Only one volume can be created from a replica at the same time.
    /// 
    /// </summary>
    public class VolumeSourceFromBlockVolumeReplicaDetails : VolumeSourceDetails
    {
        
        /// <value>
        /// The OCID of the block volume replica.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "blockVolumeReplica";
    }
}
