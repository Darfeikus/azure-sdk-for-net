// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Monitor.Models;

namespace Azure.ResourceManager.Monitor
{
    /// <summary> A class representing the MetricAlert data model. </summary>
    public partial class MetricAlertData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of MetricAlertData. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="severity"> Alert severity {0, 1, 2, 3, 4}. </param>
        /// <param name="enabled"> the flag that indicates whether the metric alert is enabled. </param>
        /// <param name="scopes"> the list of resource id&apos;s that this metric alert is scoped to. </param>
        /// <param name="evaluationFrequency"> how often the metric alert is evaluated represented in ISO 8601 duration format. </param>
        /// <param name="windowSize"> the period of time (in ISO 8601 duration format) that is used to monitor alert activity based on the threshold. </param>
        /// <param name="criteria"> defines the specific alert criteria information. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scopes"/> is null. </exception>
        public MetricAlertData(AzureLocation location, int severity, bool enabled, IEnumerable<string> scopes, TimeSpan evaluationFrequency, TimeSpan windowSize, MetricAlertCriteria criteria) : base(location)
        {
            if (scopes == null)
            {
                throw new ArgumentNullException(nameof(scopes));
            }

            Severity = severity;
            Enabled = enabled;
            Scopes = scopes.ToList();
            EvaluationFrequency = evaluationFrequency;
            WindowSize = windowSize;
            Criteria = criteria;
            Actions = new ChangeTrackingList<MetricAlertAction>();
        }

        /// <summary> Initializes a new instance of MetricAlertData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="description"> the description of the metric alert that will be included in the alert email. </param>
        /// <param name="severity"> Alert severity {0, 1, 2, 3, 4}. </param>
        /// <param name="enabled"> the flag that indicates whether the metric alert is enabled. </param>
        /// <param name="scopes"> the list of resource id&apos;s that this metric alert is scoped to. </param>
        /// <param name="evaluationFrequency"> how often the metric alert is evaluated represented in ISO 8601 duration format. </param>
        /// <param name="windowSize"> the period of time (in ISO 8601 duration format) that is used to monitor alert activity based on the threshold. </param>
        /// <param name="targetResourceType"> the resource type of the target resource(s) on which the alert is created/updated. Mandatory if the scope contains a subscription, resource group, or more than one resource. </param>
        /// <param name="targetResourceRegion"> the region of the target resource(s) on which the alert is created/updated. Mandatory if the scope contains a subscription, resource group, or more than one resource. </param>
        /// <param name="criteria"> defines the specific alert criteria information. </param>
        /// <param name="autoMitigate"> the flag that indicates whether the alert should be auto resolved or not. The default is true. </param>
        /// <param name="actions"> the array of actions that are performed when the alert rule becomes active, and when an alert condition is resolved. </param>
        /// <param name="lastUpdatedTime"> Last time the rule was updated in ISO8601 format. </param>
        /// <param name="isMigrated"> the value indicating whether this alert rule is migrated. </param>
        internal MetricAlertData(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string description, int severity, bool enabled, IList<string> scopes, TimeSpan evaluationFrequency, TimeSpan windowSize, string targetResourceType, string targetResourceRegion, MetricAlertCriteria criteria, bool? autoMitigate, IList<MetricAlertAction> actions, DateTimeOffset? lastUpdatedTime, bool? isMigrated) : base(id, name, type, systemData, tags, location)
        {
            Description = description;
            Severity = severity;
            Enabled = enabled;
            Scopes = scopes;
            EvaluationFrequency = evaluationFrequency;
            WindowSize = windowSize;
            TargetResourceType = targetResourceType;
            TargetResourceRegion = targetResourceRegion;
            Criteria = criteria;
            AutoMitigate = autoMitigate;
            Actions = actions;
            LastUpdatedTime = lastUpdatedTime;
            IsMigrated = isMigrated;
        }

        /// <summary> the description of the metric alert that will be included in the alert email. </summary>
        public string Description { get; set; }
        /// <summary> Alert severity {0, 1, 2, 3, 4}. </summary>
        public int Severity { get; set; }
        /// <summary> the flag that indicates whether the metric alert is enabled. </summary>
        public bool Enabled { get; set; }
        /// <summary> the list of resource id&apos;s that this metric alert is scoped to. </summary>
        public IList<string> Scopes { get; }
        /// <summary> how often the metric alert is evaluated represented in ISO 8601 duration format. </summary>
        public TimeSpan EvaluationFrequency { get; set; }
        /// <summary> the period of time (in ISO 8601 duration format) that is used to monitor alert activity based on the threshold. </summary>
        public TimeSpan WindowSize { get; set; }
        /// <summary> the resource type of the target resource(s) on which the alert is created/updated. Mandatory if the scope contains a subscription, resource group, or more than one resource. </summary>
        public string TargetResourceType { get; set; }
        /// <summary> the region of the target resource(s) on which the alert is created/updated. Mandatory if the scope contains a subscription, resource group, or more than one resource. </summary>
        public string TargetResourceRegion { get; set; }
        /// <summary> defines the specific alert criteria information. </summary>
        public MetricAlertCriteria Criteria { get; set; }
        /// <summary> the flag that indicates whether the alert should be auto resolved or not. The default is true. </summary>
        public bool? AutoMitigate { get; set; }
        /// <summary> the array of actions that are performed when the alert rule becomes active, and when an alert condition is resolved. </summary>
        public IList<MetricAlertAction> Actions { get; }
        /// <summary> Last time the rule was updated in ISO8601 format. </summary>
        public DateTimeOffset? LastUpdatedTime { get; }
        /// <summary> the value indicating whether this alert rule is migrated. </summary>
        public bool? IsMigrated { get; }
    }
}
