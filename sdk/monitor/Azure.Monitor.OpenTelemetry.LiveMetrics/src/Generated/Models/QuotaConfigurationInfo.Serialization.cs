// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Monitor.OpenTelemetry.LiveMetrics.Models
{
    internal partial class QuotaConfigurationInfo
    {
        internal static QuotaConfigurationInfo DeserializeQuotaConfigurationInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<float> initialQuota = default;
            float maxQuota = default;
            float quotaAccrualRatePerSec = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("InitialQuota"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    initialQuota = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("MaxQuota"u8))
                {
                    maxQuota = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("QuotaAccrualRatePerSec"u8))
                {
                    quotaAccrualRatePerSec = property.Value.GetSingle();
                    continue;
                }
            }
            return new QuotaConfigurationInfo(Optional.ToNullable(initialQuota), maxQuota, quotaAccrualRatePerSec);
        }
    }
}
