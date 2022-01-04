// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing collection of NetworkFeatures and their operations over its parent. </summary>
    public partial class NetworkFeaturesCollection : ArmCollection
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly WebAppsRestOperations _webAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="NetworkFeaturesCollection"/> class for mocking. </summary>
        protected NetworkFeaturesCollection()
        {
        }

        /// <summary> Initializes a new instance of NetworkFeaturesCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal NetworkFeaturesCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _webAppsRestClient = new WebAppsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => SiteSlot.ResourceType;

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/networkFeatures/{view}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}
        /// OperationId: WebApps_ListNetworkFeaturesSlot
        /// <summary> Description for Gets all network features used by the app (or deployment slot, if specified). </summary>
        /// <param name="view"> The type of view. Only &quot;summary&quot; is supported at this time. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="view"/> is null. </exception>
        public virtual Response<NetworkFeatures> Get(string view, CancellationToken cancellationToken = default)
        {
            if (view == null)
            {
                throw new ArgumentNullException(nameof(view));
            }

            using var scope = _clientDiagnostics.CreateScope("NetworkFeaturesCollection.Get");
            scope.Start();
            try
            {
                var response = _webAppsRestClient.ListNetworkFeaturesSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, view, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkFeatures(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/networkFeatures/{view}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}
        /// OperationId: WebApps_ListNetworkFeaturesSlot
        /// <summary> Description for Gets all network features used by the app (or deployment slot, if specified). </summary>
        /// <param name="view"> The type of view. Only &quot;summary&quot; is supported at this time. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="view"/> is null. </exception>
        public async virtual Task<Response<NetworkFeatures>> GetAsync(string view, CancellationToken cancellationToken = default)
        {
            if (view == null)
            {
                throw new ArgumentNullException(nameof(view));
            }

            using var scope = _clientDiagnostics.CreateScope("NetworkFeaturesCollection.Get");
            scope.Start();
            try
            {
                var response = await _webAppsRestClient.ListNetworkFeaturesSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, view, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new NetworkFeatures(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="view"> The type of view. Only &quot;summary&quot; is supported at this time. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="view"/> is null. </exception>
        public virtual Response<NetworkFeatures> GetIfExists(string view, CancellationToken cancellationToken = default)
        {
            if (view == null)
            {
                throw new ArgumentNullException(nameof(view));
            }

            using var scope = _clientDiagnostics.CreateScope("NetworkFeaturesCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _webAppsRestClient.ListNetworkFeaturesSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, view, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<NetworkFeatures>(null, response.GetRawResponse())
                    : Response.FromValue(new NetworkFeatures(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="view"> The type of view. Only &quot;summary&quot; is supported at this time. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="view"/> is null. </exception>
        public async virtual Task<Response<NetworkFeatures>> GetIfExistsAsync(string view, CancellationToken cancellationToken = default)
        {
            if (view == null)
            {
                throw new ArgumentNullException(nameof(view));
            }

            using var scope = _clientDiagnostics.CreateScope("NetworkFeaturesCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _webAppsRestClient.ListNetworkFeaturesSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, view, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<NetworkFeatures>(null, response.GetRawResponse())
                    : Response.FromValue(new NetworkFeatures(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="view"> The type of view. Only &quot;summary&quot; is supported at this time. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="view"/> is null. </exception>
        public virtual Response<bool> Exists(string view, CancellationToken cancellationToken = default)
        {
            if (view == null)
            {
                throw new ArgumentNullException(nameof(view));
            }

            using var scope = _clientDiagnostics.CreateScope("NetworkFeaturesCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(view, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="view"> The type of view. Only &quot;summary&quot; is supported at this time. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="view"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string view, CancellationToken cancellationToken = default)
        {
            if (view == null)
            {
                throw new ArgumentNullException(nameof(view));
            }

            using var scope = _clientDiagnostics.CreateScope("NetworkFeaturesCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(view, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, NetworkFeatures, NetworkFeaturesData> Construct() { }
    }
}
