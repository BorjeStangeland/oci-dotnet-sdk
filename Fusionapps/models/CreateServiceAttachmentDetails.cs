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

namespace Oci.FusionappsService.Models
{
    /// <summary>
    /// Information about the service attachment.
    /// </summary>
    [JsonConverter(typeof(CreateServiceAttachmentDetailsModelConverter))]
    public class CreateServiceAttachmentDetails 
    {
                ///
        /// <value>
        /// The operation type - the customer can ask FAaaS to create a new instance or use an existing instance
        /// </value>
        ///
        public enum ActionEnum {
            [EnumMember(Value = "CREATE_NEW_INSTANCE")]
            CreateNewInstance,
            [EnumMember(Value = "ATTACH_EXISTING_INSTANCE")]
            AttachExistingInstance
        };

        
    }

    public class CreateServiceAttachmentDetailsModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(CreateServiceAttachmentDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(CreateServiceAttachmentDetails);
            var discriminator = jsonObject["action"].Value<string>();
            switch (discriminator)
            {
                case "ATTACH_EXISTING_INSTANCE":
                    obj = new AttachExistingInstanceDetails();
                    break;
                case "CREATE_NEW_INSTANCE":
                    obj = new CreateNewInstanceDetails();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
