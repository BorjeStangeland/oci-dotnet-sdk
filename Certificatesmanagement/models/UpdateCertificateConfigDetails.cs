/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace Oci.CertificatesmanagementService.Models
{
    /// <summary>
    /// The details of the contents of the certificate and certificate metadata.
    /// </summary>
    [JsonConverter(typeof(UpdateCertificateConfigDetailsModelConverter))]
    public class UpdateCertificateConfigDetails 
    {
        
        
        /// <value>
        /// A name for the certificate version. When the value is not null, a name is unique across versions of a given certificate.
        /// </value>
        [JsonProperty(PropertyName = "versionName")]
        public string VersionName { get; set; }
                ///
        /// <value>
        /// The rotation state of the certificate. The default is `CURRENT`, meaning that the certificate is currently in use. A certificate version
        /// that you mark as `PENDING` is staged and available for use, but you don't yet want to rotate it into current, active use. For example,
        /// you might update a certificate and mark its rotation state as `PENDING` if you haven't yet updated the certificate on the target system.
        /// 
        /// </value>
        ///
        public enum StageEnum {
            [EnumMember(Value = "CURRENT")]
            Current,
            [EnumMember(Value = "PENDING")]
            Pending
        };

        /// <value>
        /// The rotation state of the certificate. The default is `CURRENT`, meaning that the certificate is currently in use. A certificate version
        /// that you mark as `PENDING` is staged and available for use, but you don't yet want to rotate it into current, active use. For example,
        /// you might update a certificate and mark its rotation state as `PENDING` if you haven't yet updated the certificate on the target system.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "stage")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<StageEnum> Stage { get; set; }
        
    }

    public class UpdateCertificateConfigDetailsModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(UpdateCertificateConfigDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(UpdateCertificateConfigDetails);
            var discriminator = jsonObject["configType"].Value<string>();
            switch (discriminator)
            {
                case "IMPORTED":
                    obj = new UpdateCertificateByImportingConfigDetails();
                    break;
                case "ISSUED_BY_INTERNAL_CA":
                    obj = new UpdateCertificateIssuedByInternalCaConfigDetails();
                    break;
                case "MANAGED_EXTERNALLY_ISSUED_BY_INTERNAL_CA":
                    obj = new UpdateCertificateManagedExternallyIssuedByInternalCaConfigDetails();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}