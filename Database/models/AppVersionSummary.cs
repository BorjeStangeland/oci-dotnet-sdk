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


namespace Oci.DatabaseService.Models
{
    /// <summary>
    /// The version details specific to an app.
    /// 
    /// </summary>
    public class AppVersionSummary 
    {
        
        /// <value>
        /// The Autonomous Container Database version release date.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ReleaseDate is required.")]
        [JsonProperty(PropertyName = "releaseDate")]
        public string ReleaseDate { get; set; }
        
        /// <value>
        /// The Autonomous Container Database version end of support date.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "EndOfSupport is required.")]
        [JsonProperty(PropertyName = "endOfSupport")]
        public string EndOfSupport { get; set; }
        
        /// <value>
        /// The name of the supported application.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SupportedAppName is required.")]
        [JsonProperty(PropertyName = "supportedAppName")]
        public string SupportedAppName { get; set; }
        
        /// <value>
        /// Indicates if the image is certified.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsCertified is required.")]
        [JsonProperty(PropertyName = "isCertified")]
        public System.Nullable<bool> IsCertified { get; set; }
        
    }
}
