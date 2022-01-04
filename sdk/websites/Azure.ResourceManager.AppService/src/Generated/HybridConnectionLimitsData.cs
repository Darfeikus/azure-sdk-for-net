// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.AppService.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing the HybridConnectionLimits data model. </summary>
    public partial class HybridConnectionLimitsData : ProxyOnlyResource
    {
        /// <summary> Initializes a new instance of HybridConnectionLimitsData. </summary>
        public HybridConnectionLimitsData()
        {
        }

        /// <summary> Initializes a new instance of HybridConnectionLimitsData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="current"> The current number of Hybrid Connections. </param>
        /// <param name="maximum"> The maximum number of Hybrid Connections allowed. </param>
        internal HybridConnectionLimitsData(ResourceIdentifier id, string name, ResourceType type, string kind, int? current, int? maximum) : base(id, name, type, kind)
        {
            Current = current;
            Maximum = maximum;
        }

        /// <summary> The current number of Hybrid Connections. </summary>
        public int? Current { get; }
        /// <summary> The maximum number of Hybrid Connections allowed. </summary>
        public int? Maximum { get; }
    }
}
