// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetApp.Models
{
    internal partial class VolumeSnapshotProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SnapshotPolicyId))
            {
                writer.WritePropertyName("snapshotPolicyId"u8);
                writer.WriteStringValue(SnapshotPolicyId);
            }
            writer.WriteEndObject();
        }

        internal static VolumeSnapshotProperties DeserializeVolumeSnapshotProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> snapshotPolicyId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("snapshotPolicyId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null || property.Value.ValueKind == JsonValueKind.String && property.Value.GetString().Length == 0)
                    {
                        continue;
                    }
                    snapshotPolicyId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
            }
            return new VolumeSnapshotProperties(snapshotPolicyId.Value);
        }
    }
}
