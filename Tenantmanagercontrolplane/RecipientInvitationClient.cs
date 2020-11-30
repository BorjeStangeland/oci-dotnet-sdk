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
using Oci.TenantmanagercontrolplaneService.Requests;
using Oci.TenantmanagercontrolplaneService.Responses;

namespace Oci.TenantmanagercontrolplaneService
{
    /// <summary>Service client instance for RecipientInvitation.</summary>
    public class RecipientInvitationClient : RegionalClientBase
    {
        private readonly RetryConfiguration retryConfiguration;
        private const string basePathWithoutHost = "/20200801";

        public RecipientInvitationPaginators Paginators { get; }

        public RecipientInvitationWaiters Waiters { get; }

        /// <summary>
        /// Creates a new service instance using the given authentication provider and/or client configuration and/or endpoint.
        /// A client configuration can also be provided optionally to adjust REST client behaviors.
        /// </summary>
        /// <param name="authenticationDetailsProvider">The authentication details provider. Required.</param>
        /// <param name="clientConfiguration">The client configuration that contains settings to adjust REST client behaviors. Optional.</param>
        /// <param name="endpoint">The endpoint of the service. If not provided and the client is a regional client, the endpoint will be constructed based on region information. Optional.</param>
        public RecipientInvitationClient(IBasicAuthenticationDetailsProvider authenticationDetailsProvider, ClientConfiguration clientConfiguration = null, string endpoint = null)
            : base(authenticationDetailsProvider, clientConfiguration)
        {
            service = new Service
            {
                ServiceName = "RECIPIENTINVITATION",
                ServiceEndpointPrefix = "",
                ServiceEndpointTemplate = "https://organizations.{region}.oci.{secondLevelDomain}"
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
            Paginators = new RecipientInvitationPaginators(this);
            Waiters = new RecipientInvitationWaiters(this);
        }

        /// <summary>
        /// Accepts a recipient invitation.
        /// </summary>
        /// <param name="request">The request object containing the details to send. Required.</param>
        /// <param name="retryConfiguration">The retry configuration that will be used by to send this request. Optional.</param>
        /// <param name="cancellationToken">The cancellation token to cancel this operation. Optional.</param>
        /// <returns>A response object containing details about the completed operation</returns>
        /// <example>Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/8.0.0/tenantmanagercontrolplane/AcceptRecipientInvitation.cs.html">here</a> to see an example of how to use AcceptRecipientInvitation API.</example>
        public async Task<AcceptRecipientInvitationResponse> AcceptRecipientInvitation(AcceptRecipientInvitationRequest request, RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            logger.Trace("Called acceptRecipientInvitation");
            Uri uri = new Uri(this.restClient.GetEndpoint(), System.IO.Path.Combine(basePathWithoutHost, "/recipientInvitations/{recipientInvitationId}/actions/accept".Trim('/')));
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

                return Converter.FromHttpResponseMessage<AcceptRecipientInvitationResponse>(responseMessage);
            }
            catch (Exception e)
            {
                logger.Error($"AcceptRecipientInvitation failed with error: {e.Message}");
                throw;
            }
        }

        /// <summary>
        /// Gets information about the recipient invitation.
        /// </summary>
        /// <param name="request">The request object containing the details to send. Required.</param>
        /// <param name="retryConfiguration">The retry configuration that will be used by to send this request. Optional.</param>
        /// <param name="cancellationToken">The cancellation token to cancel this operation. Optional.</param>
        /// <returns>A response object containing details about the completed operation</returns>
        /// <example>Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/8.0.0/tenantmanagercontrolplane/GetRecipientInvitation.cs.html">here</a> to see an example of how to use GetRecipientInvitation API.</example>
        public async Task<GetRecipientInvitationResponse> GetRecipientInvitation(GetRecipientInvitationRequest request, RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            logger.Trace("Called getRecipientInvitation");
            Uri uri = new Uri(this.restClient.GetEndpoint(), System.IO.Path.Combine(basePathWithoutHost, "/recipientInvitations/{recipientInvitationId}".Trim('/')));
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

                return Converter.FromHttpResponseMessage<GetRecipientInvitationResponse>(responseMessage);
            }
            catch (Exception e)
            {
                logger.Error($"GetRecipientInvitation failed with error: {e.Message}");
                throw;
            }
        }

