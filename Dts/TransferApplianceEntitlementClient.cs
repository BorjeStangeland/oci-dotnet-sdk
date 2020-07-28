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
using Oci.DtsService.Requests;
using Oci.DtsService.Responses;

namespace Oci.DtsService
{
    /// <summary>Service client instance for TransferApplianceEntitlement.</summary>
    public class TransferApplianceEntitlementClient : RegionalClientBase
    {
        private readonly RetryConfiguration retryConfiguration;
        private const string basePathWithoutHost = "/20171001";

        public TransferApplianceEntitlementWaiters Waiters { get; }

        /// <summary>
        /// Creates a new service instance using the given authentication provider and/or client configuration and/or endpoint.
        /// A client configuration can also be provided optionally to adjust REST client behaviors.
        /// </summary>
        /// <param name="authenticationDetailsProvider">The authentication details provider. Required.</param>
        /// <param name="clientConfiguration">The client configuration that contains settings to adjust REST client behaviors. Optional.</param>
        /// <param name="endpoint">The endpoint of the service. If not provided and the client is a regional client, the endpoint will be constructed based on region information. Optional.</param>
        public TransferApplianceEntitlementClient(IBasicAuthenticationDetailsProvider authenticationDetailsProvider, ClientConfiguration clientConfiguration = null, string endpoint = null)
            : base(authenticationDetailsProvider, clientConfiguration)
        {
            service = new Service
            {
                ServiceName = "TRANSFERAPPLIANCEENTITLEMENT",
                ServiceEndpointPrefix = "",
                ServiceEndpointTemplate = "https://datatransfer.{region}.oci.{secondLevelDomain}"
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
            Waiters = new TransferApplianceEntitlementWaiters(this);
        }

        /// <summary>
        /// Create the Entitlement to use a Transfer Appliance. It requires some offline process of review and signatures before request is granted.
        /// </summary>
        /// <param name="request">The request object containing the details to send. Required.</param>
        /// <param name="retryConfiguration">The retry configuration that will be used by to send this request. Optional.</param>
        /// <param name="cancellationToken">The cancellation token to cancel this operation. Optional.</param>
        /// <returns>A response object containing details about the completed operation</returns>
        public async Task<CreateTransferApplianceEntitlementResponse> CreateTransferApplianceEntitlement(CreateTransferApplianceEntitlementRequest request, RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            logger.Trace("Called createTransferApplianceEntitlement");
            Uri uri = new Uri(this.restClient.GetEndpoint(), System.IO.Path.Combine(basePathWithoutHost, "/transferApplianceEntitlement".Trim('/')));
            HttpMethod method = new HttpMethod("Post");
            HttpRequestMessage requestMessage = Converter.ToHttpRequestMessage(uri, method, request);
            requestMessage.Headers.Add("Accept", "application/json");
            GenericRetrier retryingClient = Retrier.GetPreferredRetrier(retryConfiguration, this.retryConfiguration);
            HttpResponseMessage responseMessage;

            try
            {
                if (retryingClient != null)
                {
                    responseMessage = await retryingClient.MakeRetryingCall(this.restClient.HttpSend, requestMessage, cancellationToken);
                }
                else
                {
                    responseMessage = await this.restClient.HttpSend(requestMessage);
                }

                return Converter.FromHttpResponseMessage<CreateTransferApplianceEntitlementResponse>(responseMessage);
            }
            catch (Exception e)
            {
                logger.Error($"CreateTransferApplianceEntitlement failed with error: {e.Message}");
                throw;
            }
        }

        /// <summary>
        /// Describes the Transfer Appliance Entitlement in detail
        /// </summary>
        /// <param name="request">The request object containing the details to send. Required.</param>
        /// <param name="retryConfiguration">The retry configuration that will be used by to send this request. Optional.</param>
        /// <param name="cancellationToken">The cancellation token to cancel this operation. Optional.</param>
        /// <returns>A response object containing details about the completed operation</returns>
        public async Task<GetTransferApplianceEntitlementResponse> GetTransferApplianceEntitlement(GetTransferApplianceEntitlementRequest request, RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            logger.Trace("Called getTransferApplianceEntitlement");
            Uri uri = new Uri(this.restClient.GetEndpoint(), System.IO.Path.Combine(basePathWithoutHost, "/transferApplianceEntitlement/{id}".Trim('/')));
            HttpMethod method = new HttpMethod("Get");
            HttpRequestMessage requestMessage = Converter.ToHttpRequestMessage(uri, method, request);
            requestMessage.Headers.Add("Accept", "application/json");
            GenericRetrier retryingClient = Retrier.GetPreferredRetrier(retryConfiguration, this.retryConfiguration);
            HttpResponseMessage responseMessage;

            try
            {
                if (retryingClient != null)
                {
                    responseMessage = await retryingClient.MakeRetryingCall(this.restClient.HttpSend, requestMessage, cancellationToken);
                }
                else
                {
                    responseMessage = await this.restClient.HttpSend(requestMessage);
                }

                return Converter.FromHttpResponseMessage<GetTransferApplianceEntitlementResponse>(responseMessage);
            }
            catch (Exception e)
            {
                logger.Error($"GetTransferApplianceEntitlement failed with error: {e.Message}");
                throw;
            }
        }

        /// <summary>
        /// Lists Transfer Transfer Appliance Entitlement
        /// </summary>
        /// <param name="request">The request object containing the details to send. Required.</param>
        /// <param name="retryConfiguration">The retry configuration that will be used by to send this request. Optional.</param>
        /// <param name="cancellationToken">The cancellation token to cancel this operation. Optional.</param>
        /// <returns>A response object containing details about the completed operation</returns>
        public async Task<ListTransferApplianceEntitlementResponse> ListTransferApplianceEntitlement(ListTransferApplianceEntitlementRequest request, RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            logger.Trace("Called listTransferApplianceEntitlement");
            Uri uri = new Uri(this.restClient.GetEndpoint(), System.IO.Path.Combine(basePathWithoutHost, "/transferApplianceEntitlement".Trim('/')));
            HttpMethod method = new HttpMethod("Get");
            HttpRequestMessage requestMessage = Converter.ToHttpRequestMessage(uri, method, request);
            requestMessage.Headers.Add("Accept", "application/json");
            GenericRetrier retryingClient = Retrier.GetPreferredRetrier(retryConfiguration, this.retryConfiguration);
            HttpResponseMessage responseMessage;

            try
            {
                if (retryingClient != null)
                {
                    responseMessage = await retryingClient.MakeRetryingCall(this.restClient.HttpSend, requestMessage, cancellationToken);
                }
                else
                {
                    responseMessage = await this.restClient.HttpSend(requestMessage);
                }

                return Converter.FromHttpResponseMessage<ListTransferApplianceEntitlementResponse>(responseMessage);
            }
            catch (Exception e)
            {
                logger.Error($"ListTransferApplianceEntitlement failed with error: {e.Message}");
                throw;
            }
        }

    }
}