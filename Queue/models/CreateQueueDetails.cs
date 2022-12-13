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


namespace Oci.QueueService.Models
{
    /// <summary>
    /// The information about new Queue.
    /// </summary>
    public class CreateQueueDetails 
    {
        
        /// <value>
        /// Queue Identifier
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Compartment Identifier
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The retention period of the messages in the queue, in seconds.
        /// </value>
        [JsonProperty(PropertyName = "retentionInSeconds")]
        public System.Nullable<int> RetentionInSeconds { get; set; }
        
        /// <value>
        /// The default visibility of the messages consumed from the queue.
        /// </value>
        [JsonProperty(PropertyName = "visibilityInSeconds")]
        public System.Nullable<int> VisibilityInSeconds { get; set; }
        
        /// <value>
        /// The default polling timeout of the messages in the queue, in seconds.
        /// </value>
        [JsonProperty(PropertyName = "timeoutInSeconds")]
        public System.Nullable<int> TimeoutInSeconds { get; set; }
        
        /// <value>
        /// The number of times a message can be delivered to a consumer before being moved to the dead letter queue. A value of 0 indicates that the DLQ is not used.
        /// </value>
        [JsonProperty(PropertyName = "deadLetterQueueDeliveryCount")]
        public System.Nullable<int> DeadLetterQueueDeliveryCount { get; set; }
        
        /// <value>
        /// Id of the custom master encryption key which will be used to encrypt messages content
        /// </value>
        [JsonProperty(PropertyName = "customEncryptionKeyId")]
        public string CustomEncryptionKeyId { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}