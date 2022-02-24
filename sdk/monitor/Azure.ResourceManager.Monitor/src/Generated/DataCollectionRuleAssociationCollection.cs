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
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Monitor
{
    /// <summary> A class representing collection of DataCollectionRuleAssociation and their operations over its parent. </summary>
    public partial class DataCollectionRuleAssociationCollection : ArmCollection, IEnumerable<DataCollectionRuleAssociation>, IAsyncEnumerable<DataCollectionRuleAssociation>
    {
        private readonly ClientDiagnostics _dataCollectionRuleAssociationClientDiagnostics;
        private readonly DataCollectionRuleAssociationsRestOperations _dataCollectionRuleAssociationRestClient;

        /// <summary> Initializes a new instance of the <see cref="DataCollectionRuleAssociationCollection"/> class for mocking. </summary>
        protected DataCollectionRuleAssociationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DataCollectionRuleAssociationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DataCollectionRuleAssociationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dataCollectionRuleAssociationClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Monitor", DataCollectionRuleAssociation.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(DataCollectionRuleAssociation.ResourceType, out string dataCollectionRuleAssociationApiVersion);
            _dataCollectionRuleAssociationRestClient = new DataCollectionRuleAssociationsRestOperations(_dataCollectionRuleAssociationClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, dataCollectionRuleAssociationApiVersion);
        }

        /// <summary>
        /// Creates or updates an association.
        /// Request Path: /{resourceUri}/providers/Microsoft.Insights/dataCollectionRuleAssociations/{associationName}
        /// Operation Id: DataCollectionRuleAssociations_Create
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="associationName"> The name of the association. The name is case insensitive. </param>
        /// <param name="body"> The payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="associationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="associationName"/> is null. </exception>
        public async virtual Task<ArmOperation<DataCollectionRuleAssociation>> CreateOrUpdateAsync(bool waitForCompletion, string associationName, DataCollectionRuleAssociationData body = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(associationName, nameof(associationName));

            using var scope = _dataCollectionRuleAssociationClientDiagnostics.CreateScope("DataCollectionRuleAssociationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _dataCollectionRuleAssociationRestClient.CreateAsync(Id, associationName, body, cancellationToken).ConfigureAwait(false);
                var operation = new MonitorArmOperation<DataCollectionRuleAssociation>(Response.FromValue(new DataCollectionRuleAssociation(Client, response), response.GetRawResponse()));
                if (waitForCompletion)
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
        /// Creates or updates an association.
        /// Request Path: /{resourceUri}/providers/Microsoft.Insights/dataCollectionRuleAssociations/{associationName}
        /// Operation Id: DataCollectionRuleAssociations_Create
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="associationName"> The name of the association. The name is case insensitive. </param>
        /// <param name="body"> The payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="associationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="associationName"/> is null. </exception>
        public virtual ArmOperation<DataCollectionRuleAssociation> CreateOrUpdate(bool waitForCompletion, string associationName, DataCollectionRuleAssociationData body = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(associationName, nameof(associationName));

            using var scope = _dataCollectionRuleAssociationClientDiagnostics.CreateScope("DataCollectionRuleAssociationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _dataCollectionRuleAssociationRestClient.Create(Id, associationName, body, cancellationToken);
                var operation = new MonitorArmOperation<DataCollectionRuleAssociation>(Response.FromValue(new DataCollectionRuleAssociation(Client, response), response.GetRawResponse()));
                if (waitForCompletion)
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
        /// Returns the specified association.
        /// Request Path: /{resourceUri}/providers/Microsoft.Insights/dataCollectionRuleAssociations/{associationName}
        /// Operation Id: DataCollectionRuleAssociations_Get
        /// </summary>
        /// <param name="associationName"> The name of the association. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="associationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="associationName"/> is null. </exception>
        public async virtual Task<Response<DataCollectionRuleAssociation>> GetAsync(string associationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(associationName, nameof(associationName));

            using var scope = _dataCollectionRuleAssociationClientDiagnostics.CreateScope("DataCollectionRuleAssociationCollection.Get");
            scope.Start();
            try
            {
                var response = await _dataCollectionRuleAssociationRestClient.GetAsync(Id, associationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _dataCollectionRuleAssociationClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new DataCollectionRuleAssociation(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns the specified association.
        /// Request Path: /{resourceUri}/providers/Microsoft.Insights/dataCollectionRuleAssociations/{associationName}
        /// Operation Id: DataCollectionRuleAssociations_Get
        /// </summary>
        /// <param name="associationName"> The name of the association. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="associationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="associationName"/> is null. </exception>
        public virtual Response<DataCollectionRuleAssociation> Get(string associationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(associationName, nameof(associationName));

            using var scope = _dataCollectionRuleAssociationClientDiagnostics.CreateScope("DataCollectionRuleAssociationCollection.Get");
            scope.Start();
            try
            {
                var response = _dataCollectionRuleAssociationRestClient.Get(Id, associationName, cancellationToken);
                if (response.Value == null)
                    throw _dataCollectionRuleAssociationClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataCollectionRuleAssociation(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists associations for the specified resource.
        /// Request Path: /{resourceUri}/providers/Microsoft.Insights/dataCollectionRuleAssociations
        /// Operation Id: DataCollectionRuleAssociations_ListByResource
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataCollectionRuleAssociation" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DataCollectionRuleAssociation> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<DataCollectionRuleAssociation>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _dataCollectionRuleAssociationClientDiagnostics.CreateScope("DataCollectionRuleAssociationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _dataCollectionRuleAssociationRestClient.ListByResourceAsync(Id, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DataCollectionRuleAssociation(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<DataCollectionRuleAssociation>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _dataCollectionRuleAssociationClientDiagnostics.CreateScope("DataCollectionRuleAssociationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _dataCollectionRuleAssociationRestClient.ListByResourceNextPageAsync(nextLink, Id, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DataCollectionRuleAssociation(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Lists associations for the specified resource.
        /// Request Path: /{resourceUri}/providers/Microsoft.Insights/dataCollectionRuleAssociations
        /// Operation Id: DataCollectionRuleAssociations_ListByResource
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataCollectionRuleAssociation" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DataCollectionRuleAssociation> GetAll(CancellationToken cancellationToken = default)
        {
            Page<DataCollectionRuleAssociation> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _dataCollectionRuleAssociationClientDiagnostics.CreateScope("DataCollectionRuleAssociationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _dataCollectionRuleAssociationRestClient.ListByResource(Id, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DataCollectionRuleAssociation(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<DataCollectionRuleAssociation> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _dataCollectionRuleAssociationClientDiagnostics.CreateScope("DataCollectionRuleAssociationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _dataCollectionRuleAssociationRestClient.ListByResourceNextPage(nextLink, Id, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DataCollectionRuleAssociation(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /{resourceUri}/providers/Microsoft.Insights/dataCollectionRuleAssociations/{associationName}
        /// Operation Id: DataCollectionRuleAssociations_Get
        /// </summary>
        /// <param name="associationName"> The name of the association. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="associationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="associationName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string associationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(associationName, nameof(associationName));

            using var scope = _dataCollectionRuleAssociationClientDiagnostics.CreateScope("DataCollectionRuleAssociationCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(associationName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /{resourceUri}/providers/Microsoft.Insights/dataCollectionRuleAssociations/{associationName}
        /// Operation Id: DataCollectionRuleAssociations_Get
        /// </summary>
        /// <param name="associationName"> The name of the association. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="associationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="associationName"/> is null. </exception>
        public virtual Response<bool> Exists(string associationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(associationName, nameof(associationName));

            using var scope = _dataCollectionRuleAssociationClientDiagnostics.CreateScope("DataCollectionRuleAssociationCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(associationName, cancellationToken: cancellationToken);
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
        /// Request Path: /{resourceUri}/providers/Microsoft.Insights/dataCollectionRuleAssociations/{associationName}
        /// Operation Id: DataCollectionRuleAssociations_Get
        /// </summary>
        /// <param name="associationName"> The name of the association. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="associationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="associationName"/> is null. </exception>
        public async virtual Task<Response<DataCollectionRuleAssociation>> GetIfExistsAsync(string associationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(associationName, nameof(associationName));

            using var scope = _dataCollectionRuleAssociationClientDiagnostics.CreateScope("DataCollectionRuleAssociationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _dataCollectionRuleAssociationRestClient.GetAsync(Id, associationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<DataCollectionRuleAssociation>(null, response.GetRawResponse());
                return Response.FromValue(new DataCollectionRuleAssociation(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /{resourceUri}/providers/Microsoft.Insights/dataCollectionRuleAssociations/{associationName}
        /// Operation Id: DataCollectionRuleAssociations_Get
        /// </summary>
        /// <param name="associationName"> The name of the association. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="associationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="associationName"/> is null. </exception>
        public virtual Response<DataCollectionRuleAssociation> GetIfExists(string associationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(associationName, nameof(associationName));

            using var scope = _dataCollectionRuleAssociationClientDiagnostics.CreateScope("DataCollectionRuleAssociationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _dataCollectionRuleAssociationRestClient.Get(Id, associationName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<DataCollectionRuleAssociation>(null, response.GetRawResponse());
                return Response.FromValue(new DataCollectionRuleAssociation(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DataCollectionRuleAssociation> IEnumerable<DataCollectionRuleAssociation>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DataCollectionRuleAssociation> IAsyncEnumerable<DataCollectionRuleAssociation>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
