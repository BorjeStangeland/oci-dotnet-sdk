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
    /// The information about new ServiceInstance.
    /// </summary>
    [JsonConverter(typeof(CreateServiceInstanceDetailsModelConverter))]
    public class CreateServiceInstanceDetails 
    {
        
        /// <value>
        /// The service instance type being provisioned
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Comparment where the instance is to be created
        /// </value>
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
                ///
        /// <value>
        /// Type of the ServiceInstance.
        /// </value>
        ///
        public enum ServiceInstanceTypeEnum {
            [EnumMember(Value = "INTEGRATION_CLOUD")]
            IntegrationCloud,
            [EnumMember(Value = "ANALYTICS_WAREHOUSE")]
            AnalyticsWarehouse
        };

        
    }

    public class CreateServiceInstanceDetailsModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(CreateServiceInstanceDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(CreateServiceInstanceDetails);
            var discriminator = jsonObject["serviceInstanceType"].Value<string>();
            switch (discriminator)
            {
                case "ANALYTICS_WAREHOUSE":
                    obj = new CreateOaxServiceInstanceDetails();
                    break;
                case "INTEGRATION_CLOUD":
                    obj = new CreateOicServiceInstanceDetails();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}