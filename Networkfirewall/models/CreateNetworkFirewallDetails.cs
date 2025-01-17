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


namespace Oci.NetworkfirewallService.Models
{
    /// <summary>
    /// The information about new Network Firewall.
    /// </summary>
    public class CreateNetworkFirewallDetails 
    {
        
        /// <value>
        /// A user-friendly name for the Network Firewall. Does not have to be unique, and it's changeable. Avoid entering confidential information.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment containing the Network Firewall.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the subnet associated with the Network Firewall.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SubnetId is required.")]
        [JsonProperty(PropertyName = "subnetId")]
        public string SubnetId { get; set; }
        
        /// <value>
        /// Availability Domain where Network Firewall instance is created.
        /// To get a list of availability domains for a tenancy, use {@link #listAvailabilityDomains(ListAvailabilityDomainsRequest) listAvailabilityDomains} operation.
        /// Example: kIdk:PHX-AD-1
        /// </value>
        [JsonProperty(PropertyName = "availabilityDomain")]
        public string AvailabilityDomain { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the Network Firewall Policy.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "NetworkFirewallPolicyId is required.")]
        [JsonProperty(PropertyName = "networkFirewallPolicyId")]
        public string NetworkFirewallPolicyId { get; set; }
        
        /// <value>
        /// IPv4 address for the Network Firewall.
        /// </value>
        [JsonProperty(PropertyName = "ipv4Address")]
        public string Ipv4Address { get; set; }
        
        /// <value>
        /// IPv6 address for the Network Firewall.
        /// </value>
        [JsonProperty(PropertyName = "ipv6Address")]
        public string Ipv6Address { get; set; }
        
        /// <value>
        /// An array of network security groups [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) associated with the Network Firewall.
        /// </value>
        [JsonProperty(PropertyName = "networkSecurityGroupIds")]
        public System.Collections.Generic.List<string> NetworkSecurityGroupIds { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}
