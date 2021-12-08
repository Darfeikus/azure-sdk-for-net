// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.AppService;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Description for Creates a new static site in an existing resource group, or updates an existing static site. </summary>
    public partial class StaticSiteCreateOrUpdateStaticSiteOperation : Operation<StaticSite>, IOperationSource<StaticSite>
    {
        private readonly OperationInternals<StaticSite> _operation;

        private readonly ArmResource _operationBase;

        /// <summary> Initializes a new instance of StaticSiteCreateOrUpdateStaticSiteOperation for mocking. </summary>
        protected StaticSiteCreateOrUpdateStaticSiteOperation()
        {
        }

        internal StaticSiteCreateOrUpdateStaticSiteOperation(ArmResource operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<StaticSite>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "StaticSiteCreateOrUpdateStaticSiteOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override StaticSite Value => _operation.Value;

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
        public override ValueTask<Response<StaticSite>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<StaticSite>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        StaticSite IOperationSource<StaticSite>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return new StaticSite(_operationBase, StaticSiteData.DeserializeStaticSiteData(document.RootElement));
        }

        async ValueTask<StaticSite> IOperationSource<StaticSite>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return new StaticSite(_operationBase, StaticSiteData.DeserializeStaticSiteData(document.RootElement));
        }
    }
}
