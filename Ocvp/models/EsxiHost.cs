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


namespace Oci.OcvpService.Models
{
    /// <summary>
    /// An ESXi host is a node in an SDDC. At a minimum, each SDDC has 3 ESXi hosts
    /// that are used to implement a functioning VMware environment.
    /// <br/>
    /// In terms of implementation, an ESXi host is a Compute instance that
    /// is configured with the chosen bundle of VMware software.
    /// <br/>
    /// Notice that an `EsxiHost` object has its own OCID (`id`), and a separate
    /// attribute for the OCID of the Compute instance (`computeInstanceId`).
    /// 
    /// </summary>
    public class EsxiHost 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the ESXi host.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// A descriptive name for the ESXi host. Does not have to be unique, and it's changeable.
        /// Avoid entering confidential information.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the SDDC that the
        /// ESXi host belongs to.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SddcId is required.")]
        [JsonProperty(PropertyName = "sddcId")]
        public string SddcId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the compartment that
        /// contains the SDDC.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// In terms of implementation, an ESXi host is a Compute instance that
        /// is configured with the chosen bundle of VMware software. The `computeInstanceId`
        /// is the [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of that Compute instance.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "computeInstanceId")]
        public string ComputeInstanceId { get; set; }
        
        /// <value>
        /// The date and time the ESXi host was created, in the format defined by
        /// [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// <br/>
        /// Example: 2016-08-25T21:10:29.600Z
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The date and time the ESXi host was updated, in the format defined by
        /// [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// The current state of the ESXi host.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LifecycleStates> LifecycleState { get; set; }
        
        /// <value>
        /// The billing option currently used by the ESXi host.
        /// {@link #listSupportedSkus(ListSupportedSkusRequest) listSupportedSkus}.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CurrentSku is required.")]
        [JsonProperty(PropertyName = "currentSku")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<Sku> CurrentSku { get; set; }
        
        /// <value>
        /// The billing option to switch to after the current billing cycle ends.
        /// If `nextSku` is null or empty, `currentSku` continues to the next billing cycle.
        /// {@link #listSupportedSkus(ListSupportedSkusRequest) listSupportedSkus}.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "NextSku is required.")]
        [JsonProperty(PropertyName = "nextSku")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<Sku> NextSku { get; set; }
        
        /// <value>
        /// Current billing cycle end date. If the value in `currentSku` and `nextSku` are different, the value specified in `nextSku`
        /// becomes the new `currentSKU` when the `contractEndDate` is reached.
        /// Example: 2016-08-25T21:10:29.600Z
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "BillingContractEndDate is required.")]
        [JsonProperty(PropertyName = "billingContractEndDate")]
        public System.Nullable<System.DateTime> BillingContractEndDate { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the ESXi host that failed.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "failedEsxiHostId")]
        public string FailedEsxiHostId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the ESXi host that
        /// is created to replace the failed host.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "replacementEsxiHostId")]
        public string ReplacementEsxiHostId { get; set; }
        
        /// <value>
        /// The date and time when the new esxi host should start billing cycle.
        /// [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// Example: 2021-07-25T21:10:29.600Z
        /// </value>
        [JsonProperty(PropertyName = "gracePeriodEndDate")]
        public System.Nullable<System.DateTime> GracePeriodEndDate { get; set; }
        
        /// <value>
        /// The availability domain of the ESXi host.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ComputeAvailabilityDomain is required.")]
        [JsonProperty(PropertyName = "computeAvailabilityDomain")]
        public string ComputeAvailabilityDomain { get; set; }
        
        /// <value>
        /// The compute shape name of the ESXi host.
        /// {@link #listSupportedHostShapes(ListSupportedHostShapesRequest) listSupportedHostShapes}.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "HostShapeName is required.")]
        [JsonProperty(PropertyName = "hostShapeName")]
        public string HostShapeName { get; set; }
        
        /// <value>
        /// The OCPU count of the ESXi host.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "hostOcpuCount")]
        public System.Nullable<float> HostOcpuCount { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no
        /// predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "FreeformTags is required.")]
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a
        /// namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DefinedTags is required.")]
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}
