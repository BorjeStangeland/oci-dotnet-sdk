/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.OdaService.Models;

namespace Oci.OdaService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/oda/UpdateOdaInstance.cs.html">here</a> to see an example of how to use UpdateOdaInstance request.
    /// </example>
    public class UpdateOdaInstanceRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// Unique Digital Assistant instance identifier.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OdaInstanceId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "odaInstanceId")]
        public string OdaInstanceId { get; set; }
        
        /// <value>
        /// The information to update.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "UpdateOdaInstanceDetails is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Body)]
        public UpdateOdaInstanceDetails UpdateOdaInstanceDetails { get; set; }
        
        /// <value>
        /// For optimistic concurrency control in a PUT or DELETE call for
        /// a Digital Assistant instance, set the `if-match` query parameter
        /// to the value of the `ETAG` header from a previous GET or POST
        /// response for that instance. The service updates or deletes the
        /// instance only if the etag that you provide matches the instance's
        /// current etag value.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "if-match")]
        public string IfMatch { get; set; }
        
        /// <value>
        /// The client request ID for tracing. This value is included in the opc-request-id response header.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
    }
}
