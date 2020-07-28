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


namespace Oci.AnnouncementsService.Models
{
    /// <summary>
    /// An announcement's status regarding whether it has been acknowledged by a user.
    /// 
    /// </summary>
    public class AnnouncementUserStatusDetails 
    {
        
        /// <value>
        /// The OCID of the announcement that this status is associated with.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "UserStatusAnnouncementId is required.")]
        [JsonProperty(PropertyName = "userStatusAnnouncementId")]
        public string UserStatusAnnouncementId { get; set; }

        /// <value>
        /// The OCID of the user that this status is associated with.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "UserId is required.")]
        [JsonProperty(PropertyName = "userId")]
        public string UserId { get; set; }

        /// <value>
        /// The date and time the announcement was acknowledged, expressed in [RFC 3339](https://tools.ietf.org/html/rfc3339) timestamp format.
        /// Example: 2019-01-01T17:43:01.389+0000
        /// </value>
        [JsonProperty(PropertyName = "timeAcknowledged")]
        public System.Nullable<System.DateTime> TimeAcknowledged { get; set; }
    }
}