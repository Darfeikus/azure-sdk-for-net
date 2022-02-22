// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.WebPubSub
{
    internal class WebPubSubHubOperationSource : IOperationSource<WebPubSubHub>
    {
        private readonly ArmClient _client;

        internal WebPubSubHubOperationSource(ArmClient client)
        {
            _client = client;
        }

        WebPubSubHub IOperationSource<WebPubSubHub>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = WebPubSubHubData.DeserializeWebPubSubHubData(document.RootElement);
            return new WebPubSubHub(_client, data);
        }

        async ValueTask<WebPubSubHub> IOperationSource<WebPubSubHub>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = WebPubSubHubData.DeserializeWebPubSubHubData(document.RootElement);
            return new WebPubSubHub(_client, data);
        }
    }
}
