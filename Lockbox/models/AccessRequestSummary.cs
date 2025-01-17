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


namespace Oci.LockboxService.Models
{
    /// <summary>
    /// Summary information for an access request.
    /// </summary>
    public class AccessRequestSummary 
    {
        
        /// <value>
        /// The unique identifier (OCID) of the access request, which can't be changed after creation.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The unique identifier (OCID) of the lockbox box that the access request is associated with, which can't be changed after creation.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LockboxId is required.")]
        [JsonProperty(PropertyName = "lockboxId")]
        public string LockboxId { get; set; }
        
        /// <value>
        /// The name of the access request.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The rationale for requesting the access request.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Description is required.")]
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The unique identifier of the requestor.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RequestorId is required.")]
        [JsonProperty(PropertyName = "requestorId")]
        public string RequestorId { get; set; }
        
        /// <value>
        /// The current state of the access request.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<AccessRequest.LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// The maximum amount of time operator has access to associated resources.
        /// </value>
        [JsonProperty(PropertyName = "accessDuration")]
        public string AccessDuration { get; set; }
        
        /// <value>
        /// The time the access request was created. Format is defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// Example: 2020-01-25T21:10:29.600Z
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The time the access request was last updated. Format is defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// Example: 2020-01-25T21:10:29.600Z
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeUpdated is required.")]
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// The time the access request expired. Format is defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// Example: 2020-01-25T21:10:29.600Z
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeExpired is required.")]
        [JsonProperty(PropertyName = "timeExpired")]
        public System.Nullable<System.DateTime> TimeExpired { get; set; }
        
    }
}
