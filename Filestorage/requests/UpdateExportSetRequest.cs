/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.FilestorageService.Models;

namespace Oci.FilestorageService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/filestorage/UpdateExportSet.cs.html">here</a> to see an example of how to use UpdateExportSet request.
    /// </example>
    public class UpdateExportSetRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The OCID of the export set.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ExportSetId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "exportSetId")]
        public string ExportSetId { get; set; }
        
        /// <value>
        /// Details object for updating an export set.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "UpdateExportSetDetails is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Body)]
        public UpdateExportSetDetails UpdateExportSetDetails { get; set; }
        
        /// <value>
        /// For optimistic concurrency control. In the PUT or DELETE call
        /// for a resource, set the `if-match` parameter to the value of the
        /// etag from a previous GET or POST response for that resource.
        /// The resource will be updated or deleted only if the etag you
        /// provide matches the resource's current etag value.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "if-match")]
        public string IfMatch { get; set; }
        
        /// <value>
        /// Unique identifier for the request.
        /// If you need to contact Oracle about a particular request, please provide the request ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
    }
}
