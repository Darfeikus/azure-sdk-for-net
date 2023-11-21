// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class DynamicMetricCriteria : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("operator"u8);
            writer.WriteStringValue(Operator.ToString());
            writer.WritePropertyName("alertSensitivity"u8);
            writer.WriteStringValue(AlertSensitivity.ToString());
            writer.WritePropertyName("failingPeriods"u8);
            writer.WriteObjectValue(FailingPeriods);
            if (Optional.IsDefined(IgnoreDataBefore))
            {
                writer.WritePropertyName("ignoreDataBefore"u8);
                writer.WriteStringValue(IgnoreDataBefore.Value, "O");
            }
            writer.WritePropertyName("criterionType"u8);
            writer.WriteStringValue(CriterionType.ToString());
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("metricName"u8);
            writer.WriteStringValue(MetricName);
            if (Optional.IsDefined(MetricNamespace))
            {
                writer.WritePropertyName("metricNamespace"u8);
                writer.WriteStringValue(MetricNamespace);
            }
            writer.WritePropertyName("timeAggregation"u8);
            writer.WriteStringValue(TimeAggregation.ToString());
            if (Optional.IsCollectionDefined(Dimensions))
            {
                writer.WritePropertyName("dimensions"u8);
                writer.WriteStartArray();
                foreach (var item in Dimensions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(SkipMetricValidation))
            {
                writer.WritePropertyName("skipMetricValidation"u8);
                writer.WriteBooleanValue(SkipMetricValidation.Value);
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

        internal static DynamicMetricCriteria DeserializeDynamicMetricCriteria(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DynamicThresholdOperator @operator = default;
            DynamicThresholdSensitivity alertSensitivity = default;
            DynamicThresholdFailingPeriods failingPeriods = default;
            Optional<DateTimeOffset> ignoreDataBefore = default;
            CriterionType criterionType = default;
            string name = default;
            string metricName = default;
            Optional<string> metricNamespace = default;
            MetricCriteriaTimeAggregationType timeAggregation = default;
            Optional<IList<MetricDimension>> dimensions = default;
            Optional<bool> skipMetricValidation = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("operator"u8))
                {
                    @operator = new DynamicThresholdOperator(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("alertSensitivity"u8))
                {
                    alertSensitivity = new DynamicThresholdSensitivity(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("failingPeriods"u8))
                {
                    failingPeriods = DynamicThresholdFailingPeriods.DeserializeDynamicThresholdFailingPeriods(property.Value);
                    continue;
                }
                if (property.NameEquals("ignoreDataBefore"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ignoreDataBefore = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("criterionType"u8))
                {
                    criterionType = new CriterionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metricName"u8))
                {
                    metricName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metricNamespace"u8))
                {
                    metricNamespace = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timeAggregation"u8))
                {
                    timeAggregation = new MetricCriteriaTimeAggregationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dimensions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MetricDimension> array = new List<MetricDimension>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MetricDimension.DeserializeMetricDimension(item));
                    }
                    dimensions = array;
                    continue;
                }
                if (property.NameEquals("skipMetricValidation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    skipMetricValidation = property.Value.GetBoolean();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new DynamicMetricCriteria(criterionType, name, metricName, metricNamespace.Value, timeAggregation, Optional.ToList(dimensions), Optional.ToNullable(skipMetricValidation), additionalProperties, @operator, alertSensitivity, failingPeriods, Optional.ToNullable(ignoreDataBefore));
        }
    }
}
