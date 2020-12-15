/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.

using System.Linq;
using Oci.Common.Waiters;
using Oci.RoverService.Models;
using Oci.RoverService.Requests;
using Oci.RoverService.Responses;

namespace Oci.RoverService
{
    /// <summary>
    /// Contains collection of helper methods to produce Oci.Common.Waiters for different resources of RoverEntitlement.
    /// </summary>
    public class RoverEntitlementWaiters
    {
        private readonly RoverEntitlementClient client;

        public  RoverEntitlementWaiters(RoverEntitlementClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetRoverEntitlementRequest, GetRoverEntitlementResponse> ForRoverEntitlement(GetRoverEntitlementRequest request, params RoverEntitlement.LifecycleStateEnum[] targetStates)
        {
            return this.ForRoverEntitlement(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetRoverEntitlementRequest, GetRoverEntitlementResponse> ForRoverEntitlement(GetRoverEntitlementRequest request, WaiterConfiguration config, params RoverEntitlement.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetRoverEntitlementRequest, GetRoverEntitlementResponse>(
                request,
                request => client.GetRoverEntitlement(request),
                response => targetStates.Contains(response.RoverEntitlement.LifecycleState.Value),
                targetStates.Contains(RoverEntitlement.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetRoverEntitlementRequest, GetRoverEntitlementResponse>(config, agent);
        }
    }
}
