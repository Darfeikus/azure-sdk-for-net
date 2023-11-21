// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.ProviderHub
{
    /// <summary>
    /// A class representing a collection of <see cref="ResourceTypeSkuResource"/> and their operations.
    /// Each <see cref="ResourceTypeSkuResource"/> in the collection will belong to the same instance of <see cref="ResourceTypeRegistrationResource"/>.
    /// To get a <see cref="ResourceTypeSkuCollection"/> instance call the GetResourceTypeSkus method from an instance of <see cref="ResourceTypeRegistrationResource"/>.
    /// </summary>
    public partial class ResourceTypeSkuCollection : ArmCollection, IEnumerable<ResourceTypeSkuResource>, IAsyncEnumerable<ResourceTypeSkuResource>
    {
        private readonly ClientDiagnostics _resourceTypeSkuSkusClientDiagnostics;
        private readonly SkusRestOperations _resourceTypeSkuSkusRestClient;

        /// <summary> Initializes a new instance of the <see cref="ResourceTypeSkuCollection"/> class for mocking. </summary>
        protected ResourceTypeSkuCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ResourceTypeSkuCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ResourceTypeSkuCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _resourceTypeSkuSkusClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ProviderHub", ResourceTypeSkuResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceTypeSkuResource.ResourceType, out string resourceTypeSkuSkusApiVersion);
            _resourceTypeSkuSkusRestClient = new SkusRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, resourceTypeSkuSkusApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceTypeRegistrationResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceTypeRegistrationResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates the resource type skus in the given resource type.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}/skus/{sku}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="sku"> The SKU. </param>
        /// <param name="data"> The required body parameters supplied to the resource sku operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sku"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sku"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ResourceTypeSkuResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string sku, ResourceTypeSkuData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sku, nameof(sku));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _resourceTypeSkuSkusClientDiagnostics.CreateScope("ResourceTypeSkuCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _resourceTypeSkuSkusRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, sku, data, cancellationToken).ConfigureAwait(false);
                var operation = new ProviderHubArmOperation<ResourceTypeSkuResource>(Response.FromValue(new ResourceTypeSkuResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates the resource type skus in the given resource type.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}/skus/{sku}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="sku"> The SKU. </param>
        /// <param name="data"> The required body parameters supplied to the resource sku operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sku"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sku"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ResourceTypeSkuResource> CreateOrUpdate(WaitUntil waitUntil, string sku, ResourceTypeSkuData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sku, nameof(sku));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _resourceTypeSkuSkusClientDiagnostics.CreateScope("ResourceTypeSkuCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _resourceTypeSkuSkusRestClient.CreateOrUpdate(Id.SubscriptionId, Id.Parent.Name, Id.Name, sku, data, cancellationToken);
                var operation = new ProviderHubArmOperation<ResourceTypeSkuResource>(Response.FromValue(new ResourceTypeSkuResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the sku details for the given resource type and sku name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}/skus/{sku}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sku"> The SKU. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sku"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sku"/> is null. </exception>
        public virtual async Task<Response<ResourceTypeSkuResource>> GetAsync(string sku, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sku, nameof(sku));

            using var scope = _resourceTypeSkuSkusClientDiagnostics.CreateScope("ResourceTypeSkuCollection.Get");
            scope.Start();
            try
            {
                var response = await _resourceTypeSkuSkusRestClient.GetAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, sku, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ResourceTypeSkuResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the sku details for the given resource type and sku name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}/skus/{sku}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sku"> The SKU. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sku"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sku"/> is null. </exception>
        public virtual Response<ResourceTypeSkuResource> Get(string sku, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sku, nameof(sku));

            using var scope = _resourceTypeSkuSkusClientDiagnostics.CreateScope("ResourceTypeSkuCollection.Get");
            scope.Start();
            try
            {
                var response = _resourceTypeSkuSkusRestClient.Get(Id.SubscriptionId, Id.Parent.Name, Id.Name, sku, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ResourceTypeSkuResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the list of skus for the given resource type.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}/skus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_ListByResourceTypeRegistrations</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ResourceTypeSkuResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ResourceTypeSkuResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _resourceTypeSkuSkusRestClient.CreateListByResourceTypeRegistrationsRequest(Id.SubscriptionId, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _resourceTypeSkuSkusRestClient.CreateListByResourceTypeRegistrationsNextPageRequest(nextLink, Id.SubscriptionId, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ResourceTypeSkuResource(Client, ResourceTypeSkuData.DeserializeResourceTypeSkuData(e)), _resourceTypeSkuSkusClientDiagnostics, Pipeline, "ResourceTypeSkuCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets the list of skus for the given resource type.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}/skus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_ListByResourceTypeRegistrations</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ResourceTypeSkuResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ResourceTypeSkuResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _resourceTypeSkuSkusRestClient.CreateListByResourceTypeRegistrationsRequest(Id.SubscriptionId, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _resourceTypeSkuSkusRestClient.CreateListByResourceTypeRegistrationsNextPageRequest(nextLink, Id.SubscriptionId, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ResourceTypeSkuResource(Client, ResourceTypeSkuData.DeserializeResourceTypeSkuData(e)), _resourceTypeSkuSkusClientDiagnostics, Pipeline, "ResourceTypeSkuCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}/skus/{sku}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sku"> The SKU. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sku"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sku"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string sku, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sku, nameof(sku));

            using var scope = _resourceTypeSkuSkusClientDiagnostics.CreateScope("ResourceTypeSkuCollection.Exists");
            scope.Start();
            try
            {
                var response = await _resourceTypeSkuSkusRestClient.GetAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, sku, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}/skus/{sku}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sku"> The SKU. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sku"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sku"/> is null. </exception>
        public virtual Response<bool> Exists(string sku, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sku, nameof(sku));

            using var scope = _resourceTypeSkuSkusClientDiagnostics.CreateScope("ResourceTypeSkuCollection.Exists");
            scope.Start();
            try
            {
                var response = _resourceTypeSkuSkusRestClient.Get(Id.SubscriptionId, Id.Parent.Name, Id.Name, sku, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}/skus/{sku}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sku"> The SKU. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sku"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sku"/> is null. </exception>
        public virtual async Task<NullableResponse<ResourceTypeSkuResource>> GetIfExistsAsync(string sku, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sku, nameof(sku));

            using var scope = _resourceTypeSkuSkusClientDiagnostics.CreateScope("ResourceTypeSkuCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _resourceTypeSkuSkusRestClient.GetAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, sku, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ResourceTypeSkuResource>(response.GetRawResponse());
                return Response.FromValue(new ResourceTypeSkuResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}/skus/{sku}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sku"> The SKU. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sku"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sku"/> is null. </exception>
        public virtual NullableResponse<ResourceTypeSkuResource> GetIfExists(string sku, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sku, nameof(sku));

            using var scope = _resourceTypeSkuSkusClientDiagnostics.CreateScope("ResourceTypeSkuCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _resourceTypeSkuSkusRestClient.Get(Id.SubscriptionId, Id.Parent.Name, Id.Name, sku, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ResourceTypeSkuResource>(response.GetRawResponse());
                return Response.FromValue(new ResourceTypeSkuResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ResourceTypeSkuResource> IEnumerable<ResourceTypeSkuResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ResourceTypeSkuResource> IAsyncEnumerable<ResourceTypeSkuResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
