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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing a collection of <see cref="AzureWebCategoryResource"/> and their operations.
    /// Each <see cref="AzureWebCategoryResource"/> in the collection will belong to the same instance of <see cref="SubscriptionResource"/>.
    /// To get an <see cref="AzureWebCategoryCollection"/> instance call the GetAzureWebCategories method from an instance of <see cref="SubscriptionResource"/>.
    /// </summary>
    public partial class AzureWebCategoryCollection : ArmCollection, IEnumerable<AzureWebCategoryResource>, IAsyncEnumerable<AzureWebCategoryResource>
    {
        private readonly ClientDiagnostics _azureWebCategoryWebCategoriesClientDiagnostics;
        private readonly WebCategoriesRestOperations _azureWebCategoryWebCategoriesRestClient;

        /// <summary> Initializes a new instance of the <see cref="AzureWebCategoryCollection"/> class for mocking. </summary>
        protected AzureWebCategoryCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AzureWebCategoryCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AzureWebCategoryCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _azureWebCategoryWebCategoriesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", AzureWebCategoryResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AzureWebCategoryResource.ResourceType, out string azureWebCategoryWebCategoriesApiVersion);
            _azureWebCategoryWebCategoriesRestClient = new WebCategoriesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, azureWebCategoryWebCategoriesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SubscriptionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SubscriptionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets the specified Azure Web Category.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/azureWebCategories/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebCategories_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the azureWebCategory. </param>
        /// <param name="expand"> Expands resourceIds back referenced by the azureWebCategory resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<AzureWebCategoryResource>> GetAsync(string name, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _azureWebCategoryWebCategoriesClientDiagnostics.CreateScope("AzureWebCategoryCollection.Get");
            scope.Start();
            try
            {
                var response = await _azureWebCategoryWebCategoriesRestClient.GetAsync(Id.SubscriptionId, name, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AzureWebCategoryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified Azure Web Category.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/azureWebCategories/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebCategories_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the azureWebCategory. </param>
        /// <param name="expand"> Expands resourceIds back referenced by the azureWebCategory resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<AzureWebCategoryResource> Get(string name, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _azureWebCategoryWebCategoriesClientDiagnostics.CreateScope("AzureWebCategoryCollection.Get");
            scope.Start();
            try
            {
                var response = _azureWebCategoryWebCategoriesRestClient.Get(Id.SubscriptionId, name, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AzureWebCategoryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all the Azure Web Categories in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/azureWebCategories</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebCategories_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AzureWebCategoryResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AzureWebCategoryResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _azureWebCategoryWebCategoriesRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _azureWebCategoryWebCategoriesRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new AzureWebCategoryResource(Client, AzureWebCategoryData.DeserializeAzureWebCategoryData(e)), _azureWebCategoryWebCategoriesClientDiagnostics, Pipeline, "AzureWebCategoryCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all the Azure Web Categories in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/azureWebCategories</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebCategories_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AzureWebCategoryResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AzureWebCategoryResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _azureWebCategoryWebCategoriesRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _azureWebCategoryWebCategoriesRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new AzureWebCategoryResource(Client, AzureWebCategoryData.DeserializeAzureWebCategoryData(e)), _azureWebCategoryWebCategoriesClientDiagnostics, Pipeline, "AzureWebCategoryCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/azureWebCategories/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebCategories_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the azureWebCategory. </param>
        /// <param name="expand"> Expands resourceIds back referenced by the azureWebCategory resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string name, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _azureWebCategoryWebCategoriesClientDiagnostics.CreateScope("AzureWebCategoryCollection.Exists");
            scope.Start();
            try
            {
                var response = await _azureWebCategoryWebCategoriesRestClient.GetAsync(Id.SubscriptionId, name, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/azureWebCategories/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebCategories_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the azureWebCategory. </param>
        /// <param name="expand"> Expands resourceIds back referenced by the azureWebCategory resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<bool> Exists(string name, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _azureWebCategoryWebCategoriesClientDiagnostics.CreateScope("AzureWebCategoryCollection.Exists");
            scope.Start();
            try
            {
                var response = _azureWebCategoryWebCategoriesRestClient.Get(Id.SubscriptionId, name, expand, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/azureWebCategories/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebCategories_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the azureWebCategory. </param>
        /// <param name="expand"> Expands resourceIds back referenced by the azureWebCategory resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<NullableResponse<AzureWebCategoryResource>> GetIfExistsAsync(string name, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _azureWebCategoryWebCategoriesClientDiagnostics.CreateScope("AzureWebCategoryCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _azureWebCategoryWebCategoriesRestClient.GetAsync(Id.SubscriptionId, name, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<AzureWebCategoryResource>(response.GetRawResponse());
                return Response.FromValue(new AzureWebCategoryResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/azureWebCategories/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebCategories_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the azureWebCategory. </param>
        /// <param name="expand"> Expands resourceIds back referenced by the azureWebCategory resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual NullableResponse<AzureWebCategoryResource> GetIfExists(string name, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _azureWebCategoryWebCategoriesClientDiagnostics.CreateScope("AzureWebCategoryCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _azureWebCategoryWebCategoriesRestClient.Get(Id.SubscriptionId, name, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<AzureWebCategoryResource>(response.GetRawResponse());
                return Response.FromValue(new AzureWebCategoryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AzureWebCategoryResource> IEnumerable<AzureWebCategoryResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AzureWebCategoryResource> IAsyncEnumerable<AzureWebCategoryResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
