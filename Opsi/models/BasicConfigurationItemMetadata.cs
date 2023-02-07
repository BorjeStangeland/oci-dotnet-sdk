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


namespace Oci.OpsiService.Models
{
    /// <summary>
    /// Basic configuration item metadata.
    /// </summary>
    public class BasicConfigurationItemMetadata : ConfigurationItemMetadata
    {
        
        /// <value>
        /// User-friendly display name for the configuration item.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Description of configuration item .
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// Data type of configuration item.
        /// Examples: STRING, BOOLEAN, NUMBER
        /// 
        /// </value>
        [JsonProperty(PropertyName = "dataType")]
        public string DataType { get; set; }
        
        [JsonProperty(PropertyName = "unitDetails")]
        public ConfigurationItemUnitDetails UnitDetails { get; set; }
        
        [JsonProperty(PropertyName = "valueInputDetails")]
        public ConfigurationItemAllowedValueDetails ValueInputDetails { get; set; }
        
        [JsonProperty(PropertyName = "configItemType")]
        private readonly string configItemType = "BASIC";
    }
}
