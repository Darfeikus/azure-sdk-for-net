// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.JobRouter
{
    /// <summary> Jobs are distributed in order to workers, starting with the worker that is after the last worker to receive a job. </summary>
    public partial class RoundRobinMode : DistributionMode
    {
        /// <summary> Initializes a new instance of RoundRobinMode. </summary>
        /// <param name="minConcurrentOffers"> Governs the minimum desired number of active concurrent offers a job can have. </param>
        /// <param name="maxConcurrentOffers"> Governs the maximum number of active concurrent offers a job can have. </param>
        /// <param name="bypassSelectors"> If set to true, then router will match workers to jobs even if they don't match label selectors. Warning: You may get workers that are not qualified for a job they are matched with if you set this variable to true. This flag is intended more for temporary usage. By default, set to false. </param>
        /// <param name="kind"> The type discriminator describing a sub-type of DistributionMode. </param>
        internal RoundRobinMode(int minConcurrentOffers, int maxConcurrentOffers, bool? bypassSelectors, DistributionModeKind kind) : base(minConcurrentOffers, maxConcurrentOffers, bypassSelectors, kind)
        {
        }
    }
}
