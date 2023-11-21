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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Orbital
{
    /// <summary>
    /// A Class representing an AvailableGroundStation along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct an <see cref="AvailableGroundStationResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetAvailableGroundStationResource method.
    /// Otherwise you can get one from its parent resource <see cref="SubscriptionResource"/> using the GetAvailableGroundStation method.
    /// </summary>
    public partial class AvailableGroundStationResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="AvailableGroundStationResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="groundStationName"> The groundStationName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string groundStationName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.Orbital/availableGroundStations/{groundStationName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _availableGroundStationClientDiagnostics;
        private readonly AvailableGroundStationsRestOperations _availableGroundStationRestClient;
        private readonly AvailableGroundStationData _data;

        /// <summary> Initializes a new instance of the <see cref="AvailableGroundStationResource"/> class for mocking. </summary>
        protected AvailableGroundStationResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AvailableGroundStationResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal AvailableGroundStationResource(ArmClient client, AvailableGroundStationData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="AvailableGroundStationResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal AvailableGroundStationResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _availableGroundStationClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Orbital", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string availableGroundStationApiVersion);
            _availableGroundStationRestClient = new AvailableGroundStationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, availableGroundStationApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Orbital/availableGroundStations";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual AvailableGroundStationData Data
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
        /// Gets the specified available ground station.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Orbital/availableGroundStations/{groundStationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvailableGroundStations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AvailableGroundStationResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _availableGroundStationClientDiagnostics.CreateScope("AvailableGroundStationResource.Get");
            scope.Start();
            try
            {
                var response = await _availableGroundStationRestClient.GetAsync(Id.SubscriptionId, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AvailableGroundStationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified available ground station.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Orbital/availableGroundStations/{groundStationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvailableGroundStations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AvailableGroundStationResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _availableGroundStationClientDiagnostics.CreateScope("AvailableGroundStationResource.Get");
            scope.Start();
            try
            {
                var response = _availableGroundStationRestClient.Get(Id.SubscriptionId, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AvailableGroundStationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
