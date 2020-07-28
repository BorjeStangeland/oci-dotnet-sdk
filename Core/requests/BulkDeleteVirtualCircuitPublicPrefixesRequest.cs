/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.CoreService.Models;

namespace Oci.CoreService.Requests
{
    public class BulkDeleteVirtualCircuitPublicPrefixesRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The OCID of the virtual circuit.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "VirtualCircuitId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "virtualCircuitId")]
        public string VirtualCircuitId { get; set; }
        
        /// <value>
        /// Request with publix prefixes to be deleted from the virtual circuit
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "BulkDeleteVirtualCircuitPublicPrefixesDetails is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Body)]
        public BulkDeleteVirtualCircuitPublicPrefixesDetails BulkDeleteVirtualCircuitPublicPrefixesDetails { get; set; }
    }
}