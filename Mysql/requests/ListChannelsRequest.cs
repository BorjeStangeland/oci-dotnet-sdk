/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.MysqlService.Models;

namespace Oci.MysqlService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/mysql/ListChannels.cs.html">here</a> to see an example of how to use ListChannels request.
    /// </example>
    public class ListChannelsRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The compartment [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm).
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Customer-defined unique identifier for the request. If you need to
        /// contact Oracle about a specific request, please provide the request
        /// ID that you supplied in this header with the request.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
        
        /// <value>
        /// The DB System [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm).
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "dbSystemId")]
        public string DbSystemId { get; set; }
        
        /// <value>
        /// The OCID of the Channel.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "channelId")]
        public string ChannelId { get; set; }
        
        /// <value>
        /// A filter to return only the resource matching the given display name exactly.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The LifecycleState of the Channel.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "lifecycleState")]
        public System.Nullable<Channel.LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// If true, returns only Channels that are enabled. If false, returns only
        /// Channels that are disabled.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "isEnabled")]
        public System.Nullable<bool> IsEnabled { get; set; }
        
        ///
        /// <value>
        /// The field to sort by. Only one sort order may be provided. Time fields are default ordered as descending. Display name is default ordered as ascending.
        /// 
        /// </value>
        ///
        public enum SortByEnum {
            [EnumMember(Value = "displayName")]
            DisplayName,
            [EnumMember(Value = "timeCreated")]
            TimeCreated
        };

        /// <value>
        /// The field to sort by. Only one sort order may be provided. Time fields are default ordered as descending. Display name is default ordered as ascending.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortBy")]
        public System.Nullable<SortByEnum> SortBy { get; set; }
        
        ///
        /// <value>
        /// The sort order to use (ASC or DESC).
        /// </value>
        ///
        public enum SortOrderEnum {
            [EnumMember(Value = "ASC")]
            Asc,
            [EnumMember(Value = "DESC")]
            Desc
        };

        /// <value>
        /// The sort order to use (ASC or DESC).
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortOrder")]
        public System.Nullable<SortOrderEnum> SortOrder { get; set; }
        
        /// <value>
        /// The maximum number of items to return in a paginated list call. For information about pagination, see
        /// [List Pagination](https://docs.cloud.oracle.com/#API/Concepts/usingapi.htm#List_Pagination).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "limit")]
        public System.Nullable<int> Limit { get; set; }
        
        /// <value>
        /// The value of the `opc-next-page` or `opc-prev-page` response header from
        /// the previous list call. For information about pagination, see [List
        /// Pagination](https://docs.cloud.oracle.com/#API/Concepts/usingapi.htm#List_Pagination).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "page")]
        public string Page { get; set; }
    }
}