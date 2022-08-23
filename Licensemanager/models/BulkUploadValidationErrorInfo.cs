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


namespace Oci.LicensemanagerService.Models
{
    /// <summary>
    /// Detailed error information corresponding to each column for a particular supported license record that could not be uploaded.
    /// </summary>
    public class BulkUploadValidationErrorInfo 
    {
        
        /// <value>
        /// Refers to the license record number as provided in the bulk upload file.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RowNumber is required.")]
        [JsonProperty(PropertyName = "rowNumber")]
        public System.Nullable<int> RowNumber { get; set; }
        
        /// <value>
        /// Product name of invalid row.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ProductName is required.")]
        [JsonProperty(PropertyName = "productName")]
        public string ProductName { get; set; }
        
        /// <value>
        /// Error information corresponding to each column.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RowError is required.")]
        [JsonProperty(PropertyName = "rowError")]
        public System.Collections.Generic.List<BulkUploadCellInfo> RowError { get; set; }
        
    }
}