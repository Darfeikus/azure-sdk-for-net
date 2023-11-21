// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class OriginGroupOverrideActionProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("typeName"u8);
            writer.WriteStringValue(ActionType.ToString());
            writer.WritePropertyName("originGroup"u8);
            JsonSerializer.Serialize(writer, OriginGroup);
            writer.WriteEndObject();
        }

        internal static OriginGroupOverrideActionProperties DeserializeOriginGroupOverrideActionProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            OriginGroupOverrideActionType typeName = default;
            WritableSubResource originGroup = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("typeName"u8))
                {
                    typeName = new OriginGroupOverrideActionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("originGroup"u8))
                {
                    originGroup = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
            }
            return new OriginGroupOverrideActionProperties(typeName, originGroup);
        }
    }
}
