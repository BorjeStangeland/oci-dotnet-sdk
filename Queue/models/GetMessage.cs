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


namespace Oci.QueueService.Models
{
    /// <summary>
    /// A message consumed from a queue.
    /// </summary>
    public class GetMessage 
    {
        
        /// <value>
        /// The id of the message - this is only used for tracing and debugging purposes and isn't used as a parameter in any request.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public System.Nullable<long> Id { get; set; }
        
        /// <value>
        /// The content of the message
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Content is required.")]
        [JsonProperty(PropertyName = "content")]
        public string Content { get; set; }
        
        /// <value>
        /// A receipt is a base64urlencode opaque token, uniquely representing a message.
        /// The receipt can be used to delete a message or update its visibility.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Receipt is required.")]
        [JsonProperty(PropertyName = "receipt")]
        public string Receipt { get; set; }
        
        /// <value>
        /// The number of time the message has been delivered to a consumer.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DeliveryCount is required.")]
        [JsonProperty(PropertyName = "deliveryCount")]
        public System.Nullable<int> DeliveryCount { get; set; }
        
        /// <value>
        /// The time after which the message will be visible to other consumers. An RFC3339 formatted datetime string
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "VisibleAfter is required.")]
        [JsonProperty(PropertyName = "visibleAfter")]
        public System.Nullable<System.DateTime> VisibleAfter { get; set; }
        
        /// <value>
        /// The time after which the message will be automatically deleted. An RFC3339 formatted datetime string
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ExpireAfter is required.")]
        [JsonProperty(PropertyName = "expireAfter")]
        public System.Nullable<System.DateTime> ExpireAfter { get; set; }
        
    }
}
