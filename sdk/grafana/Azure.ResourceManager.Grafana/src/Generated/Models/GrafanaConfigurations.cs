// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Grafana.Models
{
    /// <summary> Server configurations of a Grafana instance. </summary>
    internal partial class GrafanaConfigurations
    {
        /// <summary> Initializes a new instance of GrafanaConfigurations. </summary>
        public GrafanaConfigurations()
        {
        }

        /// <summary> Initializes a new instance of GrafanaConfigurations. </summary>
        /// <param name="smtp">
        /// Email server settings.
        /// https://grafana.com/docs/grafana/v9.0/setup-grafana/configure-grafana/#smtp
        /// </param>
        internal GrafanaConfigurations(Smtp smtp)
        {
            Smtp = smtp;
        }

        /// <summary>
        /// Email server settings.
        /// https://grafana.com/docs/grafana/v9.0/setup-grafana/configure-grafana/#smtp
        /// </summary>
        public Smtp Smtp { get; set; }
    }
}
