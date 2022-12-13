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


namespace Oci.GoldengateService.Models
{
    /// <summary>
    /// Represents the metadata of a Azure Data Lake Storage Connection.
    /// 
    /// </summary>
    public class AzureDataLakeStorageConnection : Connection
    {
                ///
        /// <value>
        /// The Azure Data Lake Storage technology type.
        /// </value>
        ///
        public enum TechnologyTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "AZURE_DATA_LAKE_STORAGE")]
            AzureDataLakeStorage
        };

        /// <value>
        /// The Azure Data Lake Storage technology type.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TechnologyType is required.")]
        [JsonProperty(PropertyName = "technologyType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<TechnologyTypeEnum> TechnologyType { get; set; }
                ///
        /// <value>
        /// Used authentication mechanism to access Azure Data Lake Storage.
        /// 
        /// </value>
        ///
        public enum AuthenticationTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "SHARED_KEY")]
            SharedKey,
            [EnumMember(Value = "SHARED_ACCESS_SIGNATURE")]
            SharedAccessSignature,
            [EnumMember(Value = "AZURE_ACTIVE_DIRECTORY")]
            AzureActiveDirectory
        };

        /// <value>
        /// Used authentication mechanism to access Azure Data Lake Storage.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AuthenticationType is required.")]
        [JsonProperty(PropertyName = "authenticationType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<AuthenticationTypeEnum> AuthenticationType { get; set; }
        
        /// <value>
        /// Sets the Azure storage account name.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AccountName is required.")]
        [JsonProperty(PropertyName = "accountName")]
        public string AccountName { get; set; }
        
        /// <value>
        /// Azure tenant ID of the application. This property is required when 'authenticationType' is set to 'AZURE_ACTIVE_DIRECTORY'.
        /// e.g.: 14593954-d337-4a61-a364-9f758c64f97f
        /// 
        /// </value>
        [JsonProperty(PropertyName = "azureTenantId")]
        public string AzureTenantId { get; set; }
        
        /// <value>
        /// Azure client ID of the application. This property is required when 'authenticationType' is set to 'AZURE_ACTIVE_DIRECTORY'.
        /// e.g.: 06ecaabf-8b80-4ec8-a0ec-20cbf463703d
        /// 
        /// </value>
        [JsonProperty(PropertyName = "clientId")]
        public string ClientId { get; set; }
        
        /// <value>
        /// Azure Storage service endpoint.
        /// e.g: https://test.blob.core.windows.net
        /// 
        /// </value>
        [JsonProperty(PropertyName = "endpoint")]
        public string Endpoint { get; set; }
        
        [JsonProperty(PropertyName = "connectionType")]
        private readonly string connectionType = "AZURE_DATA_LAKE_STORAGE";
    }
}
