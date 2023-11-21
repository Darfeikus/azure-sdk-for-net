// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.CustomerInsights
{
    /// <summary>
    /// A Class representing a ViewResourceFormat along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="ViewResourceFormatResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetViewResourceFormatResource method.
    /// Otherwise you can get one from its parent resource <see cref="HubResource"/> using the GetViewResourceFormat method.
    /// </summary>
    public partial class ViewResourceFormatResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ViewResourceFormatResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="hubName"> The hubName. </param>
        /// <param name="viewName"> The viewName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string hubName, string viewName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/views/{viewName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _viewResourceFormatViewsClientDiagnostics;
        private readonly ViewsRestOperations _viewResourceFormatViewsRestClient;
        private readonly ViewResourceFormatData _data;

        /// <summary> Initializes a new instance of the <see cref="ViewResourceFormatResource"/> class for mocking. </summary>
        protected ViewResourceFormatResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ViewResourceFormatResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ViewResourceFormatResource(ArmClient client, ViewResourceFormatData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ViewResourceFormatResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ViewResourceFormatResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _viewResourceFormatViewsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CustomerInsights", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string viewResourceFormatViewsApiVersion);
            _viewResourceFormatViewsRestClient = new ViewsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, viewResourceFormatViewsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.CustomerInsights/hubs/views";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ViewResourceFormatData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a view in the hub.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/views/{viewName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Views_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="userId"> The user ID. Use * to retrieve hub level view. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="userId"/> is null. </exception>
        public virtual async Task<Response<ViewResourceFormatResource>> GetAsync(string userId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(userId, nameof(userId));

            using var scope = _viewResourceFormatViewsClientDiagnostics.CreateScope("ViewResourceFormatResource.Get");
            scope.Start();
            try
            {
                var response = await _viewResourceFormatViewsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, userId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ViewResourceFormatResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a view in the hub.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/views/{viewName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Views_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="userId"> The user ID. Use * to retrieve hub level view. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="userId"/> is null. </exception>
        public virtual Response<ViewResourceFormatResource> Get(string userId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(userId, nameof(userId));

            using var scope = _viewResourceFormatViewsClientDiagnostics.CreateScope("ViewResourceFormatResource.Get");
            scope.Start();
            try
            {
                var response = _viewResourceFormatViewsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, userId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ViewResourceFormatResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a view in the specified hub.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/views/{viewName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Views_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="userId"> The user ID. Use * to retrieve hub level view. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="userId"/> is null. </exception>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, string userId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(userId, nameof(userId));

            using var scope = _viewResourceFormatViewsClientDiagnostics.CreateScope("ViewResourceFormatResource.Delete");
            scope.Start();
            try
            {
                var response = await _viewResourceFormatViewsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, userId, cancellationToken).ConfigureAwait(false);
                var operation = new CustomerInsightsArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a view in the specified hub.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/views/{viewName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Views_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="userId"> The user ID. Use * to retrieve hub level view. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="userId"/> is null. </exception>
        public virtual ArmOperation Delete(WaitUntil waitUntil, string userId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(userId, nameof(userId));

            using var scope = _viewResourceFormatViewsClientDiagnostics.CreateScope("ViewResourceFormatResource.Delete");
            scope.Start();
            try
            {
                var response = _viewResourceFormatViewsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, userId, cancellationToken);
                var operation = new CustomerInsightsArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates a view or updates an existing view in the hub.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/views/{viewName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Views_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters supplied to the CreateOrUpdate View operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ViewResourceFormatResource>> UpdateAsync(WaitUntil waitUntil, ViewResourceFormatData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _viewResourceFormatViewsClientDiagnostics.CreateScope("ViewResourceFormatResource.Update");
            scope.Start();
            try
            {
                var response = await _viewResourceFormatViewsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new CustomerInsightsArmOperation<ViewResourceFormatResource>(Response.FromValue(new ViewResourceFormatResource(Client, response), response.GetRawResponse()));
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
        /// Creates a view or updates an existing view in the hub.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/views/{viewName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Views_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters supplied to the CreateOrUpdate View operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ViewResourceFormatResource> Update(WaitUntil waitUntil, ViewResourceFormatData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _viewResourceFormatViewsClientDiagnostics.CreateScope("ViewResourceFormatResource.Update");
            scope.Start();
            try
            {
                var response = _viewResourceFormatViewsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new CustomerInsightsArmOperation<ViewResourceFormatResource>(Response.FromValue(new ViewResourceFormatResource(Client, response), response.GetRawResponse()));
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
    }
}
