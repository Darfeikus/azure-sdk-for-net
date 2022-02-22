// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Analytics.Purview.Administration
{
    /// <summary> The PurviewMetadataPolicy service client. </summary>
    [CodeGenClient("PurviewMetadataPolicyClient")]
    [CodeGenSuppress("PurviewMetadataPolicyClient", new Type[] { typeof(Uri), typeof(string), typeof(TokenCredential), typeof(PurviewAccountClientOptions)})]
    public partial class PurviewMetadataPolicyClient
    {
        /// <summary> Initializes a new instance of PurviewMetadataPolicyClient. </summary>
        /// <param name="endpoint"> The endpoint of your Purview account. Example: https://{accountName}.purview.azure.com. </param>
        /// <param name="collectionName"> The String to use. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/>, <paramref name="collectionName"/>, or <paramref name="credential"/> is null. </exception>
        public PurviewMetadataPolicyClient(Uri endpoint, string collectionName, TokenCredential credential, PurviewMetadataClientOptions options = null)
        {
            if (endpoint == null)
            {
                throw new ArgumentNullException(nameof(endpoint));
            }
            if (collectionName == null)
            {
                throw new ArgumentNullException(nameof(collectionName));
            }
            if (credential == null)
            {
                throw new ArgumentNullException(nameof(credential));
            }

            options ??= new PurviewMetadataClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options);
            _tokenCredential = credential;
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), new HttpPipelinePolicy[] { new BearerTokenAuthenticationPolicy(_tokenCredential, AuthorizationScopes) }, new ResponseClassifier());
            _endpoint = endpoint;
            _collectionName = collectionName;
        }
    }
}
