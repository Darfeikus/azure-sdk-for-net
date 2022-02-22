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
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Network
{
    /// <summary> A Class representing a NetworkInterfaceIPConfiguration along with the instance operations that can be performed on it. </summary>
    public partial class NetworkInterfaceIPConfiguration : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="NetworkInterfaceIPConfiguration"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string networkInterfaceName, string ipConfigurationName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkInterfaces/{networkInterfaceName}/ipConfigurations/{ipConfigurationName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _networkInterfaceIPConfigurationClientDiagnostics;
        private readonly NetworkInterfaceIPConfigurationsRestOperations _networkInterfaceIPConfigurationRestClient;
        private readonly NetworkInterfaceIPConfigurationData _data;

        /// <summary> Initializes a new instance of the <see cref="NetworkInterfaceIPConfiguration"/> class for mocking. </summary>
        protected NetworkInterfaceIPConfiguration()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "NetworkInterfaceIPConfiguration"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal NetworkInterfaceIPConfiguration(ArmClient client, NetworkInterfaceIPConfigurationData data) : this(client, new ResourceIdentifier(data.Id))
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="NetworkInterfaceIPConfiguration"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal NetworkInterfaceIPConfiguration(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _networkInterfaceIPConfigurationClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ResourceType, out string networkInterfaceIPConfigurationApiVersion);
            _networkInterfaceIPConfigurationRestClient = new NetworkInterfaceIPConfigurationsRestOperations(_networkInterfaceIPConfigurationClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, networkInterfaceIPConfigurationApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Network/networkInterfaces/ipConfigurations";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual NetworkInterfaceIPConfigurationData Data
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
        /// Gets the specified network interface ip configuration.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkInterfaces/{networkInterfaceName}/ipConfigurations/{ipConfigurationName}
        /// Operation Id: NetworkInterfaceIPConfigurations_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<NetworkInterfaceIPConfiguration>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _networkInterfaceIPConfigurationClientDiagnostics.CreateScope("NetworkInterfaceIPConfiguration.Get");
            scope.Start();
            try
            {
                var response = await _networkInterfaceIPConfigurationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _networkInterfaceIPConfigurationClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new NetworkInterfaceIPConfiguration(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified network interface ip configuration.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkInterfaces/{networkInterfaceName}/ipConfigurations/{ipConfigurationName}
        /// Operation Id: NetworkInterfaceIPConfigurations_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<NetworkInterfaceIPConfiguration> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _networkInterfaceIPConfigurationClientDiagnostics.CreateScope("NetworkInterfaceIPConfiguration.Get");
            scope.Start();
            try
            {
                var response = _networkInterfaceIPConfigurationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _networkInterfaceIPConfigurationClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkInterfaceIPConfiguration(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
