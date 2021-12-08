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

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Description for Gets the Git/FTP publishing credentials of an app. </summary>
    public partial class WebAppListPublishingCredentialsSlotOperation : Operation<AppServiceUserData>, IOperationSource<AppServiceUserData>
    {
        private readonly OperationInternals<AppServiceUserData> _operation;

        /// <summary> Initializes a new instance of WebAppListPublishingCredentialsSlotOperation for mocking. </summary>
        protected WebAppListPublishingCredentialsSlotOperation()
        {
        }

        internal WebAppListPublishingCredentialsSlotOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<AppServiceUserData>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "WebAppListPublishingCredentialsSlotOperation");
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override AppServiceUserData Value => _operation.Value;

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
        public override ValueTask<Response<AppServiceUserData>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<AppServiceUserData>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        AppServiceUserData IOperationSource<AppServiceUserData>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return AppServiceUserData.DeserializeAppServiceUserData(document.RootElement);
        }

        async ValueTask<AppServiceUserData> IOperationSource<AppServiceUserData>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return AppServiceUserData.DeserializeAppServiceUserData(document.RootElement);
        }
    }
}
