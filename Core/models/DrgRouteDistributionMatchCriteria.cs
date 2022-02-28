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

namespace Oci.CoreService.Models
{
    /// <summary>
    /// The match criteria in a route distribution statement. The match criteria outlines which routes
    /// should be imported or exported.
    /// 
    /// </summary>
    [JsonConverter(typeof(DrgRouteDistributionMatchCriteriaModelConverter))]
    public class DrgRouteDistributionMatchCriteria 
    {
                ///
        /// <value>
        /// The type of the match criteria for a route distribution statement.
        /// 
        /// </value>
        ///
        public enum MatchTypeEnum {
            [EnumMember(Value = "DRG_ATTACHMENT_TYPE")]
            DrgAttachmentType,
            [EnumMember(Value = "DRG_ATTACHMENT_ID")]
            DrgAttachmentId,
            [EnumMember(Value = "MATCH_ALL")]
            MatchAll
        };

        
    }

    public class DrgRouteDistributionMatchCriteriaModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(DrgRouteDistributionMatchCriteria);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(DrgRouteDistributionMatchCriteria);
            var discriminator = jsonObject["matchType"].Value<string>();
            switch (discriminator)
            {
                case "DRG_ATTACHMENT_ID":
                    obj = new DrgAttachmentIdDrgRouteDistributionMatchCriteria();
                    break;
                case "DRG_ATTACHMENT_TYPE":
                    obj = new DrgAttachmentTypeDrgRouteDistributionMatchCriteria();
                    break;
                case "MATCH_ALL":
                    obj = new DrgAttachmentMatchAllDrgRouteDistributionMatchCriteria();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