        /// <summary>
        /// Ignores a recipient invitation.
        /// </summary>
        /// <param name="request">The request object containing the details to send. Required.</param>
        /// <param name="retryConfiguration">The retry configuration that will be used by to send this request. Optional.</param>
        /// <param name="cancellationToken">The cancellation token to cancel this operation. Optional.</param>
        /// <returns>A response object containing details about the completed operation</returns>
        /// <example>Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/8.0.0/tenantmanagercontrolplane/IgnoreRecipientInvitation.cs.html">here</a> to see an example of how to use IgnoreRecipientInvitation API.</example>
        public async Task<IgnoreRecipientInvitationResponse> IgnoreRecipientInvitation(IgnoreRecipientInvitationRequest request, RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            logger.Trace("Called ignoreRecipientInvitation");
            Uri uri = new Uri(this.restClient.GetEndpoint(), System.IO.Path.Combine(basePathWithoutHost, "/recipientInvitations/{recipientInvitationId}/actions/ignore".Trim('/')));
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

                return Converter.FromHttpResponseMessage<IgnoreRecipientInvitationResponse>(responseMessage);
            }
            catch (Exception e)
            {
                logger.Error($"IgnoreRecipientInvitation failed with error: {e.Message}");
                throw;
            }
        }

        /// <summary>
        /// Return a (paginated) list of recipient invitations.
        /// 
        /// </summary>
        /// <param name="request">The request object containing the details to send. Required.</param>
        /// <param name="retryConfiguration">The retry configuration that will be used by to send this request. Optional.</param>
        /// <param name="cancellationToken">The cancellation token to cancel this operation. Optional.</param>
        /// <returns>A response object containing details about the completed operation</returns>
        /// <example>Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/8.0.0/tenantmanagercontrolplane/ListRecipientInvitations.cs.html">here</a> to see an example of how to use ListRecipientInvitations API.</example>
        public async Task<ListRecipientInvitationsResponse> ListRecipientInvitations(ListRecipientInvitationsRequest request, RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            logger.Trace("Called listRecipientInvitations");
            Uri uri = new Uri(this.restClient.GetEndpoint(), System.IO.Path.Combine(basePathWithoutHost, "/recipientInvitations".Trim('/')));
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

                return Converter.FromHttpResponseMessage<ListRecipientInvitationsResponse>(responseMessage);
            }
            catch (Exception e)
            {
                logger.Error($"ListRecipientInvitations failed with error: {e.Message}");
                throw;
            }
        }

        /// <summary>
        /// Updates the RecipientInvitation.
        /// </summary>
        /// <param name="request">The request object containing the details to send. Required.</param>
        /// <param name="retryConfiguration">The retry configuration that will be used by to send this request. Optional.</param>
        /// <param name="cancellationToken">The cancellation token to cancel this operation. Optional.</param>
        /// <returns>A response object containing details about the completed operation</returns>
        /// <example>Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/8.0.0/tenantmanagercontrolplane/UpdateRecipientInvitation.cs.html">here</a> to see an example of how to use UpdateRecipientInvitation API.</example>
        public async Task<UpdateRecipientInvitationResponse> UpdateRecipientInvitation(UpdateRecipientInvitationRequest request, RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            logger.Trace("Called updateRecipientInvitation");
            Uri uri = new Uri(this.restClient.GetEndpoint(), System.IO.Path.Combine(basePathWithoutHost, "/recipientInvitations/{recipientInvitationId}".Trim('/')));
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

                return Converter.FromHttpResponseMessage<UpdateRecipientInvitationResponse>(responseMessage);
            }
            catch (Exception e)
            {
                logger.Error($"UpdateRecipientInvitation failed with error: {e.Message}");
                throw;
            }
        }

    }
}
