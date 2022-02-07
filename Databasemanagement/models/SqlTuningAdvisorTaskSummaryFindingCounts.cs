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


namespace Oci.DatabasemanagementService.Models
{
    /// <summary>
    /// The number of findings in the SQL Tuning Advisor summary report.
    /// </summary>
    public class SqlTuningAdvisorTaskSummaryFindingCounts 
    {
        
        /// <value>
        /// The number of distinct SQL statements with recommended SQL profiles.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RecommendedSqlProfile is required.")]
        [JsonProperty(PropertyName = "recommendedSqlProfile")]
        public System.Nullable<int> RecommendedSqlProfile { get; set; }
        
        /// <value>
        /// The number of distinct SQL statements with implemented SQL profiles.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ImplementedSqlProfile is required.")]
        [JsonProperty(PropertyName = "implementedSqlProfile")]
        public System.Nullable<int> ImplementedSqlProfile { get; set; }
        
        /// <value>
        /// The number of distinct SQL statements with index recommendations.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Index is required.")]
        [JsonProperty(PropertyName = "index")]
        public System.Nullable<int> Index { get; set; }
        
        /// <value>
        /// The number of distinct SQL statements with restructured SQL recommendations.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Restructure is required.")]
        [JsonProperty(PropertyName = "restructure")]
        public System.Nullable<int> Restructure { get; set; }
        
        /// <value>
        /// The number of distinct SQL statements with stale or missing optimizer statistics recommendations.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Statistics is required.")]
        [JsonProperty(PropertyName = "statistics")]
        public System.Nullable<int> Statistics { get; set; }
        
        /// <value>
        /// The number of distinct SQL statements with alternative plan recommendations.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AlternatePlan is required.")]
        [JsonProperty(PropertyName = "alternatePlan")]
        public System.Nullable<int> AlternatePlan { get; set; }
        
    }
}
