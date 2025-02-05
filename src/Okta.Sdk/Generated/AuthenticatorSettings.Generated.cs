// <copyright file="AuthenticatorSettings.Generated.cs" company="Okta, Inc">
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
    public sealed partial class AuthenticatorSettings : Resource, IAuthenticatorSettings
    {
        /// <inheritdoc/>
        public AllowedForEnum AllowedFor 
        {
            get => GetEnumProperty<AllowedForEnum>("allowedFor");
            set => this["allowedFor"] = value;
        }
        
        /// <inheritdoc/>
        public string AppInstanceId 
        {
            get => GetStringProperty("appInstanceId");
            set => this["appInstanceId"] = value;
        }
        
        /// <inheritdoc/>
        public IChannelBinding ChannelBinding 
        {
            get => GetResourceProperty<ChannelBinding>("channelBinding");
            set => this["channelBinding"] = value;
        }
        
        /// <inheritdoc/>
        public ICompliance Compliance 
        {
            get => GetResourceProperty<Compliance>("compliance");
            set => this["compliance"] = value;
        }
        
        /// <inheritdoc/>
        public int? TokenLifetimeInMinutes 
        {
            get => GetIntegerProperty("tokenLifetimeInMinutes");
            set => this["tokenLifetimeInMinutes"] = value;
        }
        
        /// <inheritdoc/>
        public UserVerificationEnum UserVerification 
        {
            get => GetEnumProperty<UserVerificationEnum>("userVerification");
            set => this["userVerification"] = value;
        }
        
    }
}
