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
using Newtonsoft.Json.Linq;

namespace Oci.CloudmigrationsService.Models
{
    /// <summary>
    /// Details of the new target asset.
    /// </summary>
    [JsonConverter(typeof(CreateTargetAssetDetailsModelConverter))]
    public class CreateTargetAssetDetails 
    {
        
        /// <value>
        /// OCID of the associated migration plan.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MigrationPlanId is required.")]
        [JsonProperty(PropertyName = "migrationPlanId")]
        public string MigrationPlanId { get; set; }
                ///
        /// <value>
        /// The type of target asset.
        /// </value>
        ///
        public enum TypeEnum {
            [EnumMember(Value = "INSTANCE")]
            Instance
        };

        
        /// <value>
        /// A boolean indicating whether the asset should be migrated.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsExcludedFromExecution is required.")]
        [JsonProperty(PropertyName = "isExcludedFromExecution")]
        public System.Nullable<bool> IsExcludedFromExecution { get; set; }
        
    }

    public class CreateTargetAssetDetailsModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(CreateTargetAssetDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(CreateTargetAssetDetails);
            var discriminator = jsonObject["type"].Value<string>();
            switch (discriminator)
            {
                case "INSTANCE":
                    obj = new CreateVmTargetAssetDetails();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}