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


namespace Oci.FusionappsService.Models
{
    /// <summary>
    /// The policy that specifies the maintenance and upgrade preferences for an environment. For more information about the options, see [Understanding Environment Maintenance](https://docs.cloud.oracle.com/iaas/Content/fusion-applications/plan-environment-family.htm#about-env-maintenance).
    /// </summary>
    public class MaintenancePolicy 
    {
                ///
        /// <value>
        /// When \"ENABLED\", the Fusion environment is patched monthly. When \"DISABLED\", the Fusion environment is not patched monthly. This setting overrides the environment family setting. When not set, the environment follows the environment family policy.
        /// </value>
        ///
        public enum MonthlyPatchingOverrideEnum {
            [EnumMember(Value = "ENABLED")]
            Enabled,
            [EnumMember(Value = "DISABLED")]
            Disabled,
            [EnumMember(Value = "NONE")]
            None
        };

        /// <value>
        /// When \"ENABLED\", the Fusion environment is patched monthly. When \"DISABLED\", the Fusion environment is not patched monthly. This setting overrides the environment family setting. When not set, the environment follows the environment family policy.
        /// </value>
        [JsonProperty(PropertyName = "monthlyPatchingOverride")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<MonthlyPatchingOverrideEnum> MonthlyPatchingOverride { get; set; }
                ///
        /// <value>
        /// User choice to upgrade both test and prod pods at the same time. Overrides fusion environment families'.
        /// </value>
        ///
        public enum EnvironmentMaintenanceOverrideEnum {
            [EnumMember(Value = "PROD")]
            Prod,
            [EnumMember(Value = "NON_PROD")]
            NonProd,
            [EnumMember(Value = "NONE")]
            None
        };

        /// <value>
        /// User choice to upgrade both test and prod pods at the same time. Overrides fusion environment families'.
        /// </value>
        [JsonProperty(PropertyName = "environmentMaintenanceOverride")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<EnvironmentMaintenanceOverrideEnum> EnvironmentMaintenanceOverride { get; set; }
        
    }
}
