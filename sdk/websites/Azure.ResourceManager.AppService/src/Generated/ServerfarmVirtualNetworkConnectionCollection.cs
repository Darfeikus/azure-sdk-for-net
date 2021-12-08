// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing collection of VnetInfo and their operations over its parent. </summary>
    public partial class ServerfarmVirtualNetworkConnectionCollection : ArmCollection, IEnumerable<ServerfarmVirtualNetworkConnection>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly AppServicePlansRestOperations _appServicePlansRestClient;

        /// <summary> Initializes a new instance of the <see cref="ServerfarmVirtualNetworkConnectionCollection"/> class for mocking. </summary>
        protected ServerfarmVirtualNetworkConnectionCollection()
        {
        }

        /// <summary> Initializes a new instance of ServerfarmVirtualNetworkConnectionCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal ServerfarmVirtualNetworkConnectionCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _appServicePlansRestClient = new AppServicePlansRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => AppServicePlan.ResourceType;

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}
        /// OperationId: AppServicePlans_GetVnetFromServerFarm
        /// <summary> Description for Get a Virtual Network associated with an App Service plan. </summary>
        /// <param name="vnetName"> Name of the Virtual Network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vnetName"/> is null. </exception>
        public virtual Response<ServerfarmVirtualNetworkConnection> Get(string vnetName, CancellationToken cancellationToken = default)
        {
            if (vnetName == null)
            {
                throw new ArgumentNullException(nameof(vnetName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerfarmVirtualNetworkConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = _appServicePlansRestClient.GetVnetFromServerFarm(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vnetName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServerfarmVirtualNetworkConnection(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}
        /// OperationId: AppServicePlans_GetVnetFromServerFarm
        /// <summary> Description for Get a Virtual Network associated with an App Service plan. </summary>
        /// <param name="vnetName"> Name of the Virtual Network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vnetName"/> is null. </exception>
        public async virtual Task<Response<ServerfarmVirtualNetworkConnection>> GetAsync(string vnetName, CancellationToken cancellationToken = default)
        {
            if (vnetName == null)
            {
                throw new ArgumentNullException(nameof(vnetName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerfarmVirtualNetworkConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = await _appServicePlansRestClient.GetVnetFromServerFarmAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vnetName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ServerfarmVirtualNetworkConnection(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="vnetName"> Name of the Virtual Network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vnetName"/> is null. </exception>
        public virtual Response<ServerfarmVirtualNetworkConnection> GetIfExists(string vnetName, CancellationToken cancellationToken = default)
        {
            if (vnetName == null)
            {
                throw new ArgumentNullException(nameof(vnetName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerfarmVirtualNetworkConnectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _appServicePlansRestClient.GetVnetFromServerFarm(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vnetName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<ServerfarmVirtualNetworkConnection>(null, response.GetRawResponse())
                    : Response.FromValue(new ServerfarmVirtualNetworkConnection(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="vnetName"> Name of the Virtual Network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vnetName"/> is null. </exception>
        public async virtual Task<Response<ServerfarmVirtualNetworkConnection>> GetIfExistsAsync(string vnetName, CancellationToken cancellationToken = default)
        {
            if (vnetName == null)
            {
                throw new ArgumentNullException(nameof(vnetName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerfarmVirtualNetworkConnectionCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _appServicePlansRestClient.GetVnetFromServerFarmAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vnetName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<ServerfarmVirtualNetworkConnection>(null, response.GetRawResponse())
                    : Response.FromValue(new ServerfarmVirtualNetworkConnection(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="vnetName"> Name of the Virtual Network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vnetName"/> is null. </exception>
        public virtual Response<bool> CheckIfExists(string vnetName, CancellationToken cancellationToken = default)
        {
            if (vnetName == null)
            {
                throw new ArgumentNullException(nameof(vnetName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerfarmVirtualNetworkConnectionCollection.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(vnetName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="vnetName"> Name of the Virtual Network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vnetName"/> is null. </exception>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string vnetName, CancellationToken cancellationToken = default)
        {
            if (vnetName == null)
            {
                throw new ArgumentNullException(nameof(vnetName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerfarmVirtualNetworkConnectionCollection.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(vnetName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}
        /// OperationId: AppServicePlans_ListVnets
        /// <summary> Description for Get all Virtual Networks associated with an App Service plan. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<IReadOnlyList<ServerfarmVirtualNetworkConnection>> GetAll(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServerfarmVirtualNetworkConnectionCollection.GetAll");
            scope.Start();
            try
            {
                var response = _appServicePlansRestClient.ListVnets(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                return Response.FromValue(response.Value.Select(value => new ServerfarmVirtualNetworkConnection(Parent, value)).ToArray() as IReadOnlyList<ServerfarmVirtualNetworkConnection>, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}
        /// OperationId: AppServicePlans_ListVnets
        /// <summary> Description for Get all Virtual Networks associated with an App Service plan. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<IReadOnlyList<ServerfarmVirtualNetworkConnection>>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServerfarmVirtualNetworkConnectionCollection.GetAll");
            scope.Start();
            try
            {
                var response = await _appServicePlansRestClient.ListVnetsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value.Select(value => new ServerfarmVirtualNetworkConnection(Parent, value)).ToArray() as IReadOnlyList<ServerfarmVirtualNetworkConnection>, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ServerfarmVirtualNetworkConnection> IEnumerable<ServerfarmVirtualNetworkConnection>.GetEnumerator()
        {
            return GetAll().Value.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().Value.GetEnumerator();
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, ServerfarmVirtualNetworkConnection, VnetInfoData> Construct() { }
    }
}
