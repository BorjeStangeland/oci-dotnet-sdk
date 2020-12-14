/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.NosqlService.Models;

namespace Oci.NosqlService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/nosql/DeleteRow.cs.html">here</a> to see an example of how to use DeleteRow request.
    /// </example>
    public class DeleteRowRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// A table name within the compartment, or a table OCID.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TableNameOrId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "tableNameOrId")]
        public string TableNameOrId { get; set; }
        
        /// <value>
        /// An array of strings, each of the format \"column-name:value\",
        /// representing the primary key of the row.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Key is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "key")]
        public System.Collections.Generic.List<string> Key { get; set; }
        
        /// <value>
        /// The ID of a table's compartment. When a table is identified
        /// by name, the compartmentId is often needed to provide
        /// context for interpreting the name.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// If true, and the operation fails due to an option setting
        /// (ifVersion et al), then the existing row will be returned.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "isGetReturnRow")]
        public System.Nullable<bool> IsGetReturnRow { get; set; }
        
        /// <value>
        /// Timeout setting for this operation.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "timeoutInMs")]
        public System.Nullable<int> TimeoutInMs { get; set; }
        
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
        /// The client request ID for tracing.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
    }
}
