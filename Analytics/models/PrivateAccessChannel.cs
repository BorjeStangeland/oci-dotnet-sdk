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


namespace Oci.AnalyticsService.Models
{
    /// <summary>
    /// Analytics Instance Private Access Channel model.
    /// 
    /// </summary>
    public class PrivateAccessChannel 
    {
        
        /// <value>
        /// Private Access Channel unique identifier key.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Key is required.")]
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        
        /// <value>
        /// Display Name of the Private Access Channel.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// OCID of the customer VCN peered with private access channel.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "VcnId is required.")]
        [JsonProperty(PropertyName = "vcnId")]
        public string VcnId { get; set; }
        
        /// <value>
        /// OCID of the customer subnet connected to private access channel.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SubnetId is required.")]
        [JsonProperty(PropertyName = "subnetId")]
        public string SubnetId { get; set; }
        
        /// <value>
        /// IP Address of the Private Access channel.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IpAddress is required.")]
        [JsonProperty(PropertyName = "ipAddress")]
        public string IpAddress { get; set; }
        
        /// <value>
        /// The list of IP addresses from the customer subnet connected to private access channel, used as a source Ip by Private Access Channel
        /// for network traffic from the AnalyticsInstance to Private Sources.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "EgressSourceIpAddresses is required.")]
        [JsonProperty(PropertyName = "egressSourceIpAddresses")]
        public System.Collections.Generic.List<string> EgressSourceIpAddresses { get; set; }
        
        /// <value>
        /// List of Private Source DNS zones registered with Private Access Channel,
        /// where datasource hostnames from these dns zones / domains will be resolved in the peered VCN for access from Analytics Instance.
        /// Min of 1 is required and Max of 30 Private Source DNS zones can be registered.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "privateSourceDnsZones")]
        public System.Collections.Generic.List<PrivateSourceDnsZone> PrivateSourceDnsZones { get; set; }
        
        /// <value>
        /// List of Private Source DB SCAN hosts registered with Private Access Channel for access from Analytics Instance.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "privateSourceScanHosts")]
        public System.Collections.Generic.List<PrivateSourceScanHost> PrivateSourceScanHosts { get; set; }
        
        /// <value>
        /// Network Security Group OCIDs for an Analytics instance.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "networkSecurityGroupIds")]
        public System.Collections.Generic.List<string> NetworkSecurityGroupIds { get; set; }
        
    }
}
