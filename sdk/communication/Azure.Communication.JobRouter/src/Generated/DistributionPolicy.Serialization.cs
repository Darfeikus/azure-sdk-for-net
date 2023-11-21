// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.Communication.JobRouter
{
    public partial class DistributionPolicy
    {
        internal static DistributionPolicy DeserializeDistributionPolicy(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string etag = default;
            string id = default;
            Optional<string> name = default;
            Optional<double> offerExpiresAfterSeconds = default;
            Optional<DistributionMode> mode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"u8))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("offerExpiresAfterSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    offerExpiresAfterSeconds = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("mode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mode = DistributionMode.DeserializeDistributionMode(property.Value);
                    continue;
                }
            }
            return new DistributionPolicy(etag, id, name.Value, Optional.ToNullable(offerExpiresAfterSeconds), mode.Value);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static DistributionPolicy FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeDistributionPolicy(document.RootElement);
        }
    }
}
