// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Management.Models
{
    /// <summary>
    /// Create or update a management group.
    /// If a management group is already created and a subsequent create request is issued with different properties, the management group properties will be updated.
    /// .
    /// </summary>
    public partial class ManagementGroupCreateOrUpdateOperation : Operation<ManagementGroup>, IOperationSource<ManagementGroup>
    {
        private readonly OperationOrResponseInternals<ManagementGroup> _operation;

        private readonly ResourceOperations _operationBase;

        /// <summary> Initializes a new instance of ManagementGroupCreateOrUpdateOperation for mocking. </summary>
        protected ManagementGroupCreateOrUpdateOperation()
        {
        }

        internal ManagementGroupCreateOrUpdateOperation(ResourceOperations operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationOrResponseInternals<ManagementGroup>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.AzureAsyncOperation, "ManagementGroupCreateOrUpdateOperation");
            _operationBase = operationsBase;
        }
        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override ManagementGroup Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<ManagementGroup>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<ManagementGroup>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        ManagementGroup IOperationSource<ManagementGroup>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return new ManagementGroup(_operationBase, ManagementGroupData.DeserializeManagementGroup(document.RootElement));
        }

        async ValueTask<ManagementGroup> IOperationSource<ManagementGroup>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return new ManagementGroup(_operationBase, ManagementGroupData.DeserializeManagementGroup(document.RootElement));
        }
    }
}
