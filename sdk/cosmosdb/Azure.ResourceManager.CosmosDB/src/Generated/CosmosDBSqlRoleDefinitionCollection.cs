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
using Azure.ResourceManager.CosmosDB.Models;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary>
    /// A class representing a collection of <see cref="CosmosDBSqlRoleDefinitionResource"/> and their operations.
    /// Each <see cref="CosmosDBSqlRoleDefinitionResource"/> in the collection will belong to the same instance of <see cref="CosmosDBAccountResource"/>.
    /// To get a <see cref="CosmosDBSqlRoleDefinitionCollection"/> instance call the GetCosmosDBSqlRoleDefinitions method from an instance of <see cref="CosmosDBAccountResource"/>.
    /// </summary>
    public partial class CosmosDBSqlRoleDefinitionCollection : ArmCollection, IEnumerable<CosmosDBSqlRoleDefinitionResource>, IAsyncEnumerable<CosmosDBSqlRoleDefinitionResource>
    {
        private readonly ClientDiagnostics _cosmosDBSqlRoleDefinitionSqlResourcesClientDiagnostics;
        private readonly SqlResourcesRestOperations _cosmosDBSqlRoleDefinitionSqlResourcesRestClient;

        /// <summary> Initializes a new instance of the <see cref="CosmosDBSqlRoleDefinitionCollection"/> class for mocking. </summary>
        protected CosmosDBSqlRoleDefinitionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CosmosDBSqlRoleDefinitionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal CosmosDBSqlRoleDefinitionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _cosmosDBSqlRoleDefinitionSqlResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CosmosDB", CosmosDBSqlRoleDefinitionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(CosmosDBSqlRoleDefinitionResource.ResourceType, out string cosmosDBSqlRoleDefinitionSqlResourcesApiVersion);
            _cosmosDBSqlRoleDefinitionSqlResourcesRestClient = new SqlResourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, cosmosDBSqlRoleDefinitionSqlResourcesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != CosmosDBAccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, CosmosDBAccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates an Azure Cosmos DB SQL Role Definition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlRoleDefinitions/{roleDefinitionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlResources_CreateUpdateSqlRoleDefinition</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="roleDefinitionId"> The GUID for the Role Definition. </param>
        /// <param name="content"> The properties required to create or update a Role Definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleDefinitionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleDefinitionId"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<CosmosDBSqlRoleDefinitionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string roleDefinitionId, CosmosDBSqlRoleDefinitionCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleDefinitionId, nameof(roleDefinitionId));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _cosmosDBSqlRoleDefinitionSqlResourcesClientDiagnostics.CreateScope("CosmosDBSqlRoleDefinitionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _cosmosDBSqlRoleDefinitionSqlResourcesRestClient.CreateUpdateSqlRoleDefinitionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, roleDefinitionId, content, cancellationToken).ConfigureAwait(false);
                var operation = new CosmosDBArmOperation<CosmosDBSqlRoleDefinitionResource>(new CosmosDBSqlRoleDefinitionOperationSource(Client), _cosmosDBSqlRoleDefinitionSqlResourcesClientDiagnostics, Pipeline, _cosmosDBSqlRoleDefinitionSqlResourcesRestClient.CreateCreateUpdateSqlRoleDefinitionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, roleDefinitionId, content).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates an Azure Cosmos DB SQL Role Definition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlRoleDefinitions/{roleDefinitionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlResources_CreateUpdateSqlRoleDefinition</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="roleDefinitionId"> The GUID for the Role Definition. </param>
        /// <param name="content"> The properties required to create or update a Role Definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleDefinitionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleDefinitionId"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<CosmosDBSqlRoleDefinitionResource> CreateOrUpdate(WaitUntil waitUntil, string roleDefinitionId, CosmosDBSqlRoleDefinitionCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleDefinitionId, nameof(roleDefinitionId));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _cosmosDBSqlRoleDefinitionSqlResourcesClientDiagnostics.CreateScope("CosmosDBSqlRoleDefinitionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _cosmosDBSqlRoleDefinitionSqlResourcesRestClient.CreateUpdateSqlRoleDefinition(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, roleDefinitionId, content, cancellationToken);
                var operation = new CosmosDBArmOperation<CosmosDBSqlRoleDefinitionResource>(new CosmosDBSqlRoleDefinitionOperationSource(Client), _cosmosDBSqlRoleDefinitionSqlResourcesClientDiagnostics, Pipeline, _cosmosDBSqlRoleDefinitionSqlResourcesRestClient.CreateCreateUpdateSqlRoleDefinitionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, roleDefinitionId, content).Request, response, OperationFinalStateVia.Location);
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
        /// Retrieves the properties of an existing Azure Cosmos DB SQL Role Definition with the given Id.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlRoleDefinitions/{roleDefinitionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlResources_GetSqlRoleDefinition</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleDefinitionId"> The GUID for the Role Definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleDefinitionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleDefinitionId"/> is null. </exception>
        public virtual async Task<Response<CosmosDBSqlRoleDefinitionResource>> GetAsync(string roleDefinitionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleDefinitionId, nameof(roleDefinitionId));

            using var scope = _cosmosDBSqlRoleDefinitionSqlResourcesClientDiagnostics.CreateScope("CosmosDBSqlRoleDefinitionCollection.Get");
            scope.Start();
            try
            {
                var response = await _cosmosDBSqlRoleDefinitionSqlResourcesRestClient.GetSqlRoleDefinitionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, roleDefinitionId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CosmosDBSqlRoleDefinitionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves the properties of an existing Azure Cosmos DB SQL Role Definition with the given Id.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlRoleDefinitions/{roleDefinitionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlResources_GetSqlRoleDefinition</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleDefinitionId"> The GUID for the Role Definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleDefinitionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleDefinitionId"/> is null. </exception>
        public virtual Response<CosmosDBSqlRoleDefinitionResource> Get(string roleDefinitionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleDefinitionId, nameof(roleDefinitionId));

            using var scope = _cosmosDBSqlRoleDefinitionSqlResourcesClientDiagnostics.CreateScope("CosmosDBSqlRoleDefinitionCollection.Get");
            scope.Start();
            try
            {
                var response = _cosmosDBSqlRoleDefinitionSqlResourcesRestClient.GetSqlRoleDefinition(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, roleDefinitionId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CosmosDBSqlRoleDefinitionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves the list of all Azure Cosmos DB SQL Role Definitions.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlRoleDefinitions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlResources_ListSqlRoleDefinitions</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CosmosDBSqlRoleDefinitionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CosmosDBSqlRoleDefinitionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _cosmosDBSqlRoleDefinitionSqlResourcesRestClient.CreateListSqlRoleDefinitionsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new CosmosDBSqlRoleDefinitionResource(Client, CosmosDBSqlRoleDefinitionData.DeserializeCosmosDBSqlRoleDefinitionData(e)), _cosmosDBSqlRoleDefinitionSqlResourcesClientDiagnostics, Pipeline, "CosmosDBSqlRoleDefinitionCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Retrieves the list of all Azure Cosmos DB SQL Role Definitions.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlRoleDefinitions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlResources_ListSqlRoleDefinitions</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CosmosDBSqlRoleDefinitionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CosmosDBSqlRoleDefinitionResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _cosmosDBSqlRoleDefinitionSqlResourcesRestClient.CreateListSqlRoleDefinitionsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new CosmosDBSqlRoleDefinitionResource(Client, CosmosDBSqlRoleDefinitionData.DeserializeCosmosDBSqlRoleDefinitionData(e)), _cosmosDBSqlRoleDefinitionSqlResourcesClientDiagnostics, Pipeline, "CosmosDBSqlRoleDefinitionCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlRoleDefinitions/{roleDefinitionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlResources_GetSqlRoleDefinition</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleDefinitionId"> The GUID for the Role Definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleDefinitionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleDefinitionId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string roleDefinitionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleDefinitionId, nameof(roleDefinitionId));

            using var scope = _cosmosDBSqlRoleDefinitionSqlResourcesClientDiagnostics.CreateScope("CosmosDBSqlRoleDefinitionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _cosmosDBSqlRoleDefinitionSqlResourcesRestClient.GetSqlRoleDefinitionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, roleDefinitionId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlRoleDefinitions/{roleDefinitionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlResources_GetSqlRoleDefinition</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleDefinitionId"> The GUID for the Role Definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleDefinitionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleDefinitionId"/> is null. </exception>
        public virtual Response<bool> Exists(string roleDefinitionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleDefinitionId, nameof(roleDefinitionId));

            using var scope = _cosmosDBSqlRoleDefinitionSqlResourcesClientDiagnostics.CreateScope("CosmosDBSqlRoleDefinitionCollection.Exists");
            scope.Start();
            try
            {
                var response = _cosmosDBSqlRoleDefinitionSqlResourcesRestClient.GetSqlRoleDefinition(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, roleDefinitionId, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlRoleDefinitions/{roleDefinitionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlResources_GetSqlRoleDefinition</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleDefinitionId"> The GUID for the Role Definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleDefinitionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleDefinitionId"/> is null. </exception>
        public virtual async Task<NullableResponse<CosmosDBSqlRoleDefinitionResource>> GetIfExistsAsync(string roleDefinitionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleDefinitionId, nameof(roleDefinitionId));

            using var scope = _cosmosDBSqlRoleDefinitionSqlResourcesClientDiagnostics.CreateScope("CosmosDBSqlRoleDefinitionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _cosmosDBSqlRoleDefinitionSqlResourcesRestClient.GetSqlRoleDefinitionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, roleDefinitionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<CosmosDBSqlRoleDefinitionResource>(response.GetRawResponse());
                return Response.FromValue(new CosmosDBSqlRoleDefinitionResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlRoleDefinitions/{roleDefinitionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlResources_GetSqlRoleDefinition</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleDefinitionId"> The GUID for the Role Definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleDefinitionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleDefinitionId"/> is null. </exception>
        public virtual NullableResponse<CosmosDBSqlRoleDefinitionResource> GetIfExists(string roleDefinitionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleDefinitionId, nameof(roleDefinitionId));

            using var scope = _cosmosDBSqlRoleDefinitionSqlResourcesClientDiagnostics.CreateScope("CosmosDBSqlRoleDefinitionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _cosmosDBSqlRoleDefinitionSqlResourcesRestClient.GetSqlRoleDefinition(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, roleDefinitionId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<CosmosDBSqlRoleDefinitionResource>(response.GetRawResponse());
                return Response.FromValue(new CosmosDBSqlRoleDefinitionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<CosmosDBSqlRoleDefinitionResource> IEnumerable<CosmosDBSqlRoleDefinitionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CosmosDBSqlRoleDefinitionResource> IAsyncEnumerable<CosmosDBSqlRoleDefinitionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
