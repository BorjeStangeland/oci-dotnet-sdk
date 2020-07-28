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


namespace Oci.BdsService.Models
{
    /// <summary>
    /// The information about new node
    /// </summary>
    public class CreateNodeDetails 
    {
        
        /// <value>
        /// BDS instance node type
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "NodeType is required.")]
        [JsonProperty(PropertyName = "nodeType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<Node.NodeTypeEnum> NodeType { get; set; }

        /// <value>
        /// Shape of the node
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Shape is required.")]
        [JsonProperty(PropertyName = "shape")]
        public string Shape { get; set; }

        /// <value>
        /// The size of block volume in GB that needs to be attached to a given node.
        /// All the necessary details needed for attachment are managed by service itself.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "BlockVolumeSizeInGBs is required.")]
        [JsonProperty(PropertyName = "blockVolumeSizeInGBs")]
        public System.Nullable<long> BlockVolumeSizeInGBs { get; set; }

        /// <value>
        /// The OCID of the subnet in which the node should be created
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SubnetId is required.")]
        [JsonProperty(PropertyName = "subnetId")]
        public string SubnetId { get; set; }
    }
}