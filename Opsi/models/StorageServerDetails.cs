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


namespace Oci.OpsiService.Models
{
    /// <summary>
    /// Partial information about a storage server which includes name and displayName.
    /// </summary>
    public class StorageServerDetails 
    {
        
        /// <value>
        /// The storage server name.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "StorageServerName is required.")]
        [JsonProperty(PropertyName = "storageServerName")]
        public string StorageServerName { get; set; }
        
        /// <value>
        /// The user-friendly name for the storage server. The name does not have to be unique.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "StorageServerDisplayName is required.")]
        [JsonProperty(PropertyName = "storageServerDisplayName")]
        public string StorageServerDisplayName { get; set; }
        
    }
}