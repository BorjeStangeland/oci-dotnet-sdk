/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.DataflowService.Models;

namespace Oci.DataflowService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/dataflow/ListRuns.cs.html">here</a> to see an example of how to use ListRuns request.
    /// </example>
    public class ListRunsRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The OCID of the compartment.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Unique identifier for the request. If provided, the returned request ID will include this value.
        /// Otherwise, a random request ID will be generated by the service.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
        
        /// <value>
        /// The ID of the application.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "applicationId")]
        public string ApplicationId { get; set; }
        
        /// <value>
        /// The OCID of the user who created the resource.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "ownerPrincipalId")]
        public string OwnerPrincipalId { get; set; }
        
        /// <value>
        /// The displayName prefix.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "displayNameStartsWith")]
        public string DisplayNameStartsWith { get; set; }
        
        /// <value>
        /// The LifecycleState of the run.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "lifecycleState")]
        public System.Nullable<RunLifecycleState> LifecycleState { get; set; }
        
        /// <value>
        /// The epoch time that the resource was created.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "timeCreatedGreaterThan")]
        public System.Nullable<System.DateTime> TimeCreatedGreaterThan { get; set; }
        
        /// <value>
        /// The maximum number of results to return in a paginated `List` call.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "limit")]
        public System.Nullable<int> Limit { get; set; }
        
        /// <value>
        /// The value of the `opc-next-page` or `opc-prev-page` response header from the last `List` call
        /// to sent back to server for getting the next page of results.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "page")]
        public string Page { get; set; }
        
        ///
        /// <value>
        /// The field used to sort the results. Multiple fields are not supported.
        /// 
        /// </value>
        ///
        public enum SortByEnum {
            [EnumMember(Value = "timeCreated")]
            TimeCreated,
            [EnumMember(Value = "displayName")]
            DisplayName,
            [EnumMember(Value = "language")]
            Language,
            [EnumMember(Value = "runDurationInMilliseconds")]
            RunDurationInMilliseconds,
            [EnumMember(Value = "lifecycleState")]
            LifecycleState,
            [EnumMember(Value = "totalOCpu")]
            TotalOCpu,
            [EnumMember(Value = "dataReadInBytes")]
            DataReadInBytes,
            [EnumMember(Value = "dataWrittenInBytes")]
            DataWrittenInBytes
        };

        /// <value>
        /// The field used to sort the results. Multiple fields are not supported.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortBy")]
        public System.Nullable<SortByEnum> SortBy { get; set; }
        
        ///
        /// <value>
        /// The ordering of results in ascending or descending order.
        /// 
        /// </value>
        ///
        public enum SortOrderEnum {
            [EnumMember(Value = "ASC")]
            Asc,
            [EnumMember(Value = "DESC")]
            Desc
        };

        /// <value>
        /// The ordering of results in ascending or descending order.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortOrder")]
        public System.Nullable<SortOrderEnum> SortOrder { get; set; }
        
        /// <value>
        /// The query parameter for the Spark application name.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "displayName")]
        public string DisplayName { get; set; }
    }
}
