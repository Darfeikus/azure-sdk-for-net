// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Post request for Delete Bastion Shareable Link By Token endpoint. </summary>
    public partial class BastionShareableLinkTokenListContent
    {
        /// <summary> Initializes a new instance of BastionShareableLinkTokenListContent. </summary>
        public BastionShareableLinkTokenListContent()
        {
            Tokens = new ChangeTrackingList<string>();
        }

        /// <summary> List of Bastion Shareable Link Token. </summary>
        public IList<string> Tokens { get; }
    }
}
