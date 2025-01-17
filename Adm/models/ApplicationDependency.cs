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


namespace Oci.AdmService.Models
{
    /// <summary>
    /// An Application Dependency resource creates a Vulnerability Audit.
    /// </summary>
    public class ApplicationDependency 
    {
        
        /// <value>
        /// Group Artifact Version (GAV) identifier (Group:Artifact:Version), e.g. org.graalvm.nativeimage:svm:21.1.0.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Gav is required.")]
        [JsonProperty(PropertyName = "gav")]
        public string Gav { get; set; }
        
        /// <value>
        /// Unique identifier of an Application Dependency, for example nodeId1.
        /// The nodeId can be generated by assigning a unique id to each application dependency
        /// in the tree of application dependencies.
        /// Every node, even those who share the same GAV, should have a different nodeId.
        /// The preferred way of constructing a nodeId is to assign incremental integers
        /// during a breadth first or depth first search.
        /// A nodeId can be reused only it refers to the same subtree of application dependencies.
        /// (This is not equivalent to referring to the same GAV, that is,
        /// a GAV can have multiple transitive dependencies.)
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "NodeId is required.")]
        [JsonProperty(PropertyName = "nodeId")]
        public string NodeId { get; set; }
        
        /// <value>
        /// List of Application Dependencies on which this Application Dependency depends, each identified by its nodeId.
        /// </value>
        [JsonProperty(PropertyName = "applicationDependencyNodeIds")]
        public System.Collections.Generic.List<string> ApplicationDependencyNodeIds { get; set; }
        
    }
}
