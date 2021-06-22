/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.

using System.Linq;
using Oci.Common.Waiters;
using Oci.ServicecatalogService.Models;
using Oci.ServicecatalogService.Requests;
using Oci.ServicecatalogService.Responses;

namespace Oci.ServicecatalogService
{
    /// <summary>
    /// Contains collection of helper methods to produce Oci.Common.Waiters for different resources of ServiceCatalog.
    /// </summary>
    public class ServiceCatalogWaiters
    {
        private readonly ServiceCatalogClient client;

        public  ServiceCatalogWaiters(ServiceCatalogClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetPrivateApplicationRequest, GetPrivateApplicationResponse> ForPrivateApplication(GetPrivateApplicationRequest request, params PrivateApplication.LifecycleStateEnum[] targetStates)
        {
            return this.ForPrivateApplication(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetPrivateApplicationRequest, GetPrivateApplicationResponse> ForPrivateApplication(GetPrivateApplicationRequest request, WaiterConfiguration config, params PrivateApplication.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetPrivateApplicationRequest, GetPrivateApplicationResponse>(
                request,
                request => client.GetPrivateApplication(request),
                response => targetStates.Contains(response.PrivateApplication.LifecycleState.Value),
                targetStates.Contains(PrivateApplication.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetPrivateApplicationRequest, GetPrivateApplicationResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetServiceCatalogRequest, GetServiceCatalogResponse> ForServiceCatalog(GetServiceCatalogRequest request, params ServiceCatalog.LifecycleStateEnum[] targetStates)
        {
            return this.ForServiceCatalog(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetServiceCatalogRequest, GetServiceCatalogResponse> ForServiceCatalog(GetServiceCatalogRequest request, WaiterConfiguration config, params ServiceCatalog.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetServiceCatalogRequest, GetServiceCatalogResponse>(
                request,
                request => client.GetServiceCatalog(request),
                response => targetStates.Contains(response.ServiceCatalog.LifecycleState.Value),
                targetStates.Contains(ServiceCatalog.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetServiceCatalogRequest, GetServiceCatalogResponse>(config, agent);
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