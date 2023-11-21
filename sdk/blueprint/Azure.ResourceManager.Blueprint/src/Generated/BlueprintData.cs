// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Blueprint.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Blueprint
{
    /// <summary>
    /// A class representing the Blueprint data model.
    /// Represents a Blueprint definition.
    /// </summary>
    public partial class BlueprintData : ResourceData
    {
        /// <summary> Initializes a new instance of BlueprintData. </summary>
        public BlueprintData()
        {
            Parameters = new ChangeTrackingDictionary<string, ParameterDefinition>();
            ResourceGroups = new ChangeTrackingDictionary<string, ResourceGroupDefinition>();
        }

        /// <summary> Initializes a new instance of BlueprintData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="displayName"> One-liner string explain this resource. </param>
        /// <param name="description"> Multi-line explain this resource. </param>
        /// <param name="status"> Status of the blueprint. This field is readonly. </param>
        /// <param name="targetScope"> The scope where this blueprint definition can be assigned. </param>
        /// <param name="parameters"> Parameters required by this blueprint definition. </param>
        /// <param name="resourceGroups"> Resource group placeholders defined by this blueprint definition. </param>
        /// <param name="versions"> Published versions of this blueprint definition. </param>
        /// <param name="layout"> Layout view of the blueprint definition for UI reference. </param>
        internal BlueprintData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string displayName, string description, BlueprintStatus status, BlueprintTargetScope? targetScope, IDictionary<string, ParameterDefinition> parameters, IDictionary<string, ResourceGroupDefinition> resourceGroups, BinaryData versions, BinaryData layout) : base(id, name, resourceType, systemData)
        {
            DisplayName = displayName;
            Description = description;
            Status = status;
            TargetScope = targetScope;
            Parameters = parameters;
            ResourceGroups = resourceGroups;
            Versions = versions;
            Layout = layout;
        }

        /// <summary> One-liner string explain this resource. </summary>
        public string DisplayName { get; set; }
        /// <summary> Multi-line explain this resource. </summary>
        public string Description { get; set; }
        /// <summary> Status of the blueprint. This field is readonly. </summary>
        public BlueprintStatus Status { get; }
        /// <summary> The scope where this blueprint definition can be assigned. </summary>
        public BlueprintTargetScope? TargetScope { get; set; }
        /// <summary> Parameters required by this blueprint definition. </summary>
        public IDictionary<string, ParameterDefinition> Parameters { get; }
        /// <summary> Resource group placeholders defined by this blueprint definition. </summary>
        public IDictionary<string, ResourceGroupDefinition> ResourceGroups { get; }
        /// <summary>
        /// Published versions of this blueprint definition.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData Versions { get; set; }
        /// <summary>
        /// Layout view of the blueprint definition for UI reference.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData Layout { get; }
    }
}
