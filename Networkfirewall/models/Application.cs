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

namespace Oci.NetworkfirewallService.Models
{
    /// <summary>
    /// A protocol identifier (such as TCP, UDP, or ICMP)
    /// and protocol-specific parameters (such as a port range).
    /// 
    /// </summary>
    [JsonConverter(typeof(ApplicationModelConverter))]
    public class Application 
    {
        
        
    }

    public class ApplicationModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(Application);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(Application);
            var discriminator = jsonObject["type"].Value<string>();
            switch (discriminator)
            {
                case "ICMP":
                    obj = new IcmpApplication();
                    break;
                case "UDP":
                    obj = new UdpApplication();
                    break;
                case "TCP":
                    obj = new TcpApplication();
                    break;
                case "ICMP6":
                    obj = new Icmp6Application();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
