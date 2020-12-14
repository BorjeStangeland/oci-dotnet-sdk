/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Oci.Common;
using Oci.Common.Auth;
using Oci.Common.Retry;
using Oci.OceService.Requests;
using Oci.OceService.Responses;

namespace Oci.OceService
{
    /// <summary>Service client instance for OceInstance.</summary>
    public class OceInstanceClient : RegionalClientBase
    {
        private readonly RetryConfiguration retryConfiguration;
        private const string basePathWithoutHost = "/20190912";

        public OceInstancePaginators Paginators { get; }

        public OceInstanceWaiters Waiters { get; }

        /// <summary>
        /// Creates a new service instance using the given authentication provider and/or client configuration and/or endpoint.
        /// A client configuration can also be provided optionally to adjust REST client behaviors.
        /// </summary>
        /// <param name="authenticationDetailsProvider">The authentication details provider. Required.</param>
        /// <param name="clientConfiguration">The client configuration that contains settings to adjust REST client behaviors. Optional.</param>
        /// <param name="endpoint">The endpoint of the service. If not provided and the client is a regional client, the endpoint will be constructed based on region information. Optional.</param>
        public OceInstanceClient(IBasicAuthenticationDetailsProvider authenticationDetailsProvider, ClientConfiguration clientConfiguration = null, string endpoint = null)
            : base(authenticationDetailsProvider, clientConfiguration)
        {
            service = new Service
            {
                ServiceName = "OCEINSTANCE",
                ServiceEndpointPrefix = "",
                ServiceEndpointTemplate = "https://cp.oce.{region}.ocp.{secondLevelDomain}"
            };

            ClientConfiguration clientConfigurationToUse = clientConfiguration ?? new ClientConfiguration();

            if (authenticationDetailsProvider is IRegionProvider)
            {
                // Use region from Authentication details provider.
                SetRegion(((IRegionProvider)authenticationDetailsProvider).Region);
            }

            if (endpoint != null)
            {
                logger.Info($"Using endpoint specified \"{endpoint}\".");
                SetEndpoint(endpoint);
            }

            this.retryConfiguration = clientConfigurationToUse.RetryConfiguration;
            Paginators = new OceInstancePaginators(this);
            Waiters = new OceInstanceWaiters(this);
        }

        /// <summary>
        /// Moves a OceInstance into a different compartment
        /// </summary>
        /// <param name="request">The request object containing the details to send. Required.</param>
        /// <param name="retryConfiguration">The retry configuration that will be used by to send this request. Optional.</param>
        /// <param name="cancellationToken">The cancellation token to cancel this operation. Optional.</param>
        /// <returns>A response object containing details about the completed operation</returns>
        /// <example>Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/oce/ChangeOceInstanceCompartment.cs.html">here</a> to see an example of how to use ChangeOceInstanceCompartment API.</example>
        public async Task<ChangeOceInstanceCompartmentResponse> ChangeOceInstanceCompartment(ChangeOceInstanceCompartmentRequest request, RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            logger.Trace("Called changeOceInstanceCompartment");
            Uri uri = new Uri(this.restClient.GetEndpoint(), System.IO.Path.Combine(basePathWithoutHost, "/oceInstances/{oceInstanceId}/actions/changeCompartment".Trim('/')));
            HttpMethod method = new HttpMethod("POST");
            HttpRequestMessage requestMessage = Converter.ToHttpRequestMessage(uri, method, request);
            requestMessage.Headers.Add("Accept", "application/json");
            GenericRetrier retryingClient = Retrier.GetPreferredRetrier(retryConfiguration, this.retryConfiguration);
            HttpResponseMessage responseMessage;

            try
            {
                if (retryingClient != null)
                {
                    responseMessage = await retryingClient.MakeRetryingCall(this.restClient.HttpSend, requestMessage, cancellationToken).ConfigureAwait(false);
                }
                else
                {
                    responseMessage = await this.restClient.HttpSend(requestMessage).ConfigureAwait(false);
                }
                this.restClient.CheckHttpResponseMessage(requestMessage, responseMessage);

                return Converter.FromHttpResponseMessage<ChangeOceInstanceCompartmentResponse>(responseMessage);
            }
            catch (Exception e)
            {
                logger.Error($"ChangeOceInstanceCompartment failed with error: {e.Message}");
                throw;
            }
        }

