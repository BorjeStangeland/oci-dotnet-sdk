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
    /// The document response for test classification detect call.
    /// </summary>
    public class TextClassificationDocumentResult 
    {
        
        /// <value>
        /// Document unique identifier defined by the user.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Key is required.")]
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        
        /// <value>
        /// List of detected text classes.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TextClassification is required.")]
        [JsonProperty(PropertyName = "textClassification")]
        public System.Collections.Generic.List<TextClassification> TextClassification { get; set; }
        
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
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LanguageCode is required.")]
        [JsonProperty(PropertyName = "languageCode")]
        public string LanguageCode { get; set; }
        
    }
}
