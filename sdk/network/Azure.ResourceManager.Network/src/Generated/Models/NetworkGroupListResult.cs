// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Result of the request to list NetworkGroup. It contains a list of groups and a URL link to get the next set of results. </summary>
    internal partial class NetworkGroupListResult
    {
        /// <summary> Initializes a new instance of <see cref="NetworkGroupListResult"/>. </summary>
        internal NetworkGroupListResult()
        {
            Value = new ChangeTrackingList<NetworkGroupData>();
        }

        /// <summary> Initializes a new instance of <see cref="NetworkGroupListResult"/>. </summary>
        /// <param name="value"> Gets a page of NetworkGroup. </param>
        /// <param name="nextLink"> Gets the URL to get the next set of results. </param>
        internal NetworkGroupListResult(IReadOnlyList<NetworkGroupData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Gets a page of NetworkGroup. </summary>
        public IReadOnlyList<NetworkGroupData> Value { get; }
        /// <summary> Gets the URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
