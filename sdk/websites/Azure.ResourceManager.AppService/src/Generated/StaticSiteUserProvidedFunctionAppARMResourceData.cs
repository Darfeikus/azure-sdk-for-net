// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.AppService.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing the StaticSiteUserProvidedFunctionAppARMResource data model. </summary>
    public partial class StaticSiteUserProvidedFunctionAppARMResourceData : ProxyOnlyResource
    {
        /// <summary> Initializes a new instance of StaticSiteUserProvidedFunctionAppARMResourceData. </summary>
        public StaticSiteUserProvidedFunctionAppARMResourceData()
        {
        }

        /// <summary> Initializes a new instance of StaticSiteUserProvidedFunctionAppARMResourceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="functionAppResourceId"> The resource id of the function app registered with the static site. </param>
        /// <param name="functionAppRegion"> The region of the function app registered with the static site. </param>
        /// <param name="createdOn"> The date and time on which the function app was registered with the static site. </param>
        internal StaticSiteUserProvidedFunctionAppARMResourceData(ResourceIdentifier id, string name, ResourceType type, string kind, string functionAppResourceId, string functionAppRegion, DateTimeOffset? createdOn) : base(id, name, type, kind)
        {
            FunctionAppResourceId = functionAppResourceId;
            FunctionAppRegion = functionAppRegion;
            CreatedOn = createdOn;
        }

        /// <summary> The resource id of the function app registered with the static site. </summary>
        public string FunctionAppResourceId { get; set; }
        /// <summary> The region of the function app registered with the static site. </summary>
        public string FunctionAppRegion { get; set; }
        /// <summary> The date and time on which the function app was registered with the static site. </summary>
        public DateTimeOffset? CreatedOn { get; }
    }
}
