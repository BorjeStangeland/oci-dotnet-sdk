/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.DnsService.Models;

namespace Oci.DnsService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/dns/ListSteeringPolicyAttachments.cs.html">here</a> to see an example of how to use ListSteeringPolicyAttachments request.
    /// </example>
    public class ListSteeringPolicyAttachmentsRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The OCID of the compartment the resource belongs to.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Unique Oracle-assigned identifier for the request. If you need
        /// to contact Oracle about a particular request, please provide
        /// the request ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
        
        /// <value>
        /// The maximum number of items to return in a page of the collection.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "limit")]
        public System.Nullable<long> Limit { get; set; }
        
        /// <value>
        /// The value of the `opc-next-page` response header from the previous \"List\" call.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "page")]
        public string Page { get; set; }
        
        /// <value>
        /// The OCID of a resource.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The displayName of a resource.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Search by steering policy OCID.
        /// Will match any resource whose steering policy ID matches the provided value.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "steeringPolicyId")]
        public string SteeringPolicyId { get; set; }
        
        /// <value>
        /// Search by zone OCID.
        /// Will match any resource whose zone ID matches the provided value.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "zoneId")]
        public string ZoneId { get; set; }
        
        /// <value>
        /// Search by domain.
        /// Will match any record whose domain (case-insensitive) equals the provided value.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "domain")]
        public string Domain { get; set; }
        
        /// <value>
        /// Search by domain.
        /// Will match any record whose domain (case-insensitive) contains the provided value.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "domainContains")]
        public string DomainContains { get; set; }
        
        /// <value>
        /// An [RFC 3339](https://www.ietf.org/rfc/rfc3339.txt) timestamp that states
        /// all returned resources were created on or after the indicated time.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "timeCreatedGreaterThanOrEqualTo")]
        public System.Nullable<System.DateTime> TimeCreatedGreaterThanOrEqualTo { get; set; }
        
        /// <value>
        /// An [RFC 3339](https://www.ietf.org/rfc/rfc3339.txt) timestamp that states
        /// all returned resources were created before the indicated time.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "timeCreatedLessThan")]
        public System.Nullable<System.DateTime> TimeCreatedLessThan { get; set; }
        
        /// <value>
        /// The state of a resource.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "lifecycleState")]
        public System.Nullable<SteeringPolicyAttachmentSummary.LifecycleStateEnum> LifecycleState { get; set; }
        
        ///
        /// <value>
        /// The field by which to sort steering policy attachments. If unspecified, defaults to `timeCreated`.
        /// </value>
        ///
        public enum SortByEnum {
            [EnumMember(Value = "displayName")]
            DisplayName,
            [EnumMember(Value = "timeCreated")]
            TimeCreated,
            [EnumMember(Value = "domainName")]
            DomainName
        };

        /// <value>
        /// The field by which to sort steering policy attachments. If unspecified, defaults to `timeCreated`.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortBy")]
        public System.Nullable<SortByEnum> SortBy { get; set; }
        
        /// <value>
        /// The order to sort the resources.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortOrder")]
        public System.Nullable<SortOrder> SortOrder { get; set; }
        
        /// <value>
        /// Specifies to operate only on resources that have a matching DNS scope.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "scope")]
        public System.Nullable<Scope> Scope { get; set; }
    }
}
