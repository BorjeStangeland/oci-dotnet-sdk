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
using Newtonsoft.Json.Linq;

namespace Oci.DatabasemanagementService.Models
{
    /// <summary>
    /// The base discover entity.
    /// </summary>
    [JsonConverter(typeof(EntityDiscoveredModelConverter))]
    public class EntityDiscovered 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm). Null for new discover case.
        /// </value>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the agent could be used for monitoring.
        /// </value>
        [JsonProperty(PropertyName = "agentId")]
        public string AgentId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the associated connector.
        /// </value>
        [JsonProperty(PropertyName = "connectorId")]
        public string ConnectorId { get; set; }
        
        /// <value>
        /// The name of the entity.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The version of the entity.
        /// </value>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }
        
        /// <value>
        /// The internal identifier.
        /// </value>
        [JsonProperty(PropertyName = "internalId")]
        public string InternalId { get; set; }
        
        /// <value>
        /// The status of the entity.
        /// </value>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }
                ///
        /// <value>
        /// The status of the entity discover.
        /// </value>
        ///
        public enum DiscoverStatusEnum {
            [EnumMember(Value = "PREV_DISCOVERED")]
            PrevDiscovered,
            [EnumMember(Value = "NEW_DISCOVERED")]
            NewDiscovered,
            [EnumMember(Value = "NOT_FOUND")]
            NotFound,
            [EnumMember(Value = "DISCOVERING")]
            Discovering
        };

        /// <value>
        /// The status of the entity discover.
        /// </value>
        [JsonProperty(PropertyName = "discoverStatus")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<DiscoverStatusEnum> DiscoverStatus { get; set; }
        
        /// <value>
        /// The error code of the discovery on the resource
        /// </value>
        [JsonProperty(PropertyName = "discoverErrorCode")]
        public string DiscoverErrorCode { get; set; }
        
        /// <value>
        /// The error message of the discovery on the resource
        /// </value>
        [JsonProperty(PropertyName = "discoverErrorMsg")]
        public string DiscoverErrorMsg { get; set; }
                ///
        /// <value>
        /// The type of discovered entities.
        /// </value>
        ///
        public enum EntityTypeEnum {
            [EnumMember(Value = "STORAGE_SERVER_DISCOVER_SUMMARY")]
            StorageServerDiscoverSummary,
            [EnumMember(Value = "STORAGE_GRID_DISCOVER_SUMMARY")]
            StorageGridDiscoverSummary,
            [EnumMember(Value = "DATABASE_SYSTEM_DISCOVER_SUMMARY")]
            DatabaseSystemDiscoverSummary,
            [EnumMember(Value = "INFRASTRUCTURE_DISCOVER_SUMMARY")]
            InfrastructureDiscoverSummary,
            [EnumMember(Value = "INFRASTRUCTURE_DISCOVER")]
            InfrastructureDiscover
        };

        
    }

    public class EntityDiscoveredModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(EntityDiscovered);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(EntityDiscovered);
            var discriminator = jsonObject["entityType"].Value<string>();
            switch (discriminator)
            {
                case "STORAGE_GRID_DISCOVER_SUMMARY":
                    obj = new ExternalStorageGridDiscoverySummary();
                    break;
                case "INFRASTRUCTURE_DISCOVER":
                    obj = new ExternalExadataInfrastructureDiscovery();
                    break;
                case "DATABASE_SYSTEM_DISCOVER_SUMMARY":
                    obj = new ExternalDatabaseSystemDiscoverySummary();
                    break;
                case "INFRASTRUCTURE_DISCOVER_SUMMARY":
                    obj = new ExternalExadataInfrastructureDiscoverySummary();
                    break;
                case "STORAGE_SERVER_DISCOVER_SUMMARY":
                    obj = new ExternalStorageServerDiscoverySummary();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
