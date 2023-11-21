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
using Azure.ResourceManager.LoadTesting.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.LoadTesting
{
    /// <summary>
    /// A Class representing a LoadTestingQuota along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="LoadTestingQuotaResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetLoadTestingQuotaResource method.
    /// Otherwise you can get one from its parent resource <see cref="SubscriptionResource"/> using the GetLoadTestingQuota method.
    /// </summary>
    public partial class LoadTestingQuotaResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="LoadTestingQuotaResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="location"> The location. </param>
        /// <param name="quotaBucketName"> The quotaBucketName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, AzureLocation location, string quotaBucketName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.LoadTestService/locations/{location}/quotas/{quotaBucketName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _loadTestingQuotaQuotasClientDiagnostics;
        private readonly QuotasRestOperations _loadTestingQuotaQuotasRestClient;
        private readonly LoadTestingQuotaData _data;

        /// <summary> Initializes a new instance of the <see cref="LoadTestingQuotaResource"/> class for mocking. </summary>
        protected LoadTestingQuotaResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="LoadTestingQuotaResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal LoadTestingQuotaResource(ArmClient client, LoadTestingQuotaData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="LoadTestingQuotaResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal LoadTestingQuotaResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _loadTestingQuotaQuotasClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.LoadTesting", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string loadTestingQuotaQuotasApiVersion);
            _loadTestingQuotaQuotasRestClient = new QuotasRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, loadTestingQuotaQuotasApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.LoadTestService/locations/quotas";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual LoadTestingQuotaData Data
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
        /// Get the available quota for a quota bucket per region per subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.LoadTestService/locations/{location}/quotas/{quotaBucketName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Quotas_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<LoadTestingQuotaResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _loadTestingQuotaQuotasClientDiagnostics.CreateScope("LoadTestingQuotaResource.Get");
            scope.Start();
            try
            {
                var response = await _loadTestingQuotaQuotasRestClient.GetAsync(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LoadTestingQuotaResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the available quota for a quota bucket per region per subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.LoadTestService/locations/{location}/quotas/{quotaBucketName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Quotas_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<LoadTestingQuotaResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _loadTestingQuotaQuotasClientDiagnostics.CreateScope("LoadTestingQuotaResource.Get");
            scope.Start();
            try
            {
                var response = _loadTestingQuotaQuotasRestClient.Get(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LoadTestingQuotaResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Check Quota Availability on quota bucket per region per subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.LoadTestService/locations/{location}/quotas/{quotaBucketName}/checkAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Quotas_CheckAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Quota Bucket Request data. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<Response<LoadTestingQuotaAvailabilityResult>> CheckLoadTestingQuotaAvailabilityAsync(LoadTestingQuotaBucketContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _loadTestingQuotaQuotasClientDiagnostics.CreateScope("LoadTestingQuotaResource.CheckLoadTestingQuotaAvailability");
            scope.Start();
            try
            {
                var response = await _loadTestingQuotaQuotasRestClient.CheckAvailabilityAsync(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Check Quota Availability on quota bucket per region per subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.LoadTestService/locations/{location}/quotas/{quotaBucketName}/checkAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Quotas_CheckAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Quota Bucket Request data. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual Response<LoadTestingQuotaAvailabilityResult> CheckLoadTestingQuotaAvailability(LoadTestingQuotaBucketContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _loadTestingQuotaQuotasClientDiagnostics.CreateScope("LoadTestingQuotaResource.CheckLoadTestingQuotaAvailability");
            scope.Start();
            try
            {
                var response = _loadTestingQuotaQuotasRestClient.CheckAvailability(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
