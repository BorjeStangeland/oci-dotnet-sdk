/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.

using System.Linq;
using Oci.Common.Waiters;
using Oci.StackmonitoringService.Models;
using Oci.StackmonitoringService.Requests;
using Oci.StackmonitoringService.Responses;

namespace Oci.StackmonitoringService
{
    /// <summary>
    /// Contains collection of helper methods to produce Oci.Common.Waiters for different resources of StackMonitoring.
    /// </summary>
    public class StackMonitoringWaiters
    {
        private readonly StackMonitoringClient client;

        public  StackMonitoringWaiters(StackMonitoringClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetDiscoveryJobRequest, GetDiscoveryJobResponse> ForDiscoveryJob(GetDiscoveryJobRequest request, params LifecycleState[] targetStates)
        {
            return this.ForDiscoveryJob(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetDiscoveryJobRequest, GetDiscoveryJobResponse> ForDiscoveryJob(GetDiscoveryJobRequest request, WaiterConfiguration config, params LifecycleState[] targetStates)
        {
            var agent = new WaiterAgent<GetDiscoveryJobRequest, GetDiscoveryJobResponse>(
                request,
                request => client.GetDiscoveryJob(request),
                response => targetStates.Contains(response.DiscoveryJob.LifecycleState.Value),
                targetStates.Contains(LifecycleState.Deleted)
            );
            return new Waiter<GetDiscoveryJobRequest, GetDiscoveryJobResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetMonitoredResourceRequest, GetMonitoredResourceResponse> ForMonitoredResource(GetMonitoredResourceRequest request, params ResourceLifecycleState[] targetStates)
        {
            return this.ForMonitoredResource(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetMonitoredResourceRequest, GetMonitoredResourceResponse> ForMonitoredResource(GetMonitoredResourceRequest request, WaiterConfiguration config, params ResourceLifecycleState[] targetStates)
        {
            var agent = new WaiterAgent<GetMonitoredResourceRequest, GetMonitoredResourceResponse>(
                request,
                request => client.GetMonitoredResource(request),
                response => targetStates.Contains(response.MonitoredResource.LifecycleState.Value),
                targetStates.Contains(ResourceLifecycleState.Deleted)
            );
            return new Waiter<GetMonitoredResourceRequest, GetMonitoredResourceResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetWorkRequestRequest, GetWorkRequestResponse> ForWorkRequest(GetWorkRequestRequest request, params OperationStatus[] targetStates)
        {
            return this.ForWorkRequest(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetWorkRequestRequest, GetWorkRequestResponse> ForWorkRequest(GetWorkRequestRequest request, WaiterConfiguration config, params OperationStatus[] targetStates)
        {
            var agent = new WaiterAgent<GetWorkRequestRequest, GetWorkRequestResponse>(
                request,
                request => client.GetWorkRequest(request),
                response => targetStates.Contains(response.WorkRequest.Status.Value)
            );
            return new Waiter<GetWorkRequestRequest, GetWorkRequestResponse>(config, agent);
        }
    }
}
