// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> SharePoint Online List linked service. </summary>
    public partial class SharePointOnlineListLinkedService : LinkedService
    {
        /// <summary> Initializes a new instance of SharePointOnlineListLinkedService. </summary>
        /// <param name="siteUrl"> The URL of the SharePoint Online site. For example, https://contoso.sharepoint.com/sites/siteName. Type: string (or Expression with resultType string). </param>
        /// <param name="tenantId"> The tenant ID under which your application resides. You can find it from Azure portal Active Directory overview page. Type: string (or Expression with resultType string). </param>
        /// <param name="servicePrincipalId"> The application (client) ID of your application registered in Azure Active Directory. Make sure to grant SharePoint site permission to this application. Type: string (or Expression with resultType string). </param>
        /// <param name="servicePrincipalKey"> The client secret of your application registered in Azure Active Directory. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="siteUrl"/>, <paramref name="tenantId"/>, <paramref name="servicePrincipalId"/> or <paramref name="servicePrincipalKey"/> is null. </exception>
        public SharePointOnlineListLinkedService(object siteUrl, object tenantId, object servicePrincipalId, SecretBase servicePrincipalKey)
        {
            if (siteUrl == null)
            {
                throw new ArgumentNullException(nameof(siteUrl));
            }
            if (tenantId == null)
            {
                throw new ArgumentNullException(nameof(tenantId));
            }
            if (servicePrincipalId == null)
            {
                throw new ArgumentNullException(nameof(servicePrincipalId));
            }
            if (servicePrincipalKey == null)
            {
                throw new ArgumentNullException(nameof(servicePrincipalKey));
            }

            SiteUrl = siteUrl;
            TenantId = tenantId;
            ServicePrincipalId = servicePrincipalId;
            ServicePrincipalKey = servicePrincipalKey;
            Type = "SharePointOnlineList";
        }

        /// <summary> Initializes a new instance of SharePointOnlineListLinkedService. </summary>
        /// <param name="type"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="siteUrl"> The URL of the SharePoint Online site. For example, https://contoso.sharepoint.com/sites/siteName. Type: string (or Expression with resultType string). </param>
        /// <param name="tenantId"> The tenant ID under which your application resides. You can find it from Azure portal Active Directory overview page. Type: string (or Expression with resultType string). </param>
        /// <param name="servicePrincipalId"> The application (client) ID of your application registered in Azure Active Directory. Make sure to grant SharePoint site permission to this application. Type: string (or Expression with resultType string). </param>
        /// <param name="servicePrincipalKey"> The client secret of your application registered in Azure Active Directory. Type: string (or Expression with resultType string). </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </param>
        internal SharePointOnlineListLinkedService(string type, IntegrationRuntimeReference connectVia, string description, IDictionary<string, ParameterSpecification> parameters, IList<object> annotations, IDictionary<string, object> additionalProperties, object siteUrl, object tenantId, object servicePrincipalId, SecretBase servicePrincipalKey, object encryptedCredential) : base(type, connectVia, description, parameters, annotations, additionalProperties)
        {
            SiteUrl = siteUrl;
            TenantId = tenantId;
            ServicePrincipalId = servicePrincipalId;
            ServicePrincipalKey = servicePrincipalKey;
            EncryptedCredential = encryptedCredential;
            Type = type ?? "SharePointOnlineList";
        }

        /// <summary> The URL of the SharePoint Online site. For example, https://contoso.sharepoint.com/sites/siteName. Type: string (or Expression with resultType string). </summary>
        public object SiteUrl { get; set; }
        /// <summary> The tenant ID under which your application resides. You can find it from Azure portal Active Directory overview page. Type: string (or Expression with resultType string). </summary>
        public object TenantId { get; set; }
        /// <summary> The application (client) ID of your application registered in Azure Active Directory. Make sure to grant SharePoint site permission to this application. Type: string (or Expression with resultType string). </summary>
        public object ServicePrincipalId { get; set; }
        /// <summary> The client secret of your application registered in Azure Active Directory. Type: string (or Expression with resultType string). </summary>
        public SecretBase ServicePrincipalKey { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </summary>
        public object EncryptedCredential { get; set; }
    }
}
