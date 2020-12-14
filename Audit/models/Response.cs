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


namespace Oci.AuditService.Models
{
    /// <summary>
    /// A container object for response attributes.
    /// 
    /// </summary>
    public class Response 
    {
        
        /// <value>
        /// The status code of the response.
        /// <br/>
        /// Example: 200
        /// </value>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }
        
        /// <value>
        /// The time of the response to the audited request, expressed in
        /// [RFC 3339](https://tools.ietf.org/html/rfc3339) timestamp format.
        /// <br/>
        /// Example: 2019-09-18T00:10:59.278Z
        /// </value>
        [JsonProperty(PropertyName = "responseTime")]
        public System.Nullable<System.DateTime> ResponseTime { get; set; }
        
        /// <value>
        /// The headers of the response.
        /// <br/>
        /// Example:   -----    {      &quot;ETag&quot;: [        &quot;<unique_ID>&quot;      ],      &quot;Connection&quot;: [        &quot;close&quot;      ],      &quot;Content-Length&quot;: [        &quot;1828&quot;      ],      &quot;opc-request-id&quot;: [        &quot;<unique_ID>&quot;      ],      &quot;Date&quot;: [        &quot;Wed, 18 Sep 2019 00:10:59 GMT&quot;      ],      &quot;Content-Type&quot;: [        &quot;application/json&quot;      ]    }  -----
        /// </value>
        [JsonProperty(PropertyName = "headers")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> Headers { get; set; }
        
        /// <value>
        /// This value is included for backward compatibility with the Audit version 1 schema, where 
        /// it contained metadata of interest from the response payload.
        /// <br/>
        /// Example:   -----    {      &quot;resourceName&quot;: &quot;my_instance&quot;,      &quot;id&quot;: &quot;ocid1.instance.oc1.phx.<unique_ID>&quot;    }  -----
        /// </value>
        [JsonProperty(PropertyName = "payload")]
        public System.Collections.Generic.Dictionary<string, System.Object> Payload { get; set; }
        
        /// <value>
        /// A friendly description of what happened during the operation. Use this for troubleshooting.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }
        
    }
}
