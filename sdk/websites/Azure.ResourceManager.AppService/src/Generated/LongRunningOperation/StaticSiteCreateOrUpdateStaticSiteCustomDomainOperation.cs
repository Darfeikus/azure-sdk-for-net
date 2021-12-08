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
    /// <summary> Description for Creates a new static site custom domain in an existing resource group and static site. </summary>
    public partial class StaticSiteCreateOrUpdateStaticSiteCustomDomainOperation : Operation<StaticSiteCustomDomainOverview>, IOperationSource<StaticSiteCustomDomainOverview>
    {
        private readonly OperationInternals<StaticSiteCustomDomainOverview> _operation;

        private readonly ArmResource _operationBase;

        /// <summary> Initializes a new instance of StaticSiteCreateOrUpdateStaticSiteCustomDomainOperation for mocking. </summary>
        protected StaticSiteCreateOrUpdateStaticSiteCustomDomainOperation()
        {
        }

        internal StaticSiteCreateOrUpdateStaticSiteCustomDomainOperation(ArmResource operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<StaticSiteCustomDomainOverview>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "StaticSiteCreateOrUpdateStaticSiteCustomDomainOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override StaticSiteCustomDomainOverview Value => _operation.Value;

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
        public override ValueTask<Response<StaticSiteCustomDomainOverview>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<StaticSiteCustomDomainOverview>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        StaticSiteCustomDomainOverview IOperationSource<StaticSiteCustomDomainOverview>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return new StaticSiteCustomDomainOverview(_operationBase, StaticSiteCustomDomainOverviewData.DeserializeStaticSiteCustomDomainOverviewData(document.RootElement));
        }

        async ValueTask<StaticSiteCustomDomainOverview> IOperationSource<StaticSiteCustomDomainOverview>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return new StaticSiteCustomDomainOverview(_operationBase, StaticSiteCustomDomainOverviewData.DeserializeStaticSiteCustomDomainOverviewData(document.RootElement));
        }
    }
}