        /// <summary>
        /// Creates a new OceInstance.
        /// 
        /// </summary>
        /// <param name="request">The request object containing the details to send. Required.</param>
        /// <param name="retryConfiguration">The retry configuration that will be used by to send this request. Optional.</param>
        /// <param name="cancellationToken">The cancellation token to cancel this operation. Optional.</param>
        /// <returns>A response object containing details about the completed operation</returns>
        /// <example>Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/oce/CreateOceInstance.cs.html">here</a> to see an example of how to use CreateOceInstance API.</example>
        public async Task<CreateOceInstanceResponse> CreateOceInstance(CreateOceInstanceRequest request, RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            logger.Trace("Called createOceInstance");
            Uri uri = new Uri(this.restClient.GetEndpoint(), System.IO.Path.Combine(basePathWithoutHost, "/oceInstances".Trim('/')));
            HttpMethod method = new HttpMethod("POST");
            HttpRequestMessage requestMessage = Converter.ToHttpRequestMessage(uri, method, request);
            requestMessage.Headers.Add("Accept", "application/json");
            GenericRetrier retryingClient = Retrier.GetPreferredRetrier(retryConfiguration, this.retryConfiguration);
            HttpResponseMessage responseMessage;

            try
            {
                if (retryingClient != null)
                {
                    responseMessage = await retryingClient.MakeRetryingCall(this.restClient.HttpSend, requestMessage, cancellationToken).ConfigureAwait(false);
                }
                else
                {
                    responseMessage = await this.restClient.HttpSend(requestMessage).ConfigureAwait(false);
                }
                this.restClient.CheckHttpResponseMessage(requestMessage, responseMessage);

                return Converter.FromHttpResponseMessage<CreateOceInstanceResponse>(responseMessage);
            }
            catch (Exception e)
            {
                logger.Error($"CreateOceInstance failed with error: {e.Message}");
                throw;
            }
        }

        /// <summary>
        /// Deletes a OceInstance resource by identifier
        /// </summary>
        /// <param name="request">The request object containing the details to send. Required.</param>
        /// <param name="retryConfiguration">The retry configuration that will be used by to send this request. Optional.</param>
        /// <param name="cancellationToken">The cancellation token to cancel this operation. Optional.</param>
        /// <returns>A response object containing details about the completed operation</returns>
        /// <example>Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/oce/DeleteOceInstance.cs.html">here</a> to see an example of how to use DeleteOceInstance API.</example>
        public async Task<DeleteOceInstanceResponse> DeleteOceInstance(DeleteOceInstanceRequest request, RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            logger.Trace("Called deleteOceInstance");
            Uri uri = new Uri(this.restClient.GetEndpoint(), System.IO.Path.Combine(basePathWithoutHost, "/oceInstances/{oceInstanceId}".Trim('/')));
            HttpMethod method = new HttpMethod("DELETE");
            HttpRequestMessage requestMessage = Converter.ToHttpRequestMessage(uri, method, request);
            requestMessage.Headers.Add("Accept", "application/json");
            GenericRetrier retryingClient = Retrier.GetPreferredRetrier(retryConfiguration, this.retryConfiguration);
            HttpResponseMessage responseMessage;

            try
            {
                if (retryingClient != null)
                {
                    responseMessage = await retryingClient.MakeRetryingCall(this.restClient.HttpSend, requestMessage, cancellationToken).ConfigureAwait(false);
                }
                else
                {
                    responseMessage = await this.restClient.HttpSend(requestMessage).ConfigureAwait(false);
                }
                this.restClient.CheckHttpResponseMessage(requestMessage, responseMessage);

                return Converter.FromHttpResponseMessage<DeleteOceInstanceResponse>(responseMessage);
            }
            catch (Exception e)
            {
                logger.Error($"DeleteOceInstance failed with error: {e.Message}");
                throw;
            }
        }

