/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.DatasafeService.Models
{
    /// <summary>
    /// Details of a column in a table fetched from the database.
    /// </summary>
    public class ColumnSummary 
    {
        
        /// <value>
        /// Name of the column.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ColumnName is required.")]
        [JsonProperty(PropertyName = "columnName")]
        public string ColumnName { get; set; }
        
        /// <value>
        /// Data type of the column.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DataType is required.")]
        [JsonProperty(PropertyName = "dataType")]
        public string DataType { get; set; }
        
        /// <value>
        /// Length of the data represented by the column.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Length is required.")]
        [JsonProperty(PropertyName = "length")]
        public System.Nullable<long> Length { get; set; }
        
        /// <value>
        /// Precision of the column.
        /// </value>
        [JsonProperty(PropertyName = "precision")]
        public System.Nullable<int> Precision { get; set; }
        
        /// <value>
        /// Scale of the column.
        /// </value>
        [JsonProperty(PropertyName = "scale")]
        public System.Nullable<int> Scale { get; set; }
        
        /// <value>
        /// Character length.
        /// </value>
        [JsonProperty(PropertyName = "characterLength")]
        public System.Nullable<int> CharacterLength { get; set; }
        
        /// <value>
        /// Name of the table.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TableName is required.")]
        [JsonProperty(PropertyName = "tableName")]
        public string TableName { get; set; }
        
        /// <value>
        /// Name of the schema.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SchemaName is required.")]
        [JsonProperty(PropertyName = "schemaName")]
        public string SchemaName { get; set; }
        
    }
}