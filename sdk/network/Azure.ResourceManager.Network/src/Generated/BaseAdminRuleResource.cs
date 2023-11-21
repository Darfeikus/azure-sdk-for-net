// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A Class representing a BaseAdminRule along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="BaseAdminRuleResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetBaseAdminRuleResource method.
    /// Otherwise you can get one from its parent resource <see cref="AdminRuleGroupResource"/> using the GetBaseAdminRule method.
    /// </summary>
    public partial class BaseAdminRuleResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="BaseAdminRuleResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="networkManagerName"> The networkManagerName. </param>
        /// <param name="configurationName"> The configurationName. </param>
        /// <param name="ruleCollectionName"> The ruleCollectionName. </param>
        /// <param name="ruleName"> The ruleName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string networkManagerName, string configurationName, string ruleCollectionName, string ruleName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/securityAdminConfigurations/{configurationName}/ruleCollections/{ruleCollectionName}/rules/{ruleName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _baseAdminRuleAdminRulesClientDiagnostics;
        private readonly AdminRulesRestOperations _baseAdminRuleAdminRulesRestClient;
        private readonly BaseAdminRuleData _data;

        /// <summary> Initializes a new instance of the <see cref="BaseAdminRuleResource"/> class for mocking. </summary>
        protected BaseAdminRuleResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="BaseAdminRuleResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal BaseAdminRuleResource(ArmClient client, BaseAdminRuleData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="BaseAdminRuleResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal BaseAdminRuleResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _baseAdminRuleAdminRulesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string baseAdminRuleAdminRulesApiVersion);
            _baseAdminRuleAdminRulesRestClient = new AdminRulesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, baseAdminRuleAdminRulesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Network/networkManagers/securityAdminConfigurations/ruleCollections/rules";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual BaseAdminRuleData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a network manager security configuration admin rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/securityAdminConfigurations/{configurationName}/ruleCollections/{ruleCollectionName}/rules/{ruleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AdminRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<BaseAdminRuleResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _baseAdminRuleAdminRulesClientDiagnostics.CreateScope("BaseAdminRuleResource.Get");
            scope.Start();
            try
            {
                var response = await _baseAdminRuleAdminRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BaseAdminRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a network manager security configuration admin rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/securityAdminConfigurations/{configurationName}/ruleCollections/{ruleCollectionName}/rules/{ruleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AdminRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<BaseAdminRuleResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _baseAdminRuleAdminRulesClientDiagnostics.CreateScope("BaseAdminRuleResource.Get");
            scope.Start();
            try
            {
                var response = _baseAdminRuleAdminRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BaseAdminRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes an admin rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/securityAdminConfigurations/{configurationName}/ruleCollections/{ruleCollectionName}/rules/{ruleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AdminRules_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="force"> Deletes the resource even if it is part of a deployed configuration. If the configuration has been deployed, the service will do a cleanup deployment in the background, prior to the delete. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, bool? force = null, CancellationToken cancellationToken = default)
        {
            using var scope = _baseAdminRuleAdminRulesClientDiagnostics.CreateScope("BaseAdminRuleResource.Delete");
            scope.Start();
            try
            {
                var response = await _baseAdminRuleAdminRulesRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, force, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation(_baseAdminRuleAdminRulesClientDiagnostics, Pipeline, _baseAdminRuleAdminRulesRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, force).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes an admin rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/securityAdminConfigurations/{configurationName}/ruleCollections/{ruleCollectionName}/rules/{ruleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AdminRules_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="force"> Deletes the resource even if it is part of a deployed configuration. If the configuration has been deployed, the service will do a cleanup deployment in the background, prior to the delete. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, bool? force = null, CancellationToken cancellationToken = default)
        {
            using var scope = _baseAdminRuleAdminRulesClientDiagnostics.CreateScope("BaseAdminRuleResource.Delete");
            scope.Start();
            try
            {
                var response = _baseAdminRuleAdminRulesRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, force, cancellationToken);
                var operation = new NetworkArmOperation(_baseAdminRuleAdminRulesClientDiagnostics, Pipeline, _baseAdminRuleAdminRulesRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, force).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates an admin rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/securityAdminConfigurations/{configurationName}/ruleCollections/{ruleCollectionName}/rules/{ruleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AdminRules_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The admin rule to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<BaseAdminRuleResource>> UpdateAsync(WaitUntil waitUntil, BaseAdminRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _baseAdminRuleAdminRulesClientDiagnostics.CreateScope("BaseAdminRuleResource.Update");
            scope.Start();
            try
            {
                var response = await _baseAdminRuleAdminRulesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<BaseAdminRuleResource>(Response.FromValue(new BaseAdminRuleResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates an admin rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/securityAdminConfigurations/{configurationName}/ruleCollections/{ruleCollectionName}/rules/{ruleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AdminRules_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The admin rule to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<BaseAdminRuleResource> Update(WaitUntil waitUntil, BaseAdminRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _baseAdminRuleAdminRulesClientDiagnostics.CreateScope("BaseAdminRuleResource.Update");
            scope.Start();
            try
            {
                var response = _baseAdminRuleAdminRulesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new NetworkArmOperation<BaseAdminRuleResource>(Response.FromValue(new BaseAdminRuleResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
