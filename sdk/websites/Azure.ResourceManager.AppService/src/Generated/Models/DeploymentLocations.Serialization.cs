// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class DeploymentLocations
    {
        internal static DeploymentLocations DeserializeDeploymentLocations(JsonElement element)
        {
            Optional<IReadOnlyList<GeoRegion>> locations = default;
            Optional<IReadOnlyList<AppServiceEnvironmentAutoGenerated>> hostingEnvironments = default;
            Optional<IReadOnlyList<HostingEnvironmentDeploymentInfo>> hostingEnvironmentDeploymentInfos = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("locations"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<GeoRegion> array = new List<GeoRegion>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(GeoRegion.DeserializeGeoRegion(item));
                    }
                    locations = array;
                    continue;
                }
                if (property.NameEquals("hostingEnvironments"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<AppServiceEnvironmentAutoGenerated> array = new List<AppServiceEnvironmentAutoGenerated>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AppServiceEnvironmentAutoGenerated.DeserializeAppServiceEnvironmentAutoGenerated(item));
                    }
                    hostingEnvironments = array;
                    continue;
                }
                if (property.NameEquals("hostingEnvironmentDeploymentInfos"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<HostingEnvironmentDeploymentInfo> array = new List<HostingEnvironmentDeploymentInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HostingEnvironmentDeploymentInfo.DeserializeHostingEnvironmentDeploymentInfo(item));
                    }
                    hostingEnvironmentDeploymentInfos = array;
                    continue;
                }
            }
            return new DeploymentLocations(Optional.ToList(locations), Optional.ToList(hostingEnvironments), Optional.ToList(hostingEnvironmentDeploymentInfos));
        }
    }
}
