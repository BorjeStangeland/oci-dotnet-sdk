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


namespace Oci.VnmonitoringService.Models
{
    /// <summary>
    /// A DRG attachment serves as a link between a DRG and a network resource. A DRG can be attached to a VCN,
    /// IPSec tunnel, remote peering connection, or virtual circuit.
    /// <br/>
    /// For more information, see [Overview of the Networking Service](https://docs.cloud.oracle.com/iaas/Content/Network/Concepts/overview.htm).
    /// 
    /// </summary>
    public class DrgAttachment 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment containing the DRG attachment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// A user-friendly name. Does not have to be unique, and it's changeable.
        /// Avoid entering confidential information.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the DRG.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DrgId is required.")]
        [JsonProperty(PropertyName = "drgId")]
        public string DrgId { get; set; }
        
        /// <value>
        /// The DRG attachment's Oracle ID ([OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm)).
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
                ///
        /// <value>
        /// The DRG attachment's current state.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            [EnumMember(Value = "ATTACHING")]
            Attaching,
            [EnumMember(Value = "ATTACHED")]
            Attached,
            [EnumMember(Value = "DETACHING")]
            Detaching,
            [EnumMember(Value = "DETACHED")]
            Detached
        };

        /// <value>
        /// The DRG attachment's current state.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// The date and time the DRG attachment was created, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// <br/>
        /// Example: 2016-08-25T21:10:29.600Z
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the DRG route table that is assigned to this attachment.
        /// <br/>
        /// The DRG route table manages traffic inside the DRG.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "drgRouteTableId")]
        public string DrgRouteTableId { get; set; }
        
        [JsonProperty(PropertyName = "networkDetails")]
        public DrgAttachmentNetworkDetails NetworkDetails { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the VCN.
        /// This field is deprecated. Instead, use the `networkDetails` field to view the [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the attached resource.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "vcnId")]
        public string VcnId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the export route distribution used to specify how routes in the assigned DRG route table
        /// are advertised to the attachment.
        /// If this value is null, no routes are advertised through this attachment.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "exportDrgRouteDistributionId")]
        public string ExportDrgRouteDistributionId { get; set; }
        
        /// <value>
        /// Indicates whether the DRG attachment and attached network live in a different tenancy than the DRG.
        /// <br/>
        /// Example: false
        /// </value>
        [JsonProperty(PropertyName = "isCrossTenancy")]
        public System.Nullable<bool> IsCrossTenancy { get; set; }
        
    }
}