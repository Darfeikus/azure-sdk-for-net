// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class RestorableSqlDatabasePropertiesResource
    {
        internal static RestorableSqlDatabasePropertiesResource DeserializeRestorableSqlDatabasePropertiesResource(JsonElement element)
        {
            Optional<string> rid = default;
            Optional<OperationType> operationType = default;
            Optional<string> eventTimestamp = default;
            Optional<string> ownerId = default;
            Optional<string> ownerResourceId = default;
            Optional<RestorableSqlDatabasePropertiesResourceDatabase> database = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("_rid"))
                {
                    rid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("operationType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    operationType = new OperationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("eventTimestamp"))
                {
                    eventTimestamp = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ownerId"))
                {
                    ownerId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ownerResourceId"))
                {
                    ownerResourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("database"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    database = RestorableSqlDatabasePropertiesResourceDatabase.DeserializeRestorableSqlDatabasePropertiesResourceDatabase(property.Value);
                    continue;
                }
            }
            return new RestorableSqlDatabasePropertiesResource(rid.Value, Optional.ToNullable(operationType), eventTimestamp.Value, ownerId.Value, ownerResourceId.Value, database.Value);
        }
    }
}
