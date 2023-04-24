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


namespace Oci.DatabasemanagementService.Models
{
    /// <summary>
    /// The Exadata infrastructure details.
    /// </summary>
    public class ExternalExadataInfrastructure : DbmResource
    {
                ///
        /// <value>
        /// The rack size of the Exadata infrastructure.
        /// </value>
        ///
        public enum RackSizeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "FULL")]
            Full,
            [EnumMember(Value = "HALF")]
            Half,
            [EnumMember(Value = "QUARTER")]
            Quarter,
            [EnumMember(Value = "EIGHTH")]
            Eighth
        };

        /// <value>
        /// The rack size of the Exadata infrastructure.
        /// </value>
        [JsonProperty(PropertyName = "rackSize")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<RackSizeEnum> RackSize { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of compartment.
        /// </value>
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
                ///
        /// <value>
        /// The Oracle license model that applies to the database management resources.
        /// 
        /// </value>
        ///
        public enum LicenseModelEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "LICENSE_INCLUDED")]
            LicenseIncluded,
            [EnumMember(Value = "BRING_YOUR_OWN_LICENSE")]
            BringYourOwnLicense
        };

        /// <value>
        /// The Oracle license model that applies to the database management resources.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "licenseModel")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LicenseModelEnum> LicenseModel { get; set; }
        
        [JsonProperty(PropertyName = "storageGrid")]
        public ExternalExadataStorageGridSummary StorageGrid { get; set; }
        
        /// <value>
        /// A list of database systems.
        /// </value>
        [JsonProperty(PropertyName = "databaseSystems")]
        public System.Collections.Generic.List<ExternalExadataDatabaseSystemSummary> DatabaseSystems { get; set; }
        
        /// <value>
        /// The list of [OCIDs] (https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the compartments
        /// </value>
        [JsonProperty(PropertyName = "databaseCompartments")]
        public System.Collections.Generic.List<string> DatabaseCompartments { get; set; }
        
        [JsonProperty(PropertyName = "resourceType")]
        private readonly string resourceType = "INFRASTRUCTURE";
    }
}
