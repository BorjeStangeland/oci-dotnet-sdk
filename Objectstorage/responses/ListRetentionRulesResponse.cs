/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.Runtime.Serialization;
using Oci.ObjectstorageService.Models;

namespace Oci.ObjectstorageService.Responses
{
    public class ListRetentionRulesResponse : Oci.Common.IOciResponse
    {

        /// <value>
        /// Unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular
        /// request, provide this request ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }


        /// <value>
        /// Echoes back the value passed in the opc-client-request-id header, for use by clients when debugging.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-client-request-id")]
        public string OpcClientRequestId { get; set; }


        /// <value>
        /// Paginating a list of retention rules.
        /// If the opc-next-page header appears in the response, it indicates that this is a partial list
        /// of retention rules and there are additional rules to get. Include the value of this header as
        /// the `page` parameter in a subsequent GET request to get the next set of retention rules.
        /// Repeat this process to retrieve the entire list of retention rules.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-next-page")]
        public string OpcNextPage { get; set; }

        /// <value>
        /// The returned RetentionRuleCollection instance.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Body)]
        public RetentionRuleCollection RetentionRuleCollection { get; set; }

    }
}
