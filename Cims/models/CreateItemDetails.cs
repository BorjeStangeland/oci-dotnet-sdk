/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace Oci.CimsService.Models
{
    /// <summary>
    /// Details of Item
    /// </summary>
    [JsonConverter(typeof(CreateItemDetailsModelConverter))]
    public class CreateItemDetails 
    {
        
        /// <value>
        /// Type of item. eg: CreateTechSupportItemDetails, CreateLimitItemDetails
        /// </value>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "category")]
        public CreateCategoryDetails Category { get; set; }

        [JsonProperty(PropertyName = "subCategory")]
        public CreateSubCategoryDetails SubCategory { get; set; }

        [JsonProperty(PropertyName = "issueType")]
        public CreateIssueTypeDetails IssueType { get; set; }

        /// <value>
        /// Name of the item
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }

    public class CreateItemDetailsModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(CreateItemDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(CreateItemDetails);
            var discriminator = jsonObject["type"].Value<string>();
            switch (discriminator)
            {
                case "tech":
                    obj = new CreateTechSupportItemDetails();
                    break;
                case "limit":
                    obj = new CreateLimitItemDetails();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}