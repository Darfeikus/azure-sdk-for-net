// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class SearchIndexerDataSourceConnection : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type.ToString());
            writer.WritePropertyName("credentials"u8);
            writer.WriteObjectValue(CredentialsInternal);
            writer.WritePropertyName("container"u8);
            writer.WriteObjectValue(Container);
            if (Optional.IsDefined(DataChangeDetectionPolicy))
            {
                if (DataChangeDetectionPolicy != null)
                {
                    writer.WritePropertyName("dataChangeDetectionPolicy"u8);
                    writer.WriteObjectValue(DataChangeDetectionPolicy);
                }
                else
                {
                    writer.WriteNull("dataChangeDetectionPolicy");
                }
            }
            if (Optional.IsDefined(DataDeletionDetectionPolicy))
            {
                if (DataDeletionDetectionPolicy != null)
                {
                    writer.WritePropertyName("dataDeletionDetectionPolicy"u8);
                    writer.WriteObjectValue(DataDeletionDetectionPolicy);
                }
                else
                {
                    writer.WriteNull("dataDeletionDetectionPolicy");
                }
            }
            if (Optional.IsDefined(_etag))
            {
                writer.WritePropertyName("@odata.etag"u8);
                writer.WriteStringValue(_etag);
            }
            if (Optional.IsDefined(EncryptionKey))
            {
                if (EncryptionKey != null)
                {
                    writer.WritePropertyName("encryptionKey"u8);
                    writer.WriteObjectValue(EncryptionKey);
                }
                else
                {
                    writer.WriteNull("encryptionKey");
                }
            }
            writer.WriteEndObject();
        }

        internal static SearchIndexerDataSourceConnection DeserializeSearchIndexerDataSourceConnection(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            Optional<string> description = default;
            SearchIndexerDataSourceType type = default;
            DataSourceCredentials credentials = default;
            SearchIndexerDataContainer container = default;
            Optional<DataChangeDetectionPolicy> dataChangeDetectionPolicy = default;
            Optional<DataDeletionDetectionPolicy> dataDeletionDetectionPolicy = default;
            Optional<string> odataEtag = default;
            Optional<SearchResourceEncryptionKey> encryptionKey = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new SearchIndexerDataSourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("credentials"u8))
                {
                    credentials = DataSourceCredentials.DeserializeDataSourceCredentials(property.Value);
                    continue;
                }
                if (property.NameEquals("container"u8))
                {
                    container = SearchIndexerDataContainer.DeserializeSearchIndexerDataContainer(property.Value);
                    continue;
                }
                if (property.NameEquals("dataChangeDetectionPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        dataChangeDetectionPolicy = null;
                        continue;
                    }
                    dataChangeDetectionPolicy = DataChangeDetectionPolicy.DeserializeDataChangeDetectionPolicy(property.Value);
                    continue;
                }
                if (property.NameEquals("dataDeletionDetectionPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        dataDeletionDetectionPolicy = null;
                        continue;
                    }
                    dataDeletionDetectionPolicy = DataDeletionDetectionPolicy.DeserializeDataDeletionDetectionPolicy(property.Value);
                    continue;
                }
                if (property.NameEquals("@odata.etag"u8))
                {
                    odataEtag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("encryptionKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        encryptionKey = null;
                        continue;
                    }
                    encryptionKey = SearchResourceEncryptionKey.DeserializeSearchResourceEncryptionKey(property.Value);
                    continue;
                }
            }
            return new SearchIndexerDataSourceConnection(name, description.Value, type, credentials, container, dataChangeDetectionPolicy.Value, dataDeletionDetectionPolicy.Value, odataEtag.Value, encryptionKey.Value);
        }
    }
}
