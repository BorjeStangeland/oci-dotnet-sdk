/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.DatabasemanagementService.Models
{
    /// <summary>
    /// The Managed Database on which the job is executed.
    /// </summary>
    public class JobDatabase 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Managed Database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The name of the Managed Database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The type of Oracle Database installation.
        /// </value>
        [JsonProperty(PropertyName = "databaseType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<DatabaseType> DatabaseType { get; set; }
        
        /// <value>
        /// The subtype of the Oracle Database. Indicates whether the database is a Container Database, Pluggable Database, or a Non-container Database.
        /// </value>
        [JsonProperty(PropertyName = "databaseSubType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<DatabaseSubType> DatabaseSubType { get; set; }
        
        /// <value>
        /// A list of the supported infrastructure that can be used to deploy the database.
        /// </value>
        [JsonProperty(PropertyName = "deploymentType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<DeploymentType> DeploymentType { get; set; }
        
        /// <value>
        /// Indicates whether the Oracle Database is part of a cluster.
        /// </value>
        [JsonProperty(PropertyName = "isCluster")]
        public System.Nullable<bool> IsCluster { get; set; }
        
    }
}
