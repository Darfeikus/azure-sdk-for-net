// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> The ContainerCpuStatistics. </summary>
    public partial class ContainerCpuStatistics
    {
        /// <summary> Initializes a new instance of ContainerCpuStatistics. </summary>
        public ContainerCpuStatistics()
        {
        }

        /// <summary> Initializes a new instance of ContainerCpuStatistics. </summary>
        /// <param name="cpuUsage"></param>
        /// <param name="systemCpuUsage"></param>
        /// <param name="onlineCpuCount"></param>
        /// <param name="throttlingData"></param>
        internal ContainerCpuStatistics(ContainerCpuUsage cpuUsage, long? systemCpuUsage, int? onlineCpuCount, ContainerThrottlingData throttlingData)
        {
            CpuUsage = cpuUsage;
            SystemCpuUsage = systemCpuUsage;
            OnlineCpuCount = onlineCpuCount;
            ThrottlingData = throttlingData;
        }

        /// <summary> Gets or sets the cpu usage. </summary>
        public ContainerCpuUsage CpuUsage { get; set; }
        /// <summary> Gets or sets the system cpu usage. </summary>
        public long? SystemCpuUsage { get; set; }
        /// <summary> Gets or sets the online cpu count. </summary>
        public int? OnlineCpuCount { get; set; }
        /// <summary> Gets or sets the throttling data. </summary>
        public ContainerThrottlingData ThrottlingData { get; set; }
    }
}