        /// <summary>
        /// Gets a OceInstance by identifier
        /// </summary>
        /// <param name="request">The request object containing the details to send. Required.</param>
        /// <param name="retryConfiguration">The retry configuration that will be used by to send this request. Optional.</param>
        /// <param name="cancellationToken">The cancellation token to cancel this operation. Optional.</param>
        /// <returns>A response object containing details about the completed operation</returns>
        /// <example>Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/oce/GetOceInstance.cs.html">here</a> to see an example of how to use GetOceInstance API.</example>
        public async Task<GetOceInstanceResponse> GetOceInstance(GetOceInstanceRequest request, RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            logger.Trace("Called getOceInstance");
            Uri uri = new Uri(this.restClient.GetEndpoint(), System.IO.Path.Combine(basePathWithoutHost, "/oceInstances/{oceInstanceId}".Trim('/')));
            HttpMethod method = new HttpMethod("GET");
            HttpRequestMessage requestMessage = Converter.ToHttpRequestMessage(uri, method, request);
            requestMessage.Headers.Add("Accept", "application/json");
            GenericRetrier retryingClient = Retrier.GetPreferredRetrier(retryConfiguration, this.retryConfiguration);
            HttpResponseMessage responseMessage;

            try
            {
                if (retryingClient != null)
                {
                    responseMessage = await retryingClient.MakeRetryingCall(this.restClient.HttpSend, requestMessage, cancellationToken).ConfigureAwait(false);
                }
                else
                {
                    responseMessage = await this.restClient.HttpSend(requestMessage).ConfigureAwait(false);
                }
                this.restClient.CheckHttpResponseMessage(requestMessage, responseMessage);

                return Converter.FromHttpResponseMessage<GetOceInstanceResponse>(responseMessage);
            }
            catch (Exception e)
            {
                logger.Error($"GetOceInstance failed with error: {e.Message}");
                throw;
            }
        }

        /// <summary>
        /// Gets the status of the work request with the given ID.
        /// </summary>
        /// <param name="request">The request object containing the details to send. Required.</param>
        /// <param name="retryConfiguration">The retry configuration that will be used by to send this request. Optional.</param>
        /// <param name="cancellationToken">The cancellation token to cancel this operation. Optional.</param>
        /// <returns>A response object containing details about the completed operation</returns>
        /// <example>Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/oce/GetWorkRequest.cs.html">here</a> to see an example of how to use GetWorkRequest API.</example>
        public async Task<GetWorkRequestResponse> GetWorkRequest(GetWorkRequestRequest request, RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            logger.Trace("Called getWorkRequest");
            Uri uri = new Uri(this.restClient.GetEndpoint(), System.IO.Path.Combine(basePathWithoutHost, "/workRequests/{workRequestId}".Trim('/')));
            HttpMethod method = new HttpMethod("GET");
            HttpRequestMessage requestMessage = Converter.ToHttpRequestMessage(uri, method, request);
            requestMessage.Headers.Add("Accept", "application/json");
            GenericRetrier retryingClient = Retrier.GetPreferredRetrier(retryConfiguration, this.retryConfiguration);
            HttpResponseMessage responseMessage;

            try
            {
                if (retryingClient != null)
                {
                    responseMessage = await retryingClient.MakeRetryingCall(this.restClient.HttpSend, requestMessage, cancellationToken).ConfigureAwait(false);
                }
                else
                {
                    responseMessage = await this.restClient.HttpSend(requestMessage).ConfigureAwait(false);
                }
                this.restClient.CheckHttpResponseMessage(requestMessage, responseMessage);

                return Converter.FromHttpResponseMessage<GetWorkRequestResponse>(responseMessage);
            }
            catch (Exception e)
            {
                logger.Error($"GetWorkRequest failed with error: {e.Message}");
                throw;
            }
        }

        /// <summary>
        /// Returns a list of OceInstances.
        /// 
        /// </summary>
        /// <param name="request">The request object containing the details to send. Required.</param>
        /// <param name="retryConfiguration">The retry configuration that will be used by to send this request. Optional.</param>
        /// <param name="cancellationToken">The cancellation token to cancel this operation. Optional.</param>
        /// <returns>A response object containing details about the completed operation</returns>
        /// <example>Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/oce/ListOceInstances.cs.html">here</a> to see an example of how to use ListOceInstances API.</example>
        public async Task<ListOceInstancesResponse> ListOceInstances(ListOceInstancesRequest request, RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            logger.Trace("Called listOceInstances");
            Uri uri = new Uri(this.restClient.GetEndpoint(), System.IO.Path.Combine(basePathWithoutHost, "/oceInstances".Trim('/')));
            HttpMethod method = new HttpMethod("GET");
            HttpRequestMessage requestMessage = Converter.ToHttpRequestMessage(uri, method, request);
            requestMessage.Headers.Add("Accept", "application/json");
            GenericRetrier retryingClient = Retrier.GetPreferredRetrier(retryConfiguration, this.retryConfiguration);
            HttpResponseMessage responseMessage;

            try
            {
                if (retryingClient != null)
                {
                    responseMessage = await retryingClient.MakeRetryingCall(this.restClient.HttpSend, requestMessage, cancellationToken).ConfigureAwait(false);
                }
                else
                {
                    responseMessage = await this.restClient.HttpSend(requestMessage).ConfigureAwait(false);
                }
                this.restClient.CheckHttpResponseMessage(requestMessage, responseMessage);

                return Converter.FromHttpResponseMessage<ListOceInstancesResponse>(responseMessage);
            }
            catch (Exception e)
            {
                logger.Error($"ListOceInstances failed with error: {e.Message}");
                throw;
            }
        }

