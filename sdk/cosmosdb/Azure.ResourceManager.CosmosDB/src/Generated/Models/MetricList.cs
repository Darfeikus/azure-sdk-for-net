// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The response to a list metrics request. </summary>
    internal partial class MetricList
    {
        /// <summary> Initializes a new instance of MetricList. </summary>
        internal MetricList()
        {
            Value = new ChangeTrackingList<BaseMetric>();
        }

        /// <summary> Initializes a new instance of MetricList. </summary>
        /// <param name="value"> The list of metrics for the account. </param>
        internal MetricList(IReadOnlyList<BaseMetric> value)
        {
            Value = value;
        }

        /// <summary> The list of metrics for the account. </summary>
        public IReadOnlyList<BaseMetric> Value { get; }
    }
}
