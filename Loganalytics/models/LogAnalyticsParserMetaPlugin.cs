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


namespace Oci.LoganalyticsService.Models
{
    /// <summary>
    /// LogAnalyticsParserMetaPlugin
    /// </summary>
    public class LogAnalyticsParserMetaPlugin 
    {
        
        /// <value>
        /// parameter list
        /// </value>
        [JsonProperty(PropertyName = "metaPluginParameters")]
        public System.Collections.Generic.List<LogAnalyticsParserMetaPluginParameter> MetaPluginParameters { get; set; }
        
        /// <value>
        /// plugin description
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// plugin display name
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// plugin internal name
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
    }
}