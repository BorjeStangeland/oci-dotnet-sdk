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
    /// SSLForwardProxy used on the firewall policy rules.
    /// </summary>
    public class SslForwardProxyProfile : DecryptionProfile
    {
        
        /// <value>
        /// Whether to block sessions if server's certificate is expired.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsExpiredCertificateBlocked is required.")]
        [JsonProperty(PropertyName = "isExpiredCertificateBlocked")]
        public System.Nullable<bool> IsExpiredCertificateBlocked { get; set; }
        
        /// <value>
        /// Whether to block sessions if server's certificate is issued by an untrusted certificate authority (CA).
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsUntrustedIssuerBlocked is required.")]
        [JsonProperty(PropertyName = "isUntrustedIssuerBlocked")]
        public System.Nullable<bool> IsUntrustedIssuerBlocked { get; set; }
        
        /// <value>
        /// Whether to block sessions if the revocation status check for server's certificate
        /// does not succeed within the maximum allowed time (defaulting to 5 seconds).
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsRevocationStatusTimeoutBlocked is required.")]
        [JsonProperty(PropertyName = "isRevocationStatusTimeoutBlocked")]
        public System.Nullable<bool> IsRevocationStatusTimeoutBlocked { get; set; }
        
        /// <value>
        /// Whether to block sessions if SSL version is not supported.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsUnsupportedVersionBlocked is required.")]
        [JsonProperty(PropertyName = "isUnsupportedVersionBlocked")]
        public System.Nullable<bool> IsUnsupportedVersionBlocked { get; set; }
        
        /// <value>
        /// Whether to block sessions if SSL cipher suite is not supported.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsUnsupportedCipherBlocked is required.")]
        [JsonProperty(PropertyName = "isUnsupportedCipherBlocked")]
        public System.Nullable<bool> IsUnsupportedCipherBlocked { get; set; }
        
        /// <value>
        /// Whether to block sessions if the revocation status check for server's certificate results in \"unknown\".
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsUnknownRevocationStatusBlocked is required.")]
        [JsonProperty(PropertyName = "isUnknownRevocationStatusBlocked")]
        public System.Nullable<bool> IsUnknownRevocationStatusBlocked { get; set; }
        
        /// <value>
        /// Whether to block sessions if the server's certificate uses extensions other than key usage and/or extended key usage.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AreCertificateExtensionsRestricted is required.")]
        [JsonProperty(PropertyName = "areCertificateExtensionsRestricted")]
        public System.Nullable<bool> AreCertificateExtensionsRestricted { get; set; }
        
        /// <value>
        /// Whether to automatically append SAN to impersonating certificate if server certificate is missing SAN.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsAutoIncludeAltName is required.")]
        [JsonProperty(PropertyName = "isAutoIncludeAltName")]
        public System.Nullable<bool> IsAutoIncludeAltName { get; set; }
        
        /// <value>
        /// Whether to block sessions if the firewall is temporarily unable to decrypt their traffic.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsOutOfCapacityBlocked is required.")]
        [JsonProperty(PropertyName = "isOutOfCapacityBlocked")]
        public System.Nullable<bool> IsOutOfCapacityBlocked { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "SSL_FORWARD_PROXY";
    }
}
