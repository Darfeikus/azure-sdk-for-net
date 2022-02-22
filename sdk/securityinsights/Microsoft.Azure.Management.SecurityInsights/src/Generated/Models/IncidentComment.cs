// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.SecurityInsights.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Represents an incident comment
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class IncidentComment : ResourceWithEtag
    {
        /// <summary>
        /// Initializes a new instance of the IncidentComment class.
        /// </summary>
        public IncidentComment()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IncidentComment class.
        /// </summary>
        /// <param name="message">The comment message</param>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="systemData">Azure Resource Manager metadata containing
        /// createdBy and modifiedBy information.</param>
        /// <param name="etag">Etag of the azure resource</param>
        /// <param name="createdTimeUtc">The time the comment was
        /// created</param>
        /// <param name="lastModifiedTimeUtc">The time the comment was
        /// updated</param>
        /// <param name="author">Describes the client that created the
        /// comment</param>
        public IncidentComment(string message, string id = default(string), string name = default(string), string type = default(string), SystemData systemData = default(SystemData), string etag = default(string), System.DateTime? createdTimeUtc = default(System.DateTime?), System.DateTime? lastModifiedTimeUtc = default(System.DateTime?), ClientInfo author = default(ClientInfo))
            : base(id, name, type, systemData, etag)
        {
            CreatedTimeUtc = createdTimeUtc;
            LastModifiedTimeUtc = lastModifiedTimeUtc;
            Message = message;
            Author = author;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the time the comment was created
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdTimeUtc")]
        public System.DateTime? CreatedTimeUtc { get; private set; }

        /// <summary>
        /// Gets the time the comment was updated
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastModifiedTimeUtc")]
        public System.DateTime? LastModifiedTimeUtc { get; private set; }

        /// <summary>
        /// Gets or sets the comment message
        /// </summary>
        [JsonProperty(PropertyName = "properties.message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets describes the client that created the comment
        /// </summary>
        [JsonProperty(PropertyName = "properties.author")]
        public ClientInfo Author { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Message == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Message");
            }
        }
    }
}
