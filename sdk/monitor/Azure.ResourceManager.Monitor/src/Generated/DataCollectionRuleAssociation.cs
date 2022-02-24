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

namespace Azure.ResourceManager.Monitor
{
    /// <summary> A Class representing a DataCollectionRuleAssociation along with the instance operations that can be performed on it. </summary>
    public partial class DataCollectionRuleAssociation : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="DataCollectionRuleAssociation"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string resourceUri, string associationName)
        {
            var resourceId = $"{resourceUri}/providers/Microsoft.Insights/dataCollectionRuleAssociations/{associationName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _dataCollectionRuleAssociationClientDiagnostics;
        private readonly DataCollectionRuleAssociationsRestOperations _dataCollectionRuleAssociationRestClient;
        private readonly DataCollectionRuleAssociationData _data;

        /// <summary> Initializes a new instance of the <see cref="DataCollectionRuleAssociation"/> class for mocking. </summary>
        protected DataCollectionRuleAssociation()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "DataCollectionRuleAssociation"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal DataCollectionRuleAssociation(ArmClient client, DataCollectionRuleAssociationData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="DataCollectionRuleAssociation"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DataCollectionRuleAssociation(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dataCollectionRuleAssociationClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Monitor", ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ResourceType, out string dataCollectionRuleAssociationApiVersion);
            _dataCollectionRuleAssociationRestClient = new DataCollectionRuleAssociationsRestOperations(_dataCollectionRuleAssociationClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, dataCollectionRuleAssociationApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Insights/dataCollectionRuleAssociations";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual DataCollectionRuleAssociationData Data
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
        /// Returns the specified association.
        /// Request Path: /{resourceUri}/providers/Microsoft.Insights/dataCollectionRuleAssociations/{associationName}
        /// Operation Id: DataCollectionRuleAssociations_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<DataCollectionRuleAssociation>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _dataCollectionRuleAssociationClientDiagnostics.CreateScope("DataCollectionRuleAssociation.Get");
            scope.Start();
            try
            {
                var response = await _dataCollectionRuleAssociationRestClient.GetAsync(Id.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
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
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DataCollectionRuleAssociation> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _dataCollectionRuleAssociationClientDiagnostics.CreateScope("DataCollectionRuleAssociation.Get");
            scope.Start();
            try
            {
                var response = _dataCollectionRuleAssociationRestClient.Get(Id.Parent, Id.Name, cancellationToken);
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
        /// Deletes an association.
        /// Request Path: /{resourceUri}/providers/Microsoft.Insights/dataCollectionRuleAssociations/{associationName}
        /// Operation Id: DataCollectionRuleAssociations_Delete
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<ArmOperation> DeleteAsync(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _dataCollectionRuleAssociationClientDiagnostics.CreateScope("DataCollectionRuleAssociation.Delete");
            scope.Start();
            try
            {
                var response = await _dataCollectionRuleAssociationRestClient.DeleteAsync(Id.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new MonitorArmOperation(response);
                if (waitForCompletion)
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
        /// Deletes an association.
        /// Request Path: /{resourceUri}/providers/Microsoft.Insights/dataCollectionRuleAssociations/{associationName}
        /// Operation Id: DataCollectionRuleAssociations_Delete
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _dataCollectionRuleAssociationClientDiagnostics.CreateScope("DataCollectionRuleAssociation.Delete");
            scope.Start();
            try
            {
                var response = _dataCollectionRuleAssociationRestClient.Delete(Id.Parent, Id.Name, cancellationToken);
                var operation = new MonitorArmOperation(response);
                if (waitForCompletion)
                    operation.WaitForCompletionResponse(cancellationToken);
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
