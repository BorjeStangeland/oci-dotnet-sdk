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


namespace Oci.DatacatalogService.Models
{
    /// <summary>
    /// Array of custom property IDs for which we have to associate the custom property to the type
    /// </summary>
    public class TypeCustomPropertyDetails 
    {
        
        /// <value>
        /// array of custom property Ids
        /// </value>
        [JsonProperty(PropertyName = "customPropertyIds")]
        public System.Collections.Generic.List<string> CustomPropertyIds { get; set; }
        
    }
}