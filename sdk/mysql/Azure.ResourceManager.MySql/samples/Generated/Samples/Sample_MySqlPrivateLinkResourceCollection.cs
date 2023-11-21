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
using Azure.ResourceManager.MySql;

namespace Azure.ResourceManager.MySql.Samples
{
    public partial class Sample_MySqlPrivateLinkResourceCollection
    {
        // Gets private link resources for MySQL.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_GetsPrivateLinkResourcesForMySQL()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/legacy/stable/2018-06-01/examples/PrivateLinkResourcesList.json
            // this example is just showing the usage of "PrivateLinkResources_ListByServer" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MySqlServerResource created on azure
            // for more information of creating MySqlServerResource, please refer to the document of MySqlServerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "Default";
            string serverName = "test-svr";
            ResourceIdentifier mySqlServerResourceId = MySqlServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            MySqlServerResource mySqlServer = client.GetMySqlServerResource(mySqlServerResourceId);

            // get the collection of this MySqlPrivateLinkResource
            MySqlPrivateLinkResourceCollection collection = mySqlServer.GetMySqlPrivateLinkResources();

            // invoke the operation and iterate over the result
            await foreach (MySqlPrivateLinkResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MySqlPrivateLinkResourceData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Gets a private link resource for MySQL.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetsAPrivateLinkResourceForMySQL()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/legacy/stable/2018-06-01/examples/PrivateLinkResourcesGet.json
            // this example is just showing the usage of "PrivateLinkResources_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MySqlServerResource created on azure
            // for more information of creating MySqlServerResource, please refer to the document of MySqlServerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "Default";
            string serverName = "test-svr";
            ResourceIdentifier mySqlServerResourceId = MySqlServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            MySqlServerResource mySqlServer = client.GetMySqlServerResource(mySqlServerResourceId);

            // get the collection of this MySqlPrivateLinkResource
            MySqlPrivateLinkResourceCollection collection = mySqlServer.GetMySqlPrivateLinkResources();

            // invoke the operation
            string groupName = "plr";
            MySqlPrivateLinkResource result = await collection.GetAsync(groupName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MySqlPrivateLinkResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Gets a private link resource for MySQL.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetsAPrivateLinkResourceForMySQL()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/legacy/stable/2018-06-01/examples/PrivateLinkResourcesGet.json
            // this example is just showing the usage of "PrivateLinkResources_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MySqlServerResource created on azure
            // for more information of creating MySqlServerResource, please refer to the document of MySqlServerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "Default";
            string serverName = "test-svr";
            ResourceIdentifier mySqlServerResourceId = MySqlServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            MySqlServerResource mySqlServer = client.GetMySqlServerResource(mySqlServerResourceId);

            // get the collection of this MySqlPrivateLinkResource
            MySqlPrivateLinkResourceCollection collection = mySqlServer.GetMySqlPrivateLinkResources();

            // invoke the operation
            string groupName = "plr";
            bool result = await collection.ExistsAsync(groupName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Gets a private link resource for MySQL.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetsAPrivateLinkResourceForMySQL()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/legacy/stable/2018-06-01/examples/PrivateLinkResourcesGet.json
            // this example is just showing the usage of "PrivateLinkResources_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MySqlServerResource created on azure
            // for more information of creating MySqlServerResource, please refer to the document of MySqlServerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "Default";
            string serverName = "test-svr";
            ResourceIdentifier mySqlServerResourceId = MySqlServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            MySqlServerResource mySqlServer = client.GetMySqlServerResource(mySqlServerResourceId);

            // get the collection of this MySqlPrivateLinkResource
            MySqlPrivateLinkResourceCollection collection = mySqlServer.GetMySqlPrivateLinkResources();

            // invoke the operation
            string groupName = "plr";
            NullableResponse<MySqlPrivateLinkResource> response = await collection.GetIfExistsAsync(groupName);
            MySqlPrivateLinkResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MySqlPrivateLinkResourceData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
