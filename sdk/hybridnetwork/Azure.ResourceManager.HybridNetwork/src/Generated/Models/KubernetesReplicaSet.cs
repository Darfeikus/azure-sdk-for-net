// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    /// <summary> Helm ReplicaSet status properties. </summary>
    public partial class KubernetesReplicaSet
    {
        /// <summary> Initializes a new instance of KubernetesReplicaSet. </summary>
        internal KubernetesReplicaSet()
        {
        }

        /// <summary> Initializes a new instance of KubernetesReplicaSet. </summary>
        /// <param name="name"> The name of the replicaSet. </param>
        /// <param name="namespace"> The namespace of the replicaSet. </param>
        /// <param name="desiredNumberOfPods"> Desired number of pods. </param>
        /// <param name="readyNumberOfPods"> Number of ready pods. </param>
        /// <param name="currentNumberOfPods"> Number of current pods. </param>
        /// <param name="createdOn"> Creation Time of replicaSet. </param>
        internal KubernetesReplicaSet(string name, string @namespace, int? desiredNumberOfPods, int? readyNumberOfPods, int? currentNumberOfPods, DateTimeOffset? createdOn)
        {
            Name = name;
            Namespace = @namespace;
            DesiredNumberOfPods = desiredNumberOfPods;
            ReadyNumberOfPods = readyNumberOfPods;
            CurrentNumberOfPods = currentNumberOfPods;
            CreatedOn = createdOn;
        }

        /// <summary> The name of the replicaSet. </summary>
        public string Name { get; }
        /// <summary> The namespace of the replicaSet. </summary>
        public string Namespace { get; }
        /// <summary> Desired number of pods. </summary>
        public int? DesiredNumberOfPods { get; }
        /// <summary> Number of ready pods. </summary>
        public int? ReadyNumberOfPods { get; }
        /// <summary> Number of current pods. </summary>
        public int? CurrentNumberOfPods { get; }
        /// <summary> Creation Time of replicaSet. </summary>
        public DateTimeOffset? CreatedOn { get; }
    }
}
