/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.DatabasemanagementService.Models;

namespace Oci.DatabasemanagementService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/databasemanagement/SummarizeAttentionLogCounts.cs.html">here</a> to see an example of how to use SummarizeAttentionLogCounts request.
    /// </example>
    public class SummarizeAttentionLogCountsRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Managed Database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ManagedDatabaseId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "managedDatabaseId")]
        public string ManagedDatabaseId { get; set; }
        
        /// <value>
        /// The optional greater than or equal to timestamp to filter the logs.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "timeGreaterThanOrEqualTo")]
        public System.Nullable<System.DateTime> TimeGreaterThanOrEqualTo { get; set; }
        
        /// <value>
        /// The optional less than or equal to timestamp to filter the logs.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "timeLessThanOrEqualTo")]
        public System.Nullable<System.DateTime> TimeLessThanOrEqualTo { get; set; }
        
        ///
        /// <value>
        /// The optional parameter to filter the attention logs by urgency.
        /// </value>
        ///
        public enum UrgencyFilterEnum {
            [EnumMember(Value = "IMMEDIATE")]
            Immediate,
            [EnumMember(Value = "SOON")]
            Soon,
            [EnumMember(Value = "DEFERRABLE")]
            Deferrable,
            [EnumMember(Value = "INFO")]
            Info,
            [EnumMember(Value = "ALL")]
            All
        };

        /// <value>
        /// The optional parameter to filter the attention logs by urgency.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "urgencyFilter")]
        public System.Nullable<UrgencyFilterEnum> UrgencyFilter { get; set; }
        
        ///
        /// <value>
        /// The optional parameter used to group different attention logs.
        /// </value>
        ///
        public enum GroupByEnum {
            [EnumMember(Value = "URGENCY")]
            Urgency,
            [EnumMember(Value = "TYPE")]
            Type
        };

        /// <value>
        /// The optional parameter used to group different attention logs.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "groupBy")]
        public System.Nullable<GroupByEnum> GroupBy { get; set; }
        
        ///
        /// <value>
        /// The optional parameter to filter the attention or alert logs by type.
        /// </value>
        ///
        public enum TypeFilterEnum {
            [EnumMember(Value = "UNKNOWN")]
            Unknown,
            [EnumMember(Value = "INCIDENT_ERROR")]
            IncidentError,
            [EnumMember(Value = "ERROR")]
            Error,
            [EnumMember(Value = "WARNING")]
            Warning,
            [EnumMember(Value = "NOTIFICATION")]
            Notification,
            [EnumMember(Value = "TRACE")]
            Trace,
            [EnumMember(Value = "ALL")]
            All
        };

        /// <value>
        /// The optional parameter to filter the attention or alert logs by type.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "typeFilter")]
        public System.Nullable<TypeFilterEnum> TypeFilter { get; set; }
        
        /// <value>
        /// The optional query parameter to filter the attention or alert logs by search text.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "logSearchText")]
        public string LogSearchText { get; set; }
        
        /// <value>
        /// The flag to indicate whether the search text is regular expression or not.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "isRegularExpression")]
        public System.Nullable<bool> IsRegularExpression { get; set; }
        
        /// <value>
        /// The page token representing the page from where the next set of paginated results
        /// are retrieved. This is usually retrieved from a previous list call.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "page")]
        public string Page { get; set; }
        
        /// <value>
        /// The maximum number of records returned in the paginated response.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "limit")]
        public System.Nullable<int> Limit { get; set; }
        
        /// <value>
        /// The client request ID for tracing.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
    }
}