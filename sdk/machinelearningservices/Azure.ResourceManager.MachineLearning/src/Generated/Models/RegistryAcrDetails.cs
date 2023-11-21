// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Details of ACR account to be used for the Registry. </summary>
    public partial class RegistryAcrDetails
    {
        /// <summary> Initializes a new instance of RegistryAcrDetails. </summary>
        public RegistryAcrDetails()
        {
        }

        /// <summary> Initializes a new instance of RegistryAcrDetails. </summary>
        /// <param name="systemCreatedAcrAccount"> Details of system created ACR account to be used for the Registry. </param>
        /// <param name="userCreatedAcrAccount"> Details of user created ACR account to be used for the Registry. Not supported in most cases and will throw 400 error if provided. </param>
        internal RegistryAcrDetails(SystemCreatedAcrAccount systemCreatedAcrAccount, UserCreatedAcrAccount userCreatedAcrAccount)
        {
            SystemCreatedAcrAccount = systemCreatedAcrAccount;
            UserCreatedAcrAccount = userCreatedAcrAccount;
        }

        /// <summary> Details of system created ACR account to be used for the Registry. </summary>
        public SystemCreatedAcrAccount SystemCreatedAcrAccount { get; set; }
        /// <summary> Details of user created ACR account to be used for the Registry. Not supported in most cases and will throw 400 error if provided. </summary>
        internal UserCreatedAcrAccount UserCreatedAcrAccount { get; set; }
        /// <summary>
        /// Arm ResourceId is in the format "/subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.Storage/storageAccounts/{StorageAccountName}"
        /// or "/subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{AcrName}"
        /// </summary>
        public ResourceIdentifier ArmResourceId
        {
            get => UserCreatedAcrAccount is null ? default : UserCreatedAcrAccount.ArmResourceId;
            set
            {
                if (UserCreatedAcrAccount is null)
                    UserCreatedAcrAccount = new UserCreatedAcrAccount();
                UserCreatedAcrAccount.ArmResourceId = value;
            }
        }
    }
}
