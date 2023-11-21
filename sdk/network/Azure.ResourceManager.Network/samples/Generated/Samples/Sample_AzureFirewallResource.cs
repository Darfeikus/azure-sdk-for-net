// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.Network;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_AzureFirewallResource
    {
        // Delete Azure Firewall
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteAzureFirewall()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-06-01/examples/AzureFirewallDelete.json
            // this example is just showing the usage of "AzureFirewalls_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AzureFirewallResource created on azure
            // for more information of creating AzureFirewallResource, please refer to the document of AzureFirewallResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string azureFirewallName = "azurefirewall";
            ResourceIdentifier azureFirewallResourceId = AzureFirewallResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, azureFirewallName);
            AzureFirewallResource azureFirewall = client.GetAzureFirewallResource(azureFirewallResourceId);

            // invoke the operation
            await azureFirewall.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Get Azure Firewall
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAzureFirewall()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-06-01/examples/AzureFirewallGet.json
            // this example is just showing the usage of "AzureFirewalls_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AzureFirewallResource created on azure
            // for more information of creating AzureFirewallResource, please refer to the document of AzureFirewallResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string azureFirewallName = "azurefirewall";
            ResourceIdentifier azureFirewallResourceId = AzureFirewallResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, azureFirewallName);
            AzureFirewallResource azureFirewall = client.GetAzureFirewallResource(azureFirewallResourceId);

            // invoke the operation
            AzureFirewallResource result = await azureFirewall.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AzureFirewallData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get Azure Firewall With Additional Properties
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAzureFirewallWithAdditionalProperties()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-06-01/examples/AzureFirewallGetWithAdditionalProperties.json
            // this example is just showing the usage of "AzureFirewalls_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AzureFirewallResource created on azure
            // for more information of creating AzureFirewallResource, please refer to the document of AzureFirewallResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string azureFirewallName = "azurefirewall";
            ResourceIdentifier azureFirewallResourceId = AzureFirewallResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, azureFirewallName);
            AzureFirewallResource azureFirewall = client.GetAzureFirewallResource(azureFirewallResourceId);

            // invoke the operation
            AzureFirewallResource result = await azureFirewall.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AzureFirewallData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get Azure Firewall With IpGroups
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAzureFirewallWithIpGroups()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-06-01/examples/AzureFirewallGetWithIpGroups.json
            // this example is just showing the usage of "AzureFirewalls_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AzureFirewallResource created on azure
            // for more information of creating AzureFirewallResource, please refer to the document of AzureFirewallResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string azureFirewallName = "azurefirewall";
            ResourceIdentifier azureFirewallResourceId = AzureFirewallResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, azureFirewallName);
            AzureFirewallResource azureFirewall = client.GetAzureFirewallResource(azureFirewallResourceId);

            // invoke the operation
            AzureFirewallResource result = await azureFirewall.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AzureFirewallData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get Azure Firewall With Zones
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAzureFirewallWithZones()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-06-01/examples/AzureFirewallGetWithZones.json
            // this example is just showing the usage of "AzureFirewalls_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AzureFirewallResource created on azure
            // for more information of creating AzureFirewallResource, please refer to the document of AzureFirewallResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string azureFirewallName = "azurefirewall";
            ResourceIdentifier azureFirewallResourceId = AzureFirewallResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, azureFirewallName);
            AzureFirewallResource azureFirewall = client.GetAzureFirewallResource(azureFirewallResourceId);

            // invoke the operation
            AzureFirewallResource result = await azureFirewall.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AzureFirewallData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get Azure Firewall With management subnet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAzureFirewallWithManagementSubnet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-06-01/examples/AzureFirewallGetWithMgmtSubnet.json
            // this example is just showing the usage of "AzureFirewalls_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AzureFirewallResource created on azure
            // for more information of creating AzureFirewallResource, please refer to the document of AzureFirewallResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string azureFirewallName = "azurefirewall";
            ResourceIdentifier azureFirewallResourceId = AzureFirewallResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, azureFirewallName);
            AzureFirewallResource azureFirewall = client.GetAzureFirewallResource(azureFirewallResourceId);

            // invoke the operation
            AzureFirewallResource result = await azureFirewall.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AzureFirewallData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Update Azure Firewall Tags
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateAzureFirewallTags()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-06-01/examples/AzureFirewallUpdateTags.json
            // this example is just showing the usage of "AzureFirewalls_UpdateTags" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AzureFirewallResource created on azure
            // for more information of creating AzureFirewallResource, please refer to the document of AzureFirewallResource
            string subscriptionId = "subid";
            string resourceGroupName = "azfwtest";
            string azureFirewallName = "fw1";
            ResourceIdentifier azureFirewallResourceId = AzureFirewallResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, azureFirewallName);
            AzureFirewallResource azureFirewall = client.GetAzureFirewallResource(azureFirewallResourceId);

            // invoke the operation
            NetworkTagsObject networkTagsObject = new NetworkTagsObject()
            {
                Tags =
{
["tag1"] = "value1",
["tag2"] = "value2",
},
            };
            ArmOperation<AzureFirewallResource> lro = await azureFirewall.UpdateAsync(WaitUntil.Completed, networkTagsObject);
            AzureFirewallResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AzureFirewallData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // List all Azure Firewalls for a given subscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAzureFirewalls_ListAllAzureFirewallsForAGivenSubscription()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-06-01/examples/AzureFirewallListBySubscription.json
            // this example is just showing the usage of "AzureFirewalls_ListAll" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "subid";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (AzureFirewallResource item in subscriptionResource.GetAzureFirewallsAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AzureFirewallData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // AzureFirewallListLearnedPrefixes
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetLearnedPrefixes_AzureFirewallListLearnedPrefixes()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-06-01/examples/AzureFirewallListLearnedIPPrefixes.json
            // this example is just showing the usage of "AzureFirewalls_ListLearnedPrefixes" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AzureFirewallResource created on azure
            // for more information of creating AzureFirewallResource, please refer to the document of AzureFirewallResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string azureFirewallName = "azureFirewall1";
            ResourceIdentifier azureFirewallResourceId = AzureFirewallResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, azureFirewallName);
            AzureFirewallResource azureFirewall = client.GetAzureFirewallResource(azureFirewallResourceId);

            // invoke the operation
            ArmOperation<LearnedIPPrefixesListResult> lro = await azureFirewall.GetLearnedPrefixesAsync(WaitUntil.Completed);
            LearnedIPPrefixesListResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // AzureFirewallPacketCapture
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task PacketCapture_AzureFirewallPacketCapture()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-06-01/examples/AzureFirewallPacketCapture.json
            // this example is just showing the usage of "AzureFirewalls_PacketCapture" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AzureFirewallResource created on azure
            // for more information of creating AzureFirewallResource, please refer to the document of AzureFirewallResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string azureFirewallName = "azureFirewall1";
            ResourceIdentifier azureFirewallResourceId = AzureFirewallResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, azureFirewallName);
            AzureFirewallResource azureFirewall = client.GetAzureFirewallResource(azureFirewallResourceId);

            // invoke the operation
            FirewallPacketCaptureContent content = new FirewallPacketCaptureContent()
            {
                DurationInSeconds = 300,
                NumberOfPacketsToCapture = 5000,
                SasUri = new Uri("someSASURL"),
                FileName = "azureFirewallPacketCapture",
                Protocol = AzureFirewallNetworkRuleProtocol.Any,
                Flags =
{
new AzureFirewallPacketCaptureFlags()
{
FlagsType = AzureFirewallPacketCaptureFlagsType.Syn,
},new AzureFirewallPacketCaptureFlags()
{
FlagsType = AzureFirewallPacketCaptureFlagsType.Fin,
}
},
                Filters =
{
new AzureFirewallPacketCaptureRule()
{
Sources =
{
"20.1.1.0"
},
Destinations =
{
"20.1.2.0"
},
DestinationPorts =
{
"4500"
},
},new AzureFirewallPacketCaptureRule()
{
Sources =
{
"10.1.1.0","10.1.1.1"
},
Destinations =
{
"10.1.2.0"
},
DestinationPorts =
{
"123","80"
},
}
},
            };
            await azureFirewall.PacketCaptureAsync(WaitUntil.Completed, content);

            Console.WriteLine($"Succeeded");
        }
    }
}
