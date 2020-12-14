/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.KeymanagementService.Models;

namespace Oci.KeymanagementService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/keymanagement/ListKeys.cs.html">here</a> to see an example of how to use ListKeys request.
    /// </example>
    public class ListKeysRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The OCID of the compartment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The maximum number of items to return in a paginated \"List\" call.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "limit")]
        public System.Nullable<int> Limit { get; set; }
        
        /// <value>
        /// The value of the `opc-next-page` response header
        /// from the previous \"List\" call.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "page")]
        public string Page { get; set; }
        
        /// <value>
        /// Unique identifier for the request. If provided, the returned request ID
        /// will include this value. Otherwise, a random request ID will be
        /// generated by the service.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
        
        ///
        /// <value>
        /// The field to sort by. You can specify only one sort order. The default
        /// order for `TIMECREATED` is descending. The default order for `DISPLAYNAME`
        /// is ascending.
        /// 
        /// </value>
        ///
        public enum SortByEnum {
            [EnumMember(Value = "TIMECREATED")]
            Timecreated,
            [EnumMember(Value = "DISPLAYNAME")]
            Displayname
        };

        /// <value>
        /// The field to sort by. You can specify only one sort order. The default
        /// order for `TIMECREATED` is descending. The default order for `DISPLAYNAME`
        /// is ascending.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortBy")]
        public System.Nullable<SortByEnum> SortBy { get; set; }
        
        ///
        /// <value>
        /// The sort order to use, either ascending (`ASC`) or descending (`DESC`).
        /// 
        /// </value>
        ///
        public enum SortOrderEnum {
            [EnumMember(Value = "ASC")]
            Asc,
            [EnumMember(Value = "DESC")]
            Desc
        };

        /// <value>
        /// The sort order to use, either ascending (`ASC`) or descending (`DESC`).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortOrder")]
        public System.Nullable<SortOrderEnum> SortOrder { get; set; }
        
        ///
        /// <value>
        /// A key's protection mode indicates how the key persists and where cryptographic operations that use the key are performed. A 
        /// protection mode of `HSM` means that the key persists on a hardware security module (HSM) and all cryptographic operations are 
        /// performed inside the HSM. A protection mode of `SOFTWARE` means that the key persists on the server, protected by the vault's 
        /// RSA wrapping key which persists on the HSM. All cryptographic operations that use a key with a protection mode of 
        /// `SOFTWARE` are performed on the server.
        /// 
        /// </value>
        ///
        public enum ProtectionModeEnum {
            [EnumMember(Value = "HSM")]
            Hsm,
            [EnumMember(Value = "SOFTWARE")]
            Software
        };

        /// <value>
        /// A key's protection mode indicates how the key persists and where cryptographic operations that use the key are performed. A 
        /// protection mode of `HSM` means that the key persists on a hardware security module (HSM) and all cryptographic operations are 
        /// performed inside the HSM. A protection mode of `SOFTWARE` means that the key persists on the server, protected by the vault's 
        /// RSA wrapping key which persists on the HSM. All cryptographic operations that use a key with a protection mode of 
        /// `SOFTWARE` are performed on the server.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "protectionMode")]
        public System.Nullable<ProtectionModeEnum> ProtectionMode { get; set; }
        
        ///
        /// <value>
        /// The algorithm used by a key's key versions to encrypt or decrypt. Currently, only AES is supported.
        /// 
        /// </value>
        ///
        public enum AlgorithmEnum {
            [EnumMember(Value = "AES")]
            Aes
        };

        /// <value>
        /// The algorithm used by a key's key versions to encrypt or decrypt. Currently, only AES is supported.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "algorithm")]
        public System.Nullable<AlgorithmEnum> Algorithm { get; set; }
        
        /// <value>
        /// The length of the key in bytes, expressed as an integer. Values of 16, 24, or 32 are supported.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "length")]
        public System.Nullable<int> Length { get; set; }
    }
}
