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

namespace Oci.DatascienceService.Models
{
    /// <summary>
    /// The job infrastructure configuration details (shape, block storage, etc.)
    /// 
    /// </summary>
    [JsonConverter(typeof(JobInfrastructureConfigurationDetailsModelConverter))]
    public class JobInfrastructureConfigurationDetails 
    {
                ///
        /// <value>
        /// The infrastructure type used for job run.
        /// </value>
        ///
        public enum JobInfrastructureTypeEnum {
            [EnumMember(Value = "STANDALONE")]
            Standalone,
            [EnumMember(Value = "ME_STANDALONE")]
            MeStandalone
        };

        
    }

    public class JobInfrastructureConfigurationDetailsModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(JobInfrastructureConfigurationDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(JobInfrastructureConfigurationDetails);
            var discriminator = jsonObject["jobInfrastructureType"].Value<string>();
            switch (discriminator)
            {
                case "ME_STANDALONE":
                    obj = new ManagedEgressStandaloneJobInfrastructureConfigurationDetails();
                    break;
                case "STANDALONE":
                    obj = new StandaloneJobInfrastructureConfigurationDetails();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
