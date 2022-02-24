// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> An alert status. </summary>
    public partial class MetricAlertStatus : ResourceData
    {
        /// <summary> Initializes a new instance of MetricAlertStatus. </summary>
        internal MetricAlertStatus()
        {
        }

        /// <summary> Initializes a new instance of MetricAlertStatus. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> The alert status properties of the metric alert status. </param>
        internal MetricAlertStatus(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, MetricAlertStatusProperties properties) : base(id, name, type, systemData)
        {
            Properties = properties;
        }

        /// <summary> The alert status properties of the metric alert status. </summary>
        public MetricAlertStatusProperties Properties { get; }
    }
}
