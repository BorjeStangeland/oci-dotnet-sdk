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


namespace Oci.BdsService.Models
{
    /// <summary>
    /// The information about added nodes.
    /// </summary>
    public class AddWorkerNodesDetails 
    {
        
        /// <value>
        /// Base-64 encoded password for the cluster (and Cloudera Manager) admin user.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ClusterAdminPassword is required.")]
        [JsonProperty(PropertyName = "clusterAdminPassword")]
        public string ClusterAdminPassword { get; set; }
        
        /// <value>
        /// Number of additional worker nodes for the cluster.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "NumberOfWorkerNodes is required.")]
        [JsonProperty(PropertyName = "numberOfWorkerNodes")]
        public System.Nullable<int> NumberOfWorkerNodes { get; set; }
                ///
        /// <value>
        /// Worker node types, can either be Worker Data node or Compute only worker node.
        /// </value>
        ///
        public enum NodeTypeEnum {
            [EnumMember(Value = "WORKER")]
            Worker,
            [EnumMember(Value = "COMPUTE_ONLY_WORKER")]
            ComputeOnlyWorker,
            [EnumMember(Value = "EDGE")]
            Edge
        };

        /// <value>
        /// Worker node types, can either be Worker Data node or Compute only worker node.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "NodeType is required.")]
        [JsonProperty(PropertyName = "nodeType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<NodeTypeEnum> NodeType { get; set; }
        
        /// <value>
        /// Shape of the node. This has to be specified when adding compute only worker node at the first time. Otherwise, it's a read-only property.
        /// </value>
        [JsonProperty(PropertyName = "shape")]
        public string Shape { get; set; }
        
        /// <value>
        /// The size of block volume in GB to be attached to the given node. This has to be specified when adding compute only worker node at the first time. Otherwise, it's a read-only property.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "blockVolumeSizeInGBs")]
        public System.Nullable<long> BlockVolumeSizeInGBs { get; set; }
        
        [JsonProperty(PropertyName = "shapeConfig")]
        public ShapeConfigDetails ShapeConfig { get; set; }
        
    }
}
