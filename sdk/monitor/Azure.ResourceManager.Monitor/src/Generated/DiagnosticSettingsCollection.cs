// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Monitor
{
    /// <summary> A class representing collection of DiagnosticSettings and their operations over its parent. </summary>
    public partial class DiagnosticSettingsCollection : ArmCollection, IEnumerable<DiagnosticSettings>, IAsyncEnumerable<DiagnosticSettings>
    {
        private readonly ClientDiagnostics _diagnosticSettingsDiagnosticSettingsClientDiagnostics;
        private readonly DiagnosticSettingsRestOperations _diagnosticSettingsDiagnosticSettingsRestClient;

        /// <summary> Initializes a new instance of the <see cref="DiagnosticSettingsCollection"/> class for mocking. </summary>
        protected DiagnosticSettingsCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DiagnosticSettingsCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DiagnosticSettingsCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _diagnosticSettingsDiagnosticSettingsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Monitor", DiagnosticSettings.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(DiagnosticSettings.ResourceType, out string diagnosticSettingsDiagnosticSettingsApiVersion);
            _diagnosticSettingsDiagnosticSettingsRestClient = new DiagnosticSettingsRestOperations(_diagnosticSettingsDiagnosticSettingsClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, diagnosticSettingsDiagnosticSettingsApiVersion);
        }

        /// <summary>
        /// Creates or updates diagnostic settings for the specified resource.
        /// Request Path: /{resourceUri}/providers/Microsoft.Insights/diagnosticSettings/{name}
        /// Operation Id: DiagnosticSettings_CreateOrUpdate
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="name"> The name of the diagnostic setting. </param>
        /// <param name="parameters"> Parameters supplied to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ArmOperation<DiagnosticSettings>> CreateOrUpdateAsync(bool waitForCompletion, string name, DiagnosticSettingsData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _diagnosticSettingsDiagnosticSettingsClientDiagnostics.CreateScope("DiagnosticSettingsCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _diagnosticSettingsDiagnosticSettingsRestClient.CreateOrUpdateAsync(Id, name, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new MonitorArmOperation<DiagnosticSettings>(Response.FromValue(new DiagnosticSettings(Client, response), response.GetRawResponse()));
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

        /// <summary>
        /// Creates or updates diagnostic settings for the specified resource.
        /// Request Path: /{resourceUri}/providers/Microsoft.Insights/diagnosticSettings/{name}
        /// Operation Id: DiagnosticSettings_CreateOrUpdate
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="name"> The name of the diagnostic setting. </param>
        /// <param name="parameters"> Parameters supplied to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<DiagnosticSettings> CreateOrUpdate(bool waitForCompletion, string name, DiagnosticSettingsData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _diagnosticSettingsDiagnosticSettingsClientDiagnostics.CreateScope("DiagnosticSettingsCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _diagnosticSettingsDiagnosticSettingsRestClient.CreateOrUpdate(Id, name, parameters, cancellationToken);
                var operation = new MonitorArmOperation<DiagnosticSettings>(Response.FromValue(new DiagnosticSettings(Client, response), response.GetRawResponse()));
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

        /// <summary>
        /// Gets the active diagnostic settings for the specified resource.
        /// Request Path: /{resourceUri}/providers/Microsoft.Insights/diagnosticSettings/{name}
        /// Operation Id: DiagnosticSettings_Get
        /// </summary>
        /// <param name="name"> The name of the diagnostic setting. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public async virtual Task<Response<DiagnosticSettings>> GetAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _diagnosticSettingsDiagnosticSettingsClientDiagnostics.CreateScope("DiagnosticSettingsCollection.Get");
            scope.Start();
            try
            {
                var response = await _diagnosticSettingsDiagnosticSettingsRestClient.GetAsync(Id, name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _diagnosticSettingsDiagnosticSettingsClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new DiagnosticSettings(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the active diagnostic settings for the specified resource.
        /// Request Path: /{resourceUri}/providers/Microsoft.Insights/diagnosticSettings/{name}
        /// Operation Id: DiagnosticSettings_Get
        /// </summary>
        /// <param name="name"> The name of the diagnostic setting. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<DiagnosticSettings> Get(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _diagnosticSettingsDiagnosticSettingsClientDiagnostics.CreateScope("DiagnosticSettingsCollection.Get");
            scope.Start();
            try
            {
                var response = _diagnosticSettingsDiagnosticSettingsRestClient.Get(Id, name, cancellationToken);
                if (response.Value == null)
                    throw _diagnosticSettingsDiagnosticSettingsClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DiagnosticSettings(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the active diagnostic settings list for the specified resource.
        /// Request Path: /{resourceUri}/providers/Microsoft.Insights/diagnosticSettings
        /// Operation Id: DiagnosticSettings_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DiagnosticSettings" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DiagnosticSettings> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<DiagnosticSettings>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _diagnosticSettingsDiagnosticSettingsClientDiagnostics.CreateScope("DiagnosticSettingsCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _diagnosticSettingsDiagnosticSettingsRestClient.ListAsync(Id, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DiagnosticSettings(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Gets the active diagnostic settings list for the specified resource.
        /// Request Path: /{resourceUri}/providers/Microsoft.Insights/diagnosticSettings
        /// Operation Id: DiagnosticSettings_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DiagnosticSettings" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DiagnosticSettings> GetAll(CancellationToken cancellationToken = default)
        {
            Page<DiagnosticSettings> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _diagnosticSettingsDiagnosticSettingsClientDiagnostics.CreateScope("DiagnosticSettingsCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _diagnosticSettingsDiagnosticSettingsRestClient.List(Id, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DiagnosticSettings(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /{resourceUri}/providers/Microsoft.Insights/diagnosticSettings/{name}
        /// Operation Id: DiagnosticSettings_Get
        /// </summary>
        /// <param name="name"> The name of the diagnostic setting. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _diagnosticSettingsDiagnosticSettingsClientDiagnostics.CreateScope("DiagnosticSettingsCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(name, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /{resourceUri}/providers/Microsoft.Insights/diagnosticSettings/{name}
        /// Operation Id: DiagnosticSettings_Get
        /// </summary>
        /// <param name="name"> The name of the diagnostic setting. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<bool> Exists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _diagnosticSettingsDiagnosticSettingsClientDiagnostics.CreateScope("DiagnosticSettingsCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(name, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /{resourceUri}/providers/Microsoft.Insights/diagnosticSettings/{name}
        /// Operation Id: DiagnosticSettings_Get
        /// </summary>
        /// <param name="name"> The name of the diagnostic setting. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public async virtual Task<Response<DiagnosticSettings>> GetIfExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _diagnosticSettingsDiagnosticSettingsClientDiagnostics.CreateScope("DiagnosticSettingsCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _diagnosticSettingsDiagnosticSettingsRestClient.GetAsync(Id, name, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<DiagnosticSettings>(null, response.GetRawResponse());
                return Response.FromValue(new DiagnosticSettings(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /{resourceUri}/providers/Microsoft.Insights/diagnosticSettings/{name}
        /// Operation Id: DiagnosticSettings_Get
        /// </summary>
        /// <param name="name"> The name of the diagnostic setting. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<DiagnosticSettings> GetIfExists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _diagnosticSettingsDiagnosticSettingsClientDiagnostics.CreateScope("DiagnosticSettingsCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _diagnosticSettingsDiagnosticSettingsRestClient.Get(Id, name, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<DiagnosticSettings>(null, response.GetRawResponse());
                return Response.FromValue(new DiagnosticSettings(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DiagnosticSettings> IEnumerable<DiagnosticSettings>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DiagnosticSettings> IAsyncEnumerable<DiagnosticSettings>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
