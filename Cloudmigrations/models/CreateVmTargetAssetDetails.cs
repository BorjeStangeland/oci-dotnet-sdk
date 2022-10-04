/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.CloudmigrationsService.Models
{
    /// <summary>
    /// Description of the VM target asset.
    /// </summary>
    public class CreateVmTargetAssetDetails : CreateTargetAssetDetails
    {
        
        /// <value>
        /// Preferred VM shape type that you provide.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PreferredShapeType is required.")]
        [JsonProperty(PropertyName = "preferredShapeType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<VmTargetAsset.PreferredShapeTypeEnum> PreferredShapeType { get; set; }
        
        /// <value>
        /// Performance of the block volumes.
        /// </value>
        [JsonProperty(PropertyName = "blockVolumesPerformance")]
        public System.Nullable<int> BlockVolumesPerformance { get; set; }
        
        /// <value>
        /// Microsoft license for the VM configuration.
        /// </value>
        [JsonProperty(PropertyName = "msLicense")]
        public string MsLicense { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "UserSpec is required.")]
        [JsonProperty(PropertyName = "userSpec")]
        public LaunchInstanceDetails UserSpec { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "INSTANCE";
    }
}