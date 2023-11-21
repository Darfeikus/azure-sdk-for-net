// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MonitoringFeatureFilterBase : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("filterType"u8);
            writer.WriteStringValue(FilterType.ToString());
            writer.WriteEndObject();
        }

        internal static MonitoringFeatureFilterBase DeserializeMonitoringFeatureFilterBase(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("filterType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AllFeatures": return MachineLearningAllFeatures.DeserializeMachineLearningAllFeatures(element);
                    case "FeatureSubset": return FeatureSubset.DeserializeFeatureSubset(element);
                    case "TopNByAttribution": return TopNFeaturesByAttribution.DeserializeTopNFeaturesByAttribution(element);
                }
            }
            return UnknownMonitoringFeatureFilterBase.DeserializeUnknownMonitoringFeatureFilterBase(element);
        }
    }
}
