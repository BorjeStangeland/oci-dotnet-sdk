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


namespace Oci.DataintegrationService.Models
{
    /// <summary>
    /// The properties used in create dataflow validation operations.
    /// </summary>
    public class CreateDataFlowValidationDetails 
    {
        
        /// <value>
        /// Generated key that can be used in API calls to identify data flow. On scenarios where reference to the data flow is needed, a value can be passed in create.
        /// </value>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        
        /// <value>
        /// The type of the object.
        /// </value>
        [JsonProperty(PropertyName = "modelType")]
        public string ModelType { get; set; }
        
        /// <value>
        /// The model version of an object.
        /// </value>
        [JsonProperty(PropertyName = "modelVersion")]
        public string ModelVersion { get; set; }
        
        [JsonProperty(PropertyName = "parentRef")]
        public ParentReference ParentRef { get; set; }
        
        /// <value>
        /// Free form text without any restriction on permitted characters. Name can have letters, numbers, and special characters. The value is editable and is restricted to 1000 characters.
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// Value can only contain upper case letters, underscore, and numbers. It should begin with upper case letter or underscore. The value can be modified.
        /// </value>
        [JsonProperty(PropertyName = "identifier")]
        public string Identifier { get; set; }
        
        /// <value>
        /// The version of the object that is used to track changes in the object instance.
        /// </value>
        [JsonProperty(PropertyName = "objectVersion")]
        public System.Nullable<int> ObjectVersion { get; set; }
        
        /// <value>
        /// An array of nodes.
        /// </value>
        [JsonProperty(PropertyName = "nodes")]
        public System.Collections.Generic.List<FlowNode> Nodes { get; set; }
        
        /// <value>
        /// An array of parameters.
        /// </value>
        [JsonProperty(PropertyName = "parameters")]
        public System.Collections.Generic.List<Parameter> Parameters { get; set; }
        
        /// <value>
        /// Detailed description for the object.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        [JsonProperty(PropertyName = "flowConfigValues")]
        public ConfigValues FlowConfigValues { get; set; }
        
        /// <value>
        /// The status of an object that can be set to value 1 for shallow references across objects, other values reserved.
        /// </value>
        [JsonProperty(PropertyName = "objectStatus")]
        public System.Nullable<int> ObjectStatus { get; set; }
        
        [JsonProperty(PropertyName = "metadata")]
        public ObjectMetadata Metadata { get; set; }
        
        /// <value>
        /// A key map. If provided, key is replaced with generated key. This structure provides mapping between user provided key and generated key.
        /// </value>
        [JsonProperty(PropertyName = "keyMap")]
        public System.Collections.Generic.Dictionary<string, string> KeyMap { get; set; }
        
        /// <value>
        /// A hash map that maps TypedObject keys to the object itself, for java sdk.
        /// </value>
        [JsonProperty(PropertyName = "typedObjectMap")]
        public System.Collections.Generic.Dictionary<string, TypedObjectWrapper> TypedObjectMap { get; set; }
        
        /// <value>
        /// A hash map that maps TypedObject keys to a field map that maps to the typed object as a target, for java sdk.
        /// </value>
        [JsonProperty(PropertyName = "targetFieldMapSummary")]
        public System.Collections.Generic.Dictionary<string, FieldMapWrapper> TargetFieldMapSummary { get; set; }
        
    }
}
