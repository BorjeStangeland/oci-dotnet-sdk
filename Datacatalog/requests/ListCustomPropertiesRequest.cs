/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.DatacatalogService.Models;

namespace Oci.DatacatalogService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/datacatalog/ListCustomProperties.cs.html">here</a> to see an example of how to use ListCustomProperties request.
    /// </example>
    public class ListCustomPropertiesRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// Unique catalog identifier.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CatalogId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "catalogId")]
        public string CatalogId { get; set; }
        
        /// <value>
        /// Unique namespace identifier.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "NamespaceId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "namespaceId")]
        public string NamespaceId { get; set; }
        
        /// <value>
        /// A filter to return only resources that match the entire display name given. The match is not case sensitive.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// A filter to return only resources that match display name pattern given. The match is not case sensitive.
        /// For Example : /folders?displayNameContains=Cu.*
        /// The above would match all folders with display name that starts with \"Cu\".
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "displayNameContains")]
        public string DisplayNameContains { get; set; }
        
        /// <value>
        /// Return the custom properties which has specified data types
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "dataTypes")]
        public System.Collections.Generic.List<CustomPropertyDataType> DataTypes { get; set; }
        
        ///
        /// <value>
        /// A filter to return only resources that match the entire type name given. The match is not case sensitive
        /// </value>
        ///
        public enum TypeNameEnum {
            [EnumMember(Value = "DATA_ASSET")]
            DataAsset,
            [EnumMember(Value = "AUTONOMOUS_DATA_WAREHOUSE")]
            AutonomousDataWarehouse,
            [EnumMember(Value = "HIVE")]
            Hive,
            [EnumMember(Value = "KAFKA")]
            Kafka,
            [EnumMember(Value = "MYSQL")]
            Mysql,
            [EnumMember(Value = "ORACLE_OBJECT_STORAGE")]
            OracleObjectStorage,
            [EnumMember(Value = "AUTONOMOUS_TRANSACTION_PROCESSING")]
            AutonomousTransactionProcessing,
            [EnumMember(Value = "ORACLE")]
            Oracle,
            [EnumMember(Value = "POSTGRESQL")]
            Postgresql,
            [EnumMember(Value = "MICROSOFT_AZURE_SQL_DATABASE")]
            MicrosoftAzureSqlDatabase,
            [EnumMember(Value = "MICROSOFT_SQL_SERVER")]
            MicrosoftSqlServer,
            [EnumMember(Value = "IBM_DB2")]
            IbmDb2,
            [EnumMember(Value = "DATA_ENTITY")]
            DataEntity,
            [EnumMember(Value = "LOGICAL_ENTITY")]
            LogicalEntity,
            [EnumMember(Value = "TABLE")]
            Table,
            [EnumMember(Value = "VIEW")]
            View,
            [EnumMember(Value = "ATTRIBUTE")]
            Attribute,
            [EnumMember(Value = "FOLDER")]
            Folder,
            [EnumMember(Value = "CONNECTION")]
            Connection,
            [EnumMember(Value = "GLOSSARY")]
            Glossary,
            [EnumMember(Value = "TERM")]
            Term,
            [EnumMember(Value = "CATEGORY")]
            Category,
            [EnumMember(Value = "FILE")]
            File,
            [EnumMember(Value = "BUCKET")]
            Bucket,
            [EnumMember(Value = "MESSAGE")]
            Message,
            [EnumMember(Value = "UNRECOGNIZED_FILE")]
            UnrecognizedFile
        };

        /// <value>
        /// A filter to return only resources that match the entire type name given. The match is not case sensitive
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "typeName")]
        public System.Collections.Generic.List<TypeNameEnum> TypeName { get; set; }
        
        /// <value>
        /// A filter to return only resources that match the specified lifecycle state. The value is case insensitive.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "lifecycleState")]
        public System.Nullable<LifecycleState> LifecycleState { get; set; }
        
        /// <value>
        /// Time that the resource was created. An [RFC3339](https://tools.ietf.org/html/rfc3339) formatted datetime string.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// Time that the resource was updated. An [RFC3339](https://tools.ietf.org/html/rfc3339) formatted datetime string.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// OCID of the user who created the resource.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "createdById")]
        public string CreatedById { get; set; }
        
        /// <value>
        /// OCID of the user who updated the resource.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "updatedById")]
        public string UpdatedById { get; set; }
        
        ///
        /// <value>
        /// Specifies the fields to return in a custom property summary response.
        /// 
        /// </value>
        ///
        public enum FieldsEnum {
            [EnumMember(Value = "key")]
            Key,
            [EnumMember(Value = "displayName")]
            DisplayName,
            [EnumMember(Value = "description")]
            Description,
            [EnumMember(Value = "dataType")]
            DataType,
            [EnumMember(Value = "namespaceName")]
            NamespaceName,
            [EnumMember(Value = "lifecycleState")]
            LifecycleState,
            [EnumMember(Value = "timeCreated")]
            TimeCreated
        };

        /// <value>
        /// Specifies the fields to return in a custom property summary response.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "fields")]
        public System.Collections.Generic.List<FieldsEnum> Fields { get; set; }
        
        ///
        /// <value>
        /// The sort order to use, either 'asc' or 'desc'.
        /// </value>
        ///
        public enum SortOrderEnum {
            [EnumMember(Value = "ASC")]
            Asc,
            [EnumMember(Value = "DESC")]
            Desc
        };

        /// <value>
        /// The sort order to use, either 'asc' or 'desc'.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortOrder")]
        public System.Nullable<SortOrderEnum> SortOrder { get; set; }
        
        ///
        /// <value>
        /// The field to sort by. Only one sort order may be provided. Default order for USAGECOUNT and DISPLAYNAME is Ascending
        /// 
        /// </value>
        ///
        public enum SortByEnum {
            [EnumMember(Value = "DISPLAYNAME")]
            Displayname,
            [EnumMember(Value = "USAGECOUNT")]
            Usagecount
        };

        /// <value>
        /// The field to sort by. Only one sort order may be provided. Default order for USAGECOUNT and DISPLAYNAME is Ascending
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortBy")]
        public System.Nullable<SortByEnum> SortBy { get; set; }
        
        /// <value>
        /// The maximum number of items to return.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "limit")]
        public System.Nullable<int> Limit { get; set; }
        
        /// <value>
        /// The page token representing the page at which to start retrieving results. This is usually retrieved from a previous list call.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "page")]
        public string Page { get; set; }
        
        /// <value>
        /// The client request ID for tracing.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
    }
}
