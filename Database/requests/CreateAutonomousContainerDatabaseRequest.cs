/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.DatabaseService.Models;

namespace Oci.DatabaseService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/8.0.0/database/CreateAutonomousContainerDatabase.cs.html">here</a> to see an example of how to use CreateAutonomousContainerDatabase request.
    /// </example>
    public class CreateAutonomousContainerDatabaseRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// Request to create an Autonomous Container Database in a specified Autonomous Exadata Infrastructure.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CreateAutonomousContainerDatabaseDetails is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Body)]
        public CreateAutonomousContainerDatabaseDetails CreateAutonomousContainerDatabaseDetails { get; set; }
        
        /// <value>
        /// A token that uniquely identifies a request so it can be retried in case of a timeout or
        /// server error without risk of executing that same action again. Retry tokens expire after 24
        /// hours, but can be invalidated before then due to conflicting operations (for example, if a resource
        /// has been deleted and purged from the system, then a retry of the original creation request
        /// may be rejected).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-retry-token")]
        public string OpcRetryToken { get; set; }
    }
}
