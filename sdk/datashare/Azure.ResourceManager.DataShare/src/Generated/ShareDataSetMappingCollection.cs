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

namespace Azure.ResourceManager.DataShare
{
    /// <summary>
    /// A class representing a collection of <see cref="ShareDataSetMappingResource"/> and their operations.
    /// Each <see cref="ShareDataSetMappingResource"/> in the collection will belong to the same instance of <see cref="ShareSubscriptionResource"/>.
    /// To get a <see cref="ShareDataSetMappingCollection"/> instance call the GetShareDataSetMappings method from an instance of <see cref="ShareSubscriptionResource"/>.
    /// </summary>
    public partial class ShareDataSetMappingCollection : ArmCollection, IEnumerable<ShareDataSetMappingResource>, IAsyncEnumerable<ShareDataSetMappingResource>
    {
        private readonly ClientDiagnostics _shareDataSetMappingDataSetMappingsClientDiagnostics;
        private readonly DataSetMappingsRestOperations _shareDataSetMappingDataSetMappingsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ShareDataSetMappingCollection"/> class for mocking. </summary>
        protected ShareDataSetMappingCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ShareDataSetMappingCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ShareDataSetMappingCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _shareDataSetMappingDataSetMappingsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DataShare", ShareDataSetMappingResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ShareDataSetMappingResource.ResourceType, out string shareDataSetMappingDataSetMappingsApiVersion);
            _shareDataSetMappingDataSetMappingsRestClient = new DataSetMappingsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, shareDataSetMappingDataSetMappingsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ShareSubscriptionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ShareSubscriptionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a DataSetMapping
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shareSubscriptions/{shareSubscriptionName}/dataSetMappings/{dataSetMappingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataSetMappings_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="dataSetMappingName"> The name of the data set mapping to be created. </param>
        /// <param name="data"> Destination data set configuration details. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataSetMappingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataSetMappingName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ShareDataSetMappingResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string dataSetMappingName, ShareDataSetMappingData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataSetMappingName, nameof(dataSetMappingName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _shareDataSetMappingDataSetMappingsClientDiagnostics.CreateScope("ShareDataSetMappingCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _shareDataSetMappingDataSetMappingsRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, dataSetMappingName, data, cancellationToken).ConfigureAwait(false);
                var operation = new DataShareArmOperation<ShareDataSetMappingResource>(Response.FromValue(new ShareDataSetMappingResource(Client, response), response.GetRawResponse()));
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
        /// Create a DataSetMapping
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shareSubscriptions/{shareSubscriptionName}/dataSetMappings/{dataSetMappingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataSetMappings_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="dataSetMappingName"> The name of the data set mapping to be created. </param>
        /// <param name="data"> Destination data set configuration details. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataSetMappingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataSetMappingName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ShareDataSetMappingResource> CreateOrUpdate(WaitUntil waitUntil, string dataSetMappingName, ShareDataSetMappingData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataSetMappingName, nameof(dataSetMappingName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _shareDataSetMappingDataSetMappingsClientDiagnostics.CreateScope("ShareDataSetMappingCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _shareDataSetMappingDataSetMappingsRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, dataSetMappingName, data, cancellationToken);
                var operation = new DataShareArmOperation<ShareDataSetMappingResource>(Response.FromValue(new ShareDataSetMappingResource(Client, response), response.GetRawResponse()));
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
        /// Get a DataSetMapping in a shareSubscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shareSubscriptions/{shareSubscriptionName}/dataSetMappings/{dataSetMappingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataSetMappings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataSetMappingName"> The name of the dataSetMapping. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataSetMappingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataSetMappingName"/> is null. </exception>
        public virtual async Task<Response<ShareDataSetMappingResource>> GetAsync(string dataSetMappingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataSetMappingName, nameof(dataSetMappingName));

            using var scope = _shareDataSetMappingDataSetMappingsClientDiagnostics.CreateScope("ShareDataSetMappingCollection.Get");
            scope.Start();
            try
            {
                var response = await _shareDataSetMappingDataSetMappingsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, dataSetMappingName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ShareDataSetMappingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a DataSetMapping in a shareSubscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shareSubscriptions/{shareSubscriptionName}/dataSetMappings/{dataSetMappingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataSetMappings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataSetMappingName"> The name of the dataSetMapping. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataSetMappingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataSetMappingName"/> is null. </exception>
        public virtual Response<ShareDataSetMappingResource> Get(string dataSetMappingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataSetMappingName, nameof(dataSetMappingName));

            using var scope = _shareDataSetMappingDataSetMappingsClientDiagnostics.CreateScope("ShareDataSetMappingCollection.Get");
            scope.Start();
            try
            {
                var response = _shareDataSetMappingDataSetMappingsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, dataSetMappingName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ShareDataSetMappingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List DataSetMappings in a share subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shareSubscriptions/{shareSubscriptionName}/dataSetMappings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataSetMappings_ListByShareSubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skipToken"> Continuation token. </param>
        /// <param name="filter"> Filters the results using OData syntax. </param>
        /// <param name="orderby"> Sorts the results using OData syntax. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ShareDataSetMappingResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ShareDataSetMappingResource> GetAllAsync(string skipToken = null, string filter = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _shareDataSetMappingDataSetMappingsRestClient.CreateListByShareSubscriptionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, skipToken, filter, orderby);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _shareDataSetMappingDataSetMappingsRestClient.CreateListByShareSubscriptionNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, skipToken, filter, orderby);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ShareDataSetMappingResource(Client, ShareDataSetMappingData.DeserializeShareDataSetMappingData(e)), _shareDataSetMappingDataSetMappingsClientDiagnostics, Pipeline, "ShareDataSetMappingCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List DataSetMappings in a share subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shareSubscriptions/{shareSubscriptionName}/dataSetMappings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataSetMappings_ListByShareSubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skipToken"> Continuation token. </param>
        /// <param name="filter"> Filters the results using OData syntax. </param>
        /// <param name="orderby"> Sorts the results using OData syntax. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ShareDataSetMappingResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ShareDataSetMappingResource> GetAll(string skipToken = null, string filter = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _shareDataSetMappingDataSetMappingsRestClient.CreateListByShareSubscriptionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, skipToken, filter, orderby);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _shareDataSetMappingDataSetMappingsRestClient.CreateListByShareSubscriptionNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, skipToken, filter, orderby);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ShareDataSetMappingResource(Client, ShareDataSetMappingData.DeserializeShareDataSetMappingData(e)), _shareDataSetMappingDataSetMappingsClientDiagnostics, Pipeline, "ShareDataSetMappingCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shareSubscriptions/{shareSubscriptionName}/dataSetMappings/{dataSetMappingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataSetMappings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataSetMappingName"> The name of the dataSetMapping. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataSetMappingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataSetMappingName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string dataSetMappingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataSetMappingName, nameof(dataSetMappingName));

            using var scope = _shareDataSetMappingDataSetMappingsClientDiagnostics.CreateScope("ShareDataSetMappingCollection.Exists");
            scope.Start();
            try
            {
                var response = await _shareDataSetMappingDataSetMappingsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, dataSetMappingName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shareSubscriptions/{shareSubscriptionName}/dataSetMappings/{dataSetMappingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataSetMappings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataSetMappingName"> The name of the dataSetMapping. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataSetMappingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataSetMappingName"/> is null. </exception>
        public virtual Response<bool> Exists(string dataSetMappingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataSetMappingName, nameof(dataSetMappingName));

            using var scope = _shareDataSetMappingDataSetMappingsClientDiagnostics.CreateScope("ShareDataSetMappingCollection.Exists");
            scope.Start();
            try
            {
                var response = _shareDataSetMappingDataSetMappingsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, dataSetMappingName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shareSubscriptions/{shareSubscriptionName}/dataSetMappings/{dataSetMappingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataSetMappings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataSetMappingName"> The name of the dataSetMapping. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataSetMappingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataSetMappingName"/> is null. </exception>
        public virtual async Task<NullableResponse<ShareDataSetMappingResource>> GetIfExistsAsync(string dataSetMappingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataSetMappingName, nameof(dataSetMappingName));

            using var scope = _shareDataSetMappingDataSetMappingsClientDiagnostics.CreateScope("ShareDataSetMappingCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _shareDataSetMappingDataSetMappingsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, dataSetMappingName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ShareDataSetMappingResource>(response.GetRawResponse());
                return Response.FromValue(new ShareDataSetMappingResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shareSubscriptions/{shareSubscriptionName}/dataSetMappings/{dataSetMappingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataSetMappings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataSetMappingName"> The name of the dataSetMapping. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataSetMappingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataSetMappingName"/> is null. </exception>
        public virtual NullableResponse<ShareDataSetMappingResource> GetIfExists(string dataSetMappingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataSetMappingName, nameof(dataSetMappingName));

            using var scope = _shareDataSetMappingDataSetMappingsClientDiagnostics.CreateScope("ShareDataSetMappingCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _shareDataSetMappingDataSetMappingsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, dataSetMappingName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ShareDataSetMappingResource>(response.GetRawResponse());
                return Response.FromValue(new ShareDataSetMappingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ShareDataSetMappingResource> IEnumerable<ShareDataSetMappingResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ShareDataSetMappingResource> IAsyncEnumerable<ShareDataSetMappingResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
