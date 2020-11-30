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
using Oci.ResourcesearchService.Requests;
using Oci.ResourcesearchService.Responses;

namespace Oci.ResourcesearchService
{
    /// <summary>Service client instance for ResourceSearch.</summary>
    public class ResourceSearchClient : RegionalClientBase
    {
        private readonly RetryConfiguration retryConfiguration;
        private const string basePathWithoutHost = "/20180409";

        public ResourceSearchPaginators Paginators { get; }

        /// <summary>
        /// Creates a new service instance using the given authentication provider and/or client configuration and/or endpoint.
        /// A client configuration can also be provided optionally to adjust REST client behaviors.
        /// </summary>
        /// <param name="authenticationDetailsProvider">The authentication details provider. Required.</param>
        /// <param name="clientConfiguration">The client configuration that contains settings to adjust REST client behaviors. Optional.</param>
        /// <param name="endpoint">The endpoint of the service. If not provided and the client is a regional client, the endpoint will be constructed based on region information. Optional.</param>
        public ResourceSearchClient(IBasicAuthenticationDetailsProvider authenticationDetailsProvider, ClientConfiguration clientConfiguration = null, string endpoint = null)
            : base(authenticationDetailsProvider, clientConfiguration)
        {
            service = new Service
            {
                ServiceName = "RESOURCESEARCH",
                ServiceEndpointPrefix = "query",
                ServiceEndpointTemplate = "https://query.{region}.{secondLevelDomain}"
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
            Paginators = new ResourceSearchPaginators(this);
        }

        /// <summary>
        /// Gets detailed information about a resource type by using the resource type name.
        /// 
        /// </summary>
        /// <param name="request">The request object containing the details to send. Required.</param>
        /// <param name="retryConfiguration">The retry configuration that will be used by to send this request. Optional.</param>
        /// <param name="cancellationToken">The cancellation token to cancel this operation. Optional.</param>
        /// <returns>A response object containing details about the completed operation</returns>
        /// <example>Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/8.0.0/resourcesearch/GetResourceType.cs.html">here</a> to see an example of how to use GetResourceType API.</example>
        public async Task<GetResourceTypeResponse> GetResourceType(GetResourceTypeRequest request, RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            logger.Trace("Called getResourceType");
            Uri uri = new Uri(this.restClient.GetEndpoint(), System.IO.Path.Combine(basePathWithoutHost, "/resourceTypes/{name}".Trim('/')));
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

                return Converter.FromHttpResponseMessage<GetResourceTypeResponse>(responseMessage);
            }
            catch (Exception e)
            {
                logger.Error($"GetResourceType failed with error: {e.Message}");
                throw;
            }
        }

        /// <summary>
        /// Lists all resource types that you can search or query for.
        /// 
        /// </summary>
        /// <param name="request">The request object containing the details to send. Required.</param>
        /// <param name="retryConfiguration">The retry configuration that will be used by to send this request. Optional.</param>
        /// <param name="cancellationToken">The cancellation token to cancel this operation. Optional.</param>
        /// <returns>A response object containing details about the completed operation</returns>
        /// <example>Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/8.0.0/resourcesearch/ListResourceTypes.cs.html">here</a> to see an example of how to use ListResourceTypes API.</example>
        public async Task<ListResourceTypesResponse> ListResourceTypes(ListResourceTypesRequest request, RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            logger.Trace("Called listResourceTypes");
            Uri uri = new Uri(this.restClient.GetEndpoint(), System.IO.Path.Combine(basePathWithoutHost, "/resourceTypes".Trim('/')));
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

                return Converter.FromHttpResponseMessage<ListResourceTypesResponse>(responseMessage);
            }
            catch (Exception e)
            {
                logger.Error($"ListResourceTypes failed with error: {e.Message}");
                throw;
            }
        }

        /// <summary>
        /// Queries any and all compartments in the specified tenancy to find resources that match the specified criteria.
        /// Results include resources that you have permission to view and can span different resource types. 
        /// You can also sort results based on a specified resource attribute.
        /// 
        /// </summary>
        /// <param name="request">The request object containing the details to send. Required.</param>
        /// <param name="retryConfiguration">The retry configuration that will be used by to send this request. Optional.</param>
        /// <param name="cancellationToken">The cancellation token to cancel this operation. Optional.</param>
        /// <returns>A response object containing details about the completed operation</returns>
        /// <example>Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/8.0.0/resourcesearch/SearchResources.cs.html">here</a> to see an example of how to use SearchResources API.</example>
        public async Task<SearchResourcesResponse> SearchResources(SearchResourcesRequest request, RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            logger.Trace("Called searchResources");
            Uri uri = new Uri(this.restClient.GetEndpoint(), System.IO.Path.Combine(basePathWithoutHost, "/resources".Trim('/')));
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

                return Converter.FromHttpResponseMessage<SearchResourcesResponse>(responseMessage);
            }
            catch (Exception e)
            {
                logger.Error($"SearchResources failed with error: {e.Message}");
                throw;
            }
        }

    }
}
