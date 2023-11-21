// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningCompute.Models
{
    public partial class GlobalServiceConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (Optional.IsDefined(Ssl))
            {
                writer.WritePropertyName("ssl"u8);
                writer.WriteObjectValue(Ssl);
            }
            if (Optional.IsDefined(ServiceAuth))
            {
                writer.WritePropertyName("serviceAuth"u8);
                writer.WriteObjectValue(ServiceAuth);
            }
            if (Optional.IsDefined(AutoScale))
            {
                writer.WritePropertyName("autoScale"u8);
                writer.WriteObjectValue(AutoScale);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                using (JsonDocument document = JsonDocument.Parse(item.Value))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            writer.WriteEndObject();
        }

        internal static GlobalServiceConfiguration DeserializeGlobalServiceConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ETag> etag = default;
            Optional<SslConfiguration> ssl = default;
            Optional<ServiceAuthConfiguration> serviceAuth = default;
            Optional<AutoScaleConfiguration> autoScale = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ssl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ssl = SslConfiguration.DeserializeSslConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("serviceAuth"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    serviceAuth = ServiceAuthConfiguration.DeserializeServiceAuthConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("autoScale"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    autoScale = AutoScaleConfiguration.DeserializeAutoScaleConfiguration(property.Value);
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new GlobalServiceConfiguration(Optional.ToNullable(etag), ssl.Value, serviceAuth.Value, autoScale.Value, additionalProperties);
        }
    }
}
