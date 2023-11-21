// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Grafana.Models
{
    /// <summary> The parameters for a PATCH request to a managed private endpoint. </summary>
    public partial class ManagedPrivateEndpointModelPatch
    {
        /// <summary> Initializes a new instance of ManagedPrivateEndpointModelPatch. </summary>
        public ManagedPrivateEndpointModelPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> The new tags of the managed private endpoint. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