        /// <summary>
        /// Return a (paginated) list of errors for a given work request.
        /// 
        /// </summary>
        /// <param name="request">The request object containing the details to send. Required.</param>
        /// <param name="retryConfiguration">The retry configuration that will be used by to send this request. Optional.</param>
        /// <param name="cancellationToken">The cancellation token to cancel this operation. Optional.</param>
        /// <returns>A response object containing details about the completed operation</returns>
        /// <example>Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/oce/ListWorkRequestErrors.cs.html">here</a> to see an example of how to use ListWorkRequestErrors API.</example>
        public async Task<ListWorkRequestErrorsResponse> ListWorkRequestErrors(ListWorkRequestErrorsRequest request, RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            logger.Trace("Called listWorkRequestErrors");
            Uri uri = new Uri(this.restClient.GetEndpoint(), System.IO.Path.Combine(basePathWithoutHost, "/workRequests/{workRequestId}/errors".Trim('/')));
            HttpMethod method = new HttpMethod("GET");
            HttpRequestMessage requestMessage = Converter.ToHttpRequestMessage(uri, method, request);
            requestMessage.Headers.Add("Accept", "application/json");
            GenericRetrier retryingClient = Retrier.GetPreferredRetrier(retryConfiguration, this.retryConfiguration);
            HttpResponseMessage responseMessage;

            try
            {
                if (retryingClient != null)
                {
                    responseMessage = await retryingClient.MakeRetryingCall(this.restClient.HttpSend, requestMessage, cancellationToken).ConfigureAwait(false);
                }
                else
                {
                    responseMessage = await this.restClient.HttpSend(requestMessage).ConfigureAwait(false);
                }
                this.restClient.CheckHttpResponseMessage(requestMessage, responseMessage);

                return Converter.FromHttpResponseMessage<ListWorkRequestErrorsResponse>(responseMessage);
            }
            catch (Exception e)
            {
                logger.Error($"ListWorkRequestErrors failed with error: {e.Message}");
                throw;
            }
        }

        /// <summary>
        /// Return a (paginated) list of logs for a given work request.
        /// 
        /// </summary>
        /// <param name="request">The request object containing the details to send. Required.</param>
        /// <param name="retryConfiguration">The retry configuration that will be used by to send this request. Optional.</param>
        /// <param name="cancellationToken">The cancellation token to cancel this operation. Optional.</param>
        /// <returns>A response object containing details about the completed operation</returns>
        /// <example>Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/oce/ListWorkRequestLogs.cs.html">here</a> to see an example of how to use ListWorkRequestLogs API.</example>
        public async Task<ListWorkRequestLogsResponse> ListWorkRequestLogs(ListWorkRequestLogsRequest request, RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            logger.Trace("Called listWorkRequestLogs");
            Uri uri = new Uri(this.restClient.GetEndpoint(), System.IO.Path.Combine(basePathWithoutHost, "/workRequests/{workRequestId}/logs".Trim('/')));
            HttpMethod method = new HttpMethod("GET");
            HttpRequestMessage requestMessage = Converter.ToHttpRequestMessage(uri, method, request);
            requestMessage.Headers.Add("Accept", "application/json");
            GenericRetrier retryingClient = Retrier.GetPreferredRetrier(retryConfiguration, this.retryConfiguration);
            HttpResponseMessage responseMessage;

            try
            {
                if (retryingClient != null)
                {
                    responseMessage = await retryingClient.MakeRetryingCall(this.restClient.HttpSend, requestMessage, cancellationToken).ConfigureAwait(false);
                }
                else
                {
                    responseMessage = await this.restClient.HttpSend(requestMessage).ConfigureAwait(false);
                }
                this.restClient.CheckHttpResponseMessage(requestMessage, responseMessage);

                return Converter.FromHttpResponseMessage<ListWorkRequestLogsResponse>(responseMessage);
            }
            catch (Exception e)
            {
                logger.Error($"ListWorkRequestLogs failed with error: {e.Message}");
                throw;
            }
        }

