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

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw
{
    /// <summary>
    /// A Class representing a LocalRulestackCertificateObject along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="LocalRulestackCertificateObjectResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetLocalRulestackCertificateObjectResource method.
    /// Otherwise you can get one from its parent resource <see cref="LocalRulestackResource"/> using the GetLocalRulestackCertificateObject method.
    /// </summary>
    public partial class LocalRulestackCertificateObjectResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="LocalRulestackCertificateObjectResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="localRulestackName"> The localRulestackName. </param>
        /// <param name="name"> The name. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string localRulestackName, string name)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PaloAltoNetworks.Cloudngfw/localRulestacks/{localRulestackName}/certificates/{name}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _localRulestackCertificateObjectCertificateObjectLocalRulestackClientDiagnostics;
        private readonly CertificateObjectLocalRulestackRestOperations _localRulestackCertificateObjectCertificateObjectLocalRulestackRestClient;
        private readonly LocalRulestackCertificateObjectData _data;

        /// <summary> Initializes a new instance of the <see cref="LocalRulestackCertificateObjectResource"/> class for mocking. </summary>
        protected LocalRulestackCertificateObjectResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="LocalRulestackCertificateObjectResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal LocalRulestackCertificateObjectResource(ArmClient client, LocalRulestackCertificateObjectData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="LocalRulestackCertificateObjectResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal LocalRulestackCertificateObjectResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _localRulestackCertificateObjectCertificateObjectLocalRulestackClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.PaloAltoNetworks.Ngfw", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string localRulestackCertificateObjectCertificateObjectLocalRulestackApiVersion);
            _localRulestackCertificateObjectCertificateObjectLocalRulestackRestClient = new CertificateObjectLocalRulestackRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, localRulestackCertificateObjectCertificateObjectLocalRulestackApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "PaloAltoNetworks.Cloudngfw/localRulestacks/certificates";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual LocalRulestackCertificateObjectData Data
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
        /// Get a CertificateObjectLocalRulestackResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PaloAltoNetworks.Cloudngfw/localRulestacks/{localRulestackName}/certificates/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CertificateObjectLocalRulestack_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<LocalRulestackCertificateObjectResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _localRulestackCertificateObjectCertificateObjectLocalRulestackClientDiagnostics.CreateScope("LocalRulestackCertificateObjectResource.Get");
            scope.Start();
            try
            {
                var response = await _localRulestackCertificateObjectCertificateObjectLocalRulestackRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LocalRulestackCertificateObjectResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a CertificateObjectLocalRulestackResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PaloAltoNetworks.Cloudngfw/localRulestacks/{localRulestackName}/certificates/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CertificateObjectLocalRulestack_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<LocalRulestackCertificateObjectResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _localRulestackCertificateObjectCertificateObjectLocalRulestackClientDiagnostics.CreateScope("LocalRulestackCertificateObjectResource.Get");
            scope.Start();
            try
            {
                var response = _localRulestackCertificateObjectCertificateObjectLocalRulestackRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LocalRulestackCertificateObjectResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete a CertificateObjectLocalRulestackResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PaloAltoNetworks.Cloudngfw/localRulestacks/{localRulestackName}/certificates/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CertificateObjectLocalRulestack_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _localRulestackCertificateObjectCertificateObjectLocalRulestackClientDiagnostics.CreateScope("LocalRulestackCertificateObjectResource.Delete");
            scope.Start();
            try
            {
                var response = await _localRulestackCertificateObjectCertificateObjectLocalRulestackRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new NgfwArmOperation(_localRulestackCertificateObjectCertificateObjectLocalRulestackClientDiagnostics, Pipeline, _localRulestackCertificateObjectCertificateObjectLocalRulestackRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Delete a CertificateObjectLocalRulestackResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PaloAltoNetworks.Cloudngfw/localRulestacks/{localRulestackName}/certificates/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CertificateObjectLocalRulestack_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _localRulestackCertificateObjectCertificateObjectLocalRulestackClientDiagnostics.CreateScope("LocalRulestackCertificateObjectResource.Delete");
            scope.Start();
            try
            {
                var response = _localRulestackCertificateObjectCertificateObjectLocalRulestackRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new NgfwArmOperation(_localRulestackCertificateObjectCertificateObjectLocalRulestackClientDiagnostics, Pipeline, _localRulestackCertificateObjectCertificateObjectLocalRulestackRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create a CertificateObjectLocalRulestackResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PaloAltoNetworks.Cloudngfw/localRulestacks/{localRulestackName}/certificates/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CertificateObjectLocalRulestack_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<LocalRulestackCertificateObjectResource>> UpdateAsync(WaitUntil waitUntil, LocalRulestackCertificateObjectData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _localRulestackCertificateObjectCertificateObjectLocalRulestackClientDiagnostics.CreateScope("LocalRulestackCertificateObjectResource.Update");
            scope.Start();
            try
            {
                var response = await _localRulestackCertificateObjectCertificateObjectLocalRulestackRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new NgfwArmOperation<LocalRulestackCertificateObjectResource>(new LocalRulestackCertificateObjectOperationSource(Client), _localRulestackCertificateObjectCertificateObjectLocalRulestackClientDiagnostics, Pipeline, _localRulestackCertificateObjectCertificateObjectLocalRulestackRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create a CertificateObjectLocalRulestackResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PaloAltoNetworks.Cloudngfw/localRulestacks/{localRulestackName}/certificates/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CertificateObjectLocalRulestack_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<LocalRulestackCertificateObjectResource> Update(WaitUntil waitUntil, LocalRulestackCertificateObjectData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _localRulestackCertificateObjectCertificateObjectLocalRulestackClientDiagnostics.CreateScope("LocalRulestackCertificateObjectResource.Update");
            scope.Start();
            try
            {
                var response = _localRulestackCertificateObjectCertificateObjectLocalRulestackRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new NgfwArmOperation<LocalRulestackCertificateObjectResource>(new LocalRulestackCertificateObjectOperationSource(Client), _localRulestackCertificateObjectCertificateObjectLocalRulestackClientDiagnostics, Pipeline, _localRulestackCertificateObjectCertificateObjectLocalRulestackRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
