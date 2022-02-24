// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Monitor
{
    /// <summary> A class representing the PrivateLink data model. </summary>
    public partial class PrivateLinkData : ResourceData
    {
        /// <summary> Initializes a new instance of PrivateLinkData. </summary>
        public PrivateLinkData()
        {
            RequiredMembers = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of PrivateLinkData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="groupId"> The private link resource group id. </param>
        /// <param name="requiredMembers"> The private link resource required member names. </param>
        internal PrivateLinkData(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, string groupId, IReadOnlyList<string> requiredMembers) : base(id, name, type, systemData)
        {
            GroupId = groupId;
            RequiredMembers = requiredMembers;
        }

        /// <summary> The private link resource group id. </summary>
        public string GroupId { get; }
        /// <summary> The private link resource required member names. </summary>
        public IReadOnlyList<string> RequiredMembers { get; }
    }
}
