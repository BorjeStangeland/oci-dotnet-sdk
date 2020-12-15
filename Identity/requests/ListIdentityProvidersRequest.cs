/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.IdentityService.Models;

namespace Oci.IdentityService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/identity/ListIdentityProviders.cs.html">here</a> to see an example of how to use ListIdentityProviders request.
    /// </example>
    public class ListIdentityProvidersRequest : Oci.Common.IOciRequest
    {
        
        ///
        /// <value>
        /// The protocol used for federation.
        /// </value>
        ///
        public enum ProtocolEnum {
            [EnumMember(Value = "SAML2")]
            Saml2
        };

        /// <value>
        /// The protocol used for federation.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Protocol is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "protocol")]
        public System.Nullable<ProtocolEnum> Protocol { get; set; }
        
        /// <value>
        /// The OCID of the compartment (remember that the tenancy is simply the root compartment).
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The value of the `opc-next-page` response header from the previous \"List\" call.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "page")]
        public string Page { get; set; }
        
        /// <value>
        /// The maximum number of items to return in a paginated \"List\" call.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "limit")]
        public System.Nullable<int> Limit { get; set; }
        
        /// <value>
        /// A filter to only return resources that match the given name exactly.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "name")]
        public string Name { get; set; }
        
        ///
        /// <value>
        /// The field to sort by. You can provide one sort order (`sortOrder`). Default order for
        /// TIMECREATED is descending. Default order for NAME is ascending. The NAME
        /// sort order is case sensitive.
        /// <br/>
        /// **Note:** In general, some \"List\" operations (for example, `ListInstances`) let you
        /// optionally filter by Availability Domain if the scope of the resource type is within a
        /// single Availability Domain. If you call one of these \"List\" operations without specifying
        /// an Availability Domain, the resources are grouped by Availability Domain, then sorted.
        /// 
        /// </value>
        ///
        public enum SortByEnum {
            [EnumMember(Value = "TIMECREATED")]
            Timecreated,
            [EnumMember(Value = "NAME")]
            Name
        };

        /// <value>
        /// The field to sort by. You can provide one sort order (`sortOrder`). Default order for
        /// TIMECREATED is descending. Default order for NAME is ascending. The NAME
        /// sort order is case sensitive.
        /// <br/>
        /// **Note:** In general, some \"List\" operations (for example, `ListInstances`) let you
        /// optionally filter by Availability Domain if the scope of the resource type is within a
        /// single Availability Domain. If you call one of these \"List\" operations without specifying
        /// an Availability Domain, the resources are grouped by Availability Domain, then sorted.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortBy")]
        public System.Nullable<SortByEnum> SortBy { get; set; }
        
        ///
        /// <value>
        /// The sort order to use, either ascending (`ASC`) or descending (`DESC`). The NAME sort order
        /// is case sensitive.
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
        /// The sort order to use, either ascending (`ASC`) or descending (`DESC`). The NAME sort order
        /// is case sensitive.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortOrder")]
        public System.Nullable<SortOrderEnum> SortOrder { get; set; }
        
        /// <value>
        /// A filter to only return resources that match the given lifecycle state.  The state value is case-insensitive.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "lifecycleState")]
        public System.Nullable<IdentityProvider.LifecycleStateEnum> LifecycleState { get; set; }
    }
}
