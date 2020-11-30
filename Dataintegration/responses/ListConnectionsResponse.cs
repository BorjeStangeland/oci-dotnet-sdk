/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.Runtime.Serialization;
using Oci.DataintegrationService.Models;

namespace Oci.DataintegrationService.Responses
{
    public class ListConnectionsResponse : Oci.Common.IOciResponse
    {

        /// <value>
        /// Unique Oracle-assigned identifier for the request. If you need to contact
        /// Oracle about a particular request, please provide the request ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }


        /// <value>
        /// Retrieves the next page of results. When this header appears in the response, additional pages of results remain. See [List Pagination](https://docs.cloud.oracle.com/iaas/Content/API/Concepts/usingapi.htm#nine).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-next-page")]
        public string OpcNextPage { get; set; }


        /// <value>
        /// Retrieves the previous page of results. When this header appears in the response, previous pages of results exist. See [List Pagination](https://docs.cloud.oracle.com/iaas/Content/API/Concepts/usingapi.htm#nine).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-prev-page")]
        public string OpcPrevPage { get; set; }


        /// <value>
        /// Total items in the entire list.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-total-items")]
        public System.Nullable<int> OpcTotalItems { get; set; }

        /// <value>
        /// The returned ConnectionSummaryCollection instance.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Body)]
        public ConnectionSummaryCollection ConnectionSummaryCollection { get; set; }

    }
}
