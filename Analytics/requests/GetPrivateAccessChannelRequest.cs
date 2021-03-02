/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.AnalyticsService.Models;

namespace Oci.AnalyticsService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/analytics/GetPrivateAccessChannel.cs.html">here</a> to see an example of how to use GetPrivateAccessChannel request.
    /// </example>
    public class GetPrivateAccessChannelRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The unique identifier key of the Private Access Channel.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PrivateAccessChannelKey is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "privateAccessChannelKey")]
        public string PrivateAccessChannelKey { get; set; }
        
        /// <value>
        /// The OCID of the AnalyticsInstance.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AnalyticsInstanceId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "analyticsInstanceId")]
        public string AnalyticsInstanceId { get; set; }
        
        /// <value>
        /// Unique identifier for the request.
        /// If you need to contact Oracle about a particular request, please provide the request ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
    }
}