// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A Class representing a BasicPublishingCredentialsPolicyFtp along with the instance operations that can be performed on it. </summary>
    public partial class BasicPublishingCredentialsPolicyFtp : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="BasicPublishingCredentialsPolicyFtp"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/basicPublishingCredentialsPolicies/ftp";
            return new ResourceIdentifier(resourceId);
        }
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly WebAppsRestOperations _webAppsRestClient;
        private readonly CsmPublishingCredentialsPoliciesEntityData _data;

        /// <summary> Initializes a new instance of the <see cref="BasicPublishingCredentialsPolicyFtp"/> class for mocking. </summary>
        protected BasicPublishingCredentialsPolicyFtp()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "BasicPublishingCredentialsPolicyFtp"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal BasicPublishingCredentialsPolicyFtp(ArmResource options, CsmPublishingCredentialsPoliciesEntityData resource) : base(options, resource.Id)
        {
            HasData = true;
            _data = resource;
            Parent = options;
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _webAppsRestClient = new WebAppsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Initializes a new instance of the <see cref="BasicPublishingCredentialsPolicyFtp"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal BasicPublishingCredentialsPolicyFtp(ArmResource options, ResourceIdentifier id) : base(options, id)
        {
            Parent = options;
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _webAppsRestClient = new WebAppsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Initializes a new instance of the <see cref="BasicPublishingCredentialsPolicyFtp"/> class. </summary>
        /// <param name="clientOptions"> The client options to build client context. </param>
        /// <param name="credential"> The credential to build client context. </param>
        /// <param name="uri"> The uri to build client context. </param>
        /// <param name="pipeline"> The pipeline to build client context. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal BasicPublishingCredentialsPolicyFtp(ArmClientOptions clientOptions, TokenCredential credential, Uri uri, HttpPipeline pipeline, ResourceIdentifier id) : base(clientOptions, credential, uri, pipeline, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _webAppsRestClient = new WebAppsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/sites/basicPublishingCredentialsPolicies";

        /// <summary> Gets the valid resource type for the operations. </summary>
        protected override ResourceType ValidResourceType => ResourceType;

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual CsmPublishingCredentialsPoliciesEntityData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        /// <summary> Gets the parent resource of this resource. </summary>
        public ArmResource Parent { get; }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/basicPublishingCredentialsPolicies/ftp
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/basicPublishingCredentialsPolicies/ftp
        /// OperationId: WebApps_GetFtpAllowed
        /// <summary> Description for Returns whether FTP is allowed on the site or not. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<BasicPublishingCredentialsPolicyFtp>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BasicPublishingCredentialsPolicyFtp.Get");
            scope.Start();
            try
            {
                var response = await _webAppsRestClient.GetFtpAllowedAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new BasicPublishingCredentialsPolicyFtp(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/basicPublishingCredentialsPolicies/ftp
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/basicPublishingCredentialsPolicies/ftp
        /// OperationId: WebApps_GetFtpAllowed
        /// <summary> Description for Returns whether FTP is allowed on the site or not. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<BasicPublishingCredentialsPolicyFtp> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BasicPublishingCredentialsPolicyFtp.Get");
            scope.Start();
            try
            {
                var response = _webAppsRestClient.GetFtpAllowed(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BasicPublishingCredentialsPolicyFtp(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public async virtual Task<IEnumerable<AzureLocation>> GetAvailableLocationsAsync(CancellationToken cancellationToken = default)
        {
            return await ListAvailableLocationsAsync(ResourceType, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public virtual IEnumerable<AzureLocation> GetAvailableLocations(CancellationToken cancellationToken = default)
        {
            return ListAvailableLocations(ResourceType, cancellationToken);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/basicPublishingCredentialsPolicies/ftp
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/basicPublishingCredentialsPolicies/ftp
        /// OperationId: WebApps_UpdateFtpAllowed
        /// <summary> Description for Updates whether FTP is allowed on the site or not. </summary>
        /// <param name="csmPublishingAccessPoliciesEntity"> The CsmPublishingCredentialsPoliciesEntity to use. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="csmPublishingAccessPoliciesEntity"/> is null. </exception>
        public async virtual Task<WebAppUpdateFtpAllowedOperation> CreateOrUpdateAsync(CsmPublishingCredentialsPoliciesEntityData csmPublishingAccessPoliciesEntity, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (csmPublishingAccessPoliciesEntity == null)
            {
                throw new ArgumentNullException(nameof(csmPublishingAccessPoliciesEntity));
            }

            using var scope = _clientDiagnostics.CreateScope("BasicPublishingCredentialsPolicyFtp.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _webAppsRestClient.UpdateFtpAllowedAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, csmPublishingAccessPoliciesEntity, cancellationToken).ConfigureAwait(false);
                var operation = new WebAppUpdateFtpAllowedOperation(this, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/basicPublishingCredentialsPolicies/ftp
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/basicPublishingCredentialsPolicies/ftp
        /// OperationId: WebApps_UpdateFtpAllowed
        /// <summary> Description for Updates whether FTP is allowed on the site or not. </summary>
        /// <param name="csmPublishingAccessPoliciesEntity"> The CsmPublishingCredentialsPoliciesEntity to use. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="csmPublishingAccessPoliciesEntity"/> is null. </exception>
        public virtual WebAppUpdateFtpAllowedOperation CreateOrUpdate(CsmPublishingCredentialsPoliciesEntityData csmPublishingAccessPoliciesEntity, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (csmPublishingAccessPoliciesEntity == null)
            {
                throw new ArgumentNullException(nameof(csmPublishingAccessPoliciesEntity));
            }

            using var scope = _clientDiagnostics.CreateScope("BasicPublishingCredentialsPolicyFtp.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _webAppsRestClient.UpdateFtpAllowed(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, csmPublishingAccessPoliciesEntity, cancellationToken);
                var operation = new WebAppUpdateFtpAllowedOperation(this, response);
                if (waitForCompletion)
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
