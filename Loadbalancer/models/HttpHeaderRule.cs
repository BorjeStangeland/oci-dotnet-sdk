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


namespace Oci.LoadbalancerService.Models
{
    /// <summary>
    /// An object that represents the advance http header options that allow the setting of http header size and allow/disallow
    /// invalid characters in the http headers.
    /// For example httpLargeHeaderSizeInKB=32, the http header could have 4 buffers of 32KBs each
    /// This rule applies only to HTTP listeners. No more than one `HttpHeaderRule` object can be present in
    /// a given listener.
    /// 
    /// </summary>
    public class HttpHeaderRule : Rule
    {
        
        /// <value>
        /// Indicates whether or not invalid characters in client header fields will be allowed.
        /// Valid names are composed of English letters, digits, hyphens and underscores.
        /// If \"true\", invalid characters are allowed in the HTTP header.
        /// If \"false\", invalid characters are not allowed in the HTTP header
        /// 
        /// </value>
        [JsonProperty(PropertyName = "areInvalidCharactersAllowed")]
        public System.Nullable<bool> AreInvalidCharactersAllowed { get; set; }

        /// <value>
        /// The maximum size of each buffer used for reading http client request header.
        /// This value indicates the maximum size allowed for each buffer.
        /// The allowed values for buffer size are 8, 16, 32 and 64.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "httpLargeHeaderSizeInKB")]
        public System.Nullable<int> HttpLargeHeaderSizeInKB { get; set; }
    }
}