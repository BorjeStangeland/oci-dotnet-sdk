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


namespace Oci.AispeechService.Models
{
    /// <summary>
    /// Model details.
    /// </summary>
    public class TranscriptionModelDetails 
    {
                ///
        /// <value>
        /// Domain for input files.
        /// </value>
        ///
        public enum DomainEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "GENERIC")]
            Generic
        };

        /// <value>
        /// Domain for input files.
        /// </value>
        [JsonProperty(PropertyName = "domain")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<DomainEnum> Domain { get; set; }
                ///
        /// <value>
        /// Locale value as per given in [https://datatracker.ietf.org/doc/html/rfc5646].
        /// - en-US: English - United States
        /// - es-ES: Spanish - Spain
        /// - pt-BR: Portuguese - Brazil
        /// - en-GB: English - Great Britain
        /// - en-AU: English - Australia
        /// - en-IN: English - India
        /// - hi-IN: Hindi - India
        /// - fr-FR: French - France
        /// - de-DE: German - Germany
        /// - it-IT: Italian - Italy
        /// 
        /// </value>
        ///
        public enum LanguageCodeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "en-US")]
            EnUs,
            [EnumMember(Value = "es-ES")]
            EsEs,
            [EnumMember(Value = "pt-BR")]
            PtBr,
            [EnumMember(Value = "en-GB")]
            EnGb,
            [EnumMember(Value = "en-AU")]
            EnAu,
            [EnumMember(Value = "en-IN")]
            EnIn,
            [EnumMember(Value = "hi-IN")]
            HiIn,
            [EnumMember(Value = "fr-FR")]
            FrFr,
            [EnumMember(Value = "de-DE")]
            DeDe,
            [EnumMember(Value = "it-IT")]
            ItIt
        };

        /// <value>
        /// Locale value as per given in [https://datatracker.ietf.org/doc/html/rfc5646].
        /// - en-US: English - United States
        /// - es-ES: Spanish - Spain
        /// - pt-BR: Portuguese - Brazil
        /// - en-GB: English - Great Britain
        /// - en-AU: English - Australia
        /// - en-IN: English - India
        /// - hi-IN: Hindi - India
        /// - fr-FR: French - France
        /// - de-DE: German - Germany
        /// - it-IT: Italian - Italy
        /// 
        /// </value>
        [JsonProperty(PropertyName = "languageCode")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LanguageCodeEnum> LanguageCode { get; set; }
        
    }
}
