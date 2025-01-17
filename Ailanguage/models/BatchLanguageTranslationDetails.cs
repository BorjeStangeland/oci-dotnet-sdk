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


namespace Oci.AilanguageService.Models
{
    /// <summary>
    /// The documents details for translation call.
    /// </summary>
    public class BatchLanguageTranslationDetails 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the compartment that calls the API, inference will be served from pre trained model
        /// </value>
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Language code supported
        /// Automatically detect language - auto
        /// Arabic - ar
        /// Brazilian Portuguese -  pt-BR    
        /// Czech - cs
        /// Danish - da
        /// Dutch - nl
        /// English - en
        /// Finnish - fi
        /// French - fr
        /// Canadian French - fr-CA     
        /// German - de
        /// Italian - it
        /// Japanese - ja
        /// Korean - ko
        /// Norwegian - no
        /// Polish - pl
        /// Romanian - ro
        /// Simplified Chinese - zh-CN
        /// Spanish - es
        /// Swedish - sv
        /// Traditional Chinese - zh-TW
        /// Turkish - tr
        /// Greek - el
        /// Hebrew - he
        /// 
        /// </value>
        [JsonProperty(PropertyName = "targetLanguageCode")]
        public string TargetLanguageCode { get; set; }
        
        /// <value>
        /// List of documents for translation.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Documents is required.")]
        [JsonProperty(PropertyName = "documents")]
        public System.Collections.Generic.List<TextDocument> Documents { get; set; }
        
    }
}
