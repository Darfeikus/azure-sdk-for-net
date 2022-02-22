// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Backup.CrossRegionRestore.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Operation status.
    /// </summary>
    public partial class OperationStatus
    {
        /// <summary>
        /// Initializes a new instance of the OperationStatus class.
        /// </summary>
        public OperationStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OperationStatus class.
        /// </summary>
        /// <param name="id">ID of the operation.</param>
        /// <param name="name">Name of the operation.</param>
        /// <param name="status">Operation status. Possible values include:
        /// 'Invalid', 'InProgress', 'Succeeded', 'Failed', 'Canceled'</param>
        /// <param name="startTime">Operation start time. Format:
        /// ISO-8601.</param>
        /// <param name="endTime">Operation end time. Format: ISO-8601.</param>
        /// <param name="error">Error information related to this
        /// operation.</param>
        /// <param name="properties">Additional information associated with
        /// this operation.</param>
        public OperationStatus(string id = default(string), string name = default(string), string status = default(string), System.DateTime? startTime = default(System.DateTime?), System.DateTime? endTime = default(System.DateTime?), OperationStatusError error = default(OperationStatusError), OperationStatusExtendedInfo properties = default(OperationStatusExtendedInfo))
        {
            Id = id;
            Name = name;
            Status = status;
            StartTime = startTime;
            EndTime = endTime;
            Error = error;
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets ID of the operation.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets name of the operation.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets operation status. Possible values include: 'Invalid',
        /// 'InProgress', 'Succeeded', 'Failed', 'Canceled'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets operation start time. Format: ISO-8601.
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public System.DateTime? StartTime { get; set; }

        /// <summary>
        /// Gets or sets operation end time. Format: ISO-8601.
        /// </summary>
        [JsonProperty(PropertyName = "endTime")]
        public System.DateTime? EndTime { get; set; }

        /// <summary>
        /// Gets or sets error information related to this operation.
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public OperationStatusError Error { get; set; }

        /// <summary>
        /// Gets or sets additional information associated with this operation.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public OperationStatusExtendedInfo Properties { get; set; }

    }
}