        /// <summary>
        /// Lists the work requests in a compartment.
        /// 
        /// </summary>
        /// <param name="request">The request object containing the details to send. Required.</param>
        /// <param name="retryConfiguration">The retry configuration that will be used by to send this request. Optional.</param>
        /// <param name="cancellationToken">The cancellation token to cancel this operation. Optional.</param>
        /// <returns>A response object containing details about the completed operation</returns>
        /// <example>Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/oce/ListWorkRequests.cs.html">here</a> to see an example of how to use ListWorkRequests API.</example>
        public async Task<ListWorkRequestsResponse> ListWorkRequests(ListWorkRequestsRequest request, RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            logger.Trace("Called listWorkRequests");
            Uri uri = new Uri(this.restClient.GetEndpoint(), System.IO.Path.Combine(basePathWithoutHost, "/workRequests".Trim('/')));
            HttpMethod method = new HttpMethod("GET");
            HttpRequestMessage requestMessage = Converter.ToHttpRequestMessage(uri, method, request);
            requestMessage.Headers.Add("Accept", "application/json");
            GenericRetrier retryingClient = Retrier.GetPreferredRetrier(retryConfiguration, this.retryConfiguration);
            HttpResponseMessage responseMessage;

            try
            {
                if (retryingClient != null)
                {
                    responseMessage = await retryingClient.MakeRetryingCall(this.restClient.HttpSend, requestMessage, cancellationToken).ConfigureAwait(false);
                }
                else
                {
                    responseMessage = await this.restClient.HttpSend(requestMessage).ConfigureAwait(false);
                }
                this.restClient.CheckHttpResponseMessage(requestMessage, responseMessage);

                return Converter.FromHttpResponseMessage<ListWorkRequestsResponse>(responseMessage);
            }
            catch (Exception e)
            {
                logger.Error($"ListWorkRequests failed with error: {e.Message}");
                throw;
            }
        }

        /// <summary>
        /// Updates the OceInstance
        /// </summary>
        /// <param name="request">The request object containing the details to send. Required.</param>
        /// <param name="retryConfiguration">The retry configuration that will be used by to send this request. Optional.</param>
        /// <param name="cancellationToken">The cancellation token to cancel this operation. Optional.</param>
        /// <returns>A response object containing details about the completed operation</returns>
        /// <example>Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/oce/UpdateOceInstance.cs.html">here</a> to see an example of how to use UpdateOceInstance API.</example>
        public async Task<UpdateOceInstanceResponse> UpdateOceInstance(UpdateOceInstanceRequest request, RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            logger.Trace("Called updateOceInstance");
            Uri uri = new Uri(this.restClient.GetEndpoint(), System.IO.Path.Combine(basePathWithoutHost, "/oceInstances/{oceInstanceId}".Trim('/')));
            HttpMethod method = new HttpMethod("PUT");
            HttpRequestMessage requestMessage = Converter.ToHttpRequestMessage(uri, method, request);
            requestMessage.Headers.Add("Accept", "application/json");
            GenericRetrier retryingClient = Retrier.GetPreferredRetrier(retryConfiguration, this.retryConfiguration);
            HttpResponseMessage responseMessage;

            try
            {
                if (retryingClient != null)
                {
                    responseMessage = await retryingClient.MakeRetryingCall(this.restClient.HttpSend, requestMessage, cancellationToken).ConfigureAwait(false);
                }
                else
                {
                    responseMessage = await this.restClient.HttpSend(requestMessage).ConfigureAwait(false);
                }
                this.restClient.CheckHttpResponseMessage(requestMessage, responseMessage);

                return Converter.FromHttpResponseMessage<UpdateOceInstanceResponse>(responseMessage);
            }
            catch (Exception e)
            {
                logger.Error($"UpdateOceInstance failed with error: {e.Message}");
                throw;
            }
        }

    }
}
