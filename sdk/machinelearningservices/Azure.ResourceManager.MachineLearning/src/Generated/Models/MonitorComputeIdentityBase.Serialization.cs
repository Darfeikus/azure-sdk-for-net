// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MonitorComputeIdentityBase : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("computeIdentityType"u8);
            writer.WriteStringValue(ComputeIdentityType.ToString());
            writer.WriteEndObject();
        }

        internal static MonitorComputeIdentityBase DeserializeMonitorComputeIdentityBase(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("computeIdentityType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AmlToken": return AmlTokenComputeIdentity.DeserializeAmlTokenComputeIdentity(element);
                    case "ManagedIdentity": return ManagedComputeIdentity.DeserializeManagedComputeIdentity(element);
                }
            }
            return UnknownMonitorComputeIdentityBase.DeserializeUnknownMonitorComputeIdentityBase(element);
        }
    }
}
