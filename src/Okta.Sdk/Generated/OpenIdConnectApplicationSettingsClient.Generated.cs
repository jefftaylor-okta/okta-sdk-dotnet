// <copyright file="OpenIdConnectApplicationSettingsClient.Generated.cs" company="Okta, Inc">
// Copyright (c) 2014 - present Okta, Inc. All rights reserved.
// Licensed under the Apache 2.0 license. See the LICENSE file in the project root for full license information.
// </copyright>

// This file was automatically generated. Don't modify it directly.

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Okta.Sdk.Internal;

namespace Okta.Sdk
{
    /// <inheritdoc/>
    public sealed partial class OpenIdConnectApplicationSettingsClient : Resource, IOpenIdConnectApplicationSettingsClient
    {
        /// <inheritdoc/>
        public OpenIdConnectApplicationType ApplicationType 
        {
            get => GetEnumProperty<OpenIdConnectApplicationType>("application_type");
            set => this["application_type"] = value;
        }
        
        /// <inheritdoc/>
        public string ClientUri 
        {
            get => GetStringProperty("client_uri");
            set => this["client_uri"] = value;
        }
        
        /// <inheritdoc/>
        public OpenIdConnectApplicationConsentMethod ConsentMethod 
        {
            get => GetEnumProperty<OpenIdConnectApplicationConsentMethod>("consent_method");
            set => this["consent_method"] = value;
        }
        
        /// <inheritdoc/>
        public IList<OAuthGrantType> GrantTypes 
        {
            get => GetArrayProperty<OAuthGrantType>("grant_types");
            set => this["grant_types"] = value;
        }
        
        /// <inheritdoc/>
        public IOpenIdConnectApplicationIdpInitiatedLogin IdpInitiatedLogin 
        {
            get => GetResourceProperty<OpenIdConnectApplicationIdpInitiatedLogin>("idp_initiated_login");
            set => this["idp_initiated_login"] = value;
        }
        
        /// <inheritdoc/>
        public string InitiateLoginUri 
        {
            get => GetStringProperty("initiate_login_uri");
            set => this["initiate_login_uri"] = value;
        }
        
        /// <inheritdoc/>
        public OpenIdConnectApplicationIssuerMode IssuerMode 
        {
            get => GetEnumProperty<OpenIdConnectApplicationIssuerMode>("issuer_mode");
            set => this["issuer_mode"] = value;
        }
        
        /// <inheritdoc/>
        public IOpenIdConnectApplicationSettingsClientKeys Jwks 
        {
            get => GetResourceProperty<OpenIdConnectApplicationSettingsClientKeys>("jwks");
            set => this["jwks"] = value;
        }
        
        /// <inheritdoc/>
        public string LogoUri 
        {
            get => GetStringProperty("logo_uri");
            set => this["logo_uri"] = value;
        }
        
        /// <inheritdoc/>
        public string PolicyUri 
        {
            get => GetStringProperty("policy_uri");
            set => this["policy_uri"] = value;
        }
        
        /// <inheritdoc/>
        public IList<string> PostLogoutRedirectUris 
        {
            get => GetArrayProperty<string>("post_logout_redirect_uris");
            set => this["post_logout_redirect_uris"] = value;
        }
        
        /// <inheritdoc/>
        public IList<string> RedirectUris 
        {
            get => GetArrayProperty<string>("redirect_uris");
            set => this["redirect_uris"] = value;
        }
        
        /// <inheritdoc/>
        public IOpenIdConnectApplicationSettingsRefreshToken RefreshToken 
        {
            get => GetResourceProperty<OpenIdConnectApplicationSettingsRefreshToken>("refresh_token");
            set => this["refresh_token"] = value;
        }
        
        /// <inheritdoc/>
        public IList<OAuthResponseType> ResponseTypes 
        {
            get => GetArrayProperty<OAuthResponseType>("response_types");
            set => this["response_types"] = value;
        }
        
        /// <inheritdoc/>
        public string TermsOfServiceUri 
        {
            get => GetStringProperty("tos_uri");
            set => this["tos_uri"] = value;
        }
        
        /// <inheritdoc/>
        public string WildcardRedirect 
        {
            get => GetStringProperty("wildcard_redirect");
            set => this["wildcard_redirect"] = value;
        }
        
    }
}
