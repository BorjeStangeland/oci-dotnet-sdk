/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.WaasService.Models;

namespace Oci.WaasService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/waas/ListEdgeSubnets.cs.html">here</a> to see an example of how to use ListEdgeSubnets request.
    /// </example>
    public class ListEdgeSubnetsRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
        
        /// <value>
        /// The maximum number of items to return in a paginated call. If unspecified, defaults to `10`.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "limit")]
        public System.Nullable<int> Limit { get; set; }
        
        /// <value>
        /// The value of the `opc-next-page` response header from the previous paginated call.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "page")]
        public string Page { get; set; }
        
        ///
        /// <value>
        /// The value by which edge node subnets are sorted in a paginated 'List' call. If unspecified, defaults to `timeModified`.
        /// </value>
        ///
        public enum SortByEnum {
            [EnumMember(Value = "cidr")]
            Cidr,
            [EnumMember(Value = "region")]
            Region,
            [EnumMember(Value = "timeModified")]
            TimeModified
        };

        /// <value>
        /// The value by which edge node subnets are sorted in a paginated 'List' call. If unspecified, defaults to `timeModified`.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortBy")]
        public System.Nullable<SortByEnum> SortBy { get; set; }
        
        ///
        /// <value>
        /// The value of the sorting direction of resources in a paginated 'List' call. If unspecified, defaults to `DESC`.
        /// </value>
        ///
        public enum SortOrderEnum {
            [EnumMember(Value = "ASC")]
            Asc,
            [EnumMember(Value = "DESC")]
            Desc
        };

        /// <value>
        /// The value of the sorting direction of resources in a paginated 'List' call. If unspecified, defaults to `DESC`.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortOrder")]
        public System.Nullable<SortOrderEnum> SortOrder { get; set; }
    }
}
