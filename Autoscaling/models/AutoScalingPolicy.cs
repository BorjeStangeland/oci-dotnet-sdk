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

namespace Oci.AutoscalingService.Models
{
    /// <summary>
    /// Autoscaling policies define the criteria that trigger autoscaling actions and the actions to take.
    /// <br/>
    /// An autoscaling policy is part of an autoscaling configuration. For more information, see
    /// [Autoscaling](https://docs.cloud.oracle.com/iaas/Content/Compute/Tasks/autoscalinginstancepools.htm).
    /// 
    /// </summary>
    [JsonConverter(typeof(AutoScalingPolicyModelConverter))]
    public class AutoScalingPolicy 
    {
        
        /// <value>
        /// The capacity requirements of the autoscaling policy.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Capacity is required.")]
        [JsonProperty(PropertyName = "capacity")]
        public Capacity Capacity { get; set; }

        /// <value>
        /// The ID of the autoscaling policy that is assigned after creation.
        /// </value>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <value>
        /// A user-friendly name. Does not have to be unique, and it's changeable. Avoid entering confidential information.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <value>
        /// The type of autoscaling policy.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PolicyType is required.")]
        [JsonProperty(PropertyName = "policyType")]
        public string PolicyType { get; set; }

        /// <value>
        /// The date and time the autoscaling configuration was created, in the format defined by RFC3339.
        /// <br/>
        /// Example: 2016-08-25T21:10:29.600Z
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }

        /// <value>
        /// Boolean field indicating whether this policy is enabled or not.
        /// </value>
        [JsonProperty(PropertyName = "isEnabled")]
        public System.Nullable<bool> IsEnabled { get; set; }
    }

    public class AutoScalingPolicyModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(AutoScalingPolicy);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(AutoScalingPolicy);
            var discriminator = jsonObject["policyType"].Value<string>();
            switch (discriminator)
            {
                case "scheduled":
                    obj = new ScheduledPolicy();
                    break;
                case "threshold":
                    obj = new ThresholdPolicy();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}