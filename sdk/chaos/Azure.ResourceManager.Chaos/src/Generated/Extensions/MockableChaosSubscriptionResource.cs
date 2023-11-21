// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Chaos;

namespace Azure.ResourceManager.Chaos.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class MockableChaosSubscriptionResource : ArmResource
    {
        private ClientDiagnostics _experimentClientDiagnostics;
        private ExperimentsRestOperations _experimentRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableChaosSubscriptionResource"/> class for mocking. </summary>
        protected MockableChaosSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableChaosSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableChaosSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics ExperimentClientDiagnostics => _experimentClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Chaos", ExperimentResource.ResourceType.Namespace, Diagnostics);
        private ExperimentsRestOperations ExperimentRestClient => _experimentRestClient ??= new ExperimentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(ExperimentResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of TargetTypeResources in the SubscriptionResource. </summary>
        /// <param name="locationName"> String that represents a Location resource name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="locationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <returns> An object representing collection of TargetTypeResources and their operations over a TargetTypeResource. </returns>
        public virtual TargetTypeCollection GetTargetTypes(string locationName)
        {
            return new TargetTypeCollection(Client, Id, locationName);
        }

        /// <summary>
        /// Get a Target Type resources for given location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Chaos/locations/{locationName}/targetTypes/{targetTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TargetTypes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="locationName"> String that represents a Location resource name. </param>
        /// <param name="targetTypeName"> String that represents a Target Type resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/> or <paramref name="targetTypeName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="locationName"/> or <paramref name="targetTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<TargetTypeResource>> GetTargetTypeAsync(string locationName, string targetTypeName, CancellationToken cancellationToken = default)
        {
            return await GetTargetTypes(locationName).GetAsync(targetTypeName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a Target Type resources for given location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Chaos/locations/{locationName}/targetTypes/{targetTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TargetTypes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="locationName"> String that represents a Location resource name. </param>
        /// <param name="targetTypeName"> String that represents a Target Type resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/> or <paramref name="targetTypeName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="locationName"/> or <paramref name="targetTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<TargetTypeResource> GetTargetType(string locationName, string targetTypeName, CancellationToken cancellationToken = default)
        {
            return GetTargetTypes(locationName).Get(targetTypeName, cancellationToken);
        }

        /// <summary>
        /// Get a list of Experiment resources in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Chaos/experiments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Experiments_ListAll</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="running"> Optional value that indicates whether to filter results based on if the Experiment is currently running. If null, then the results will not be filtered. </param>
        /// <param name="continuationToken"> String that sets the continuation token. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ExperimentResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ExperimentResource> GetExperimentsAsync(bool? running = null, string continuationToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ExperimentRestClient.CreateListAllRequest(Id.SubscriptionId, running, continuationToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ExperimentRestClient.CreateListAllNextPageRequest(nextLink, Id.SubscriptionId, running, continuationToken);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ExperimentResource(Client, ExperimentData.DeserializeExperimentData(e)), ExperimentClientDiagnostics, Pipeline, "MockableChaosSubscriptionResource.GetExperiments", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get a list of Experiment resources in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Chaos/experiments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Experiments_ListAll</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="running"> Optional value that indicates whether to filter results based on if the Experiment is currently running. If null, then the results will not be filtered. </param>
        /// <param name="continuationToken"> String that sets the continuation token. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ExperimentResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ExperimentResource> GetExperiments(bool? running = null, string continuationToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ExperimentRestClient.CreateListAllRequest(Id.SubscriptionId, running, continuationToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ExperimentRestClient.CreateListAllNextPageRequest(nextLink, Id.SubscriptionId, running, continuationToken);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ExperimentResource(Client, ExperimentData.DeserializeExperimentData(e)), ExperimentClientDiagnostics, Pipeline, "MockableChaosSubscriptionResource.GetExperiments", "value", "nextLink", cancellationToken);
        }
    }
}
