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

namespace Azure.ResourceManager.MachineLearning
{
    internal class MachineLearningRegistryDataContainerOperationSource : IOperationSource<MachineLearningRegistryDataContainerResource>
    {
        private readonly ArmClient _client;

        internal MachineLearningRegistryDataContainerOperationSource(ArmClient client)
        {
            _client = client;
        }

        MachineLearningRegistryDataContainerResource IOperationSource<MachineLearningRegistryDataContainerResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = MachineLearningDataContainerData.DeserializeMachineLearningDataContainerData(document.RootElement);
            return new MachineLearningRegistryDataContainerResource(_client, data);
        }

        async ValueTask<MachineLearningRegistryDataContainerResource> IOperationSource<MachineLearningRegistryDataContainerResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = MachineLearningDataContainerData.DeserializeMachineLearningDataContainerData(document.RootElement);
            return new MachineLearningRegistryDataContainerResource(_client, data);
        }
    }
}
