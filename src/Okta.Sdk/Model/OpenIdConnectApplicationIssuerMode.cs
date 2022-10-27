/*
 * Okta Management
 *
 * Allows customers to easily access the Okta Management APIs
 *
 * The version of the OpenAPI document: 3.0.0
 * Contact: devex-public@okta.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using OpenAPIDateConverter = Okta.Sdk.Client.OpenAPIDateConverter;

namespace Okta.Sdk.Model
{
    /// <summary>
    /// Defines OpenIdConnectApplicationIssuerMode
    /// </summary>
    [JsonConverter(typeof(StringEnumSerializingConverter))]
    public sealed class OpenIdConnectApplicationIssuerMode : StringEnum
    {
        /// <summary>
        /// StringEnum OpenIdConnectApplicationIssuerMode for value: CUSTOM_URL
        /// </summary>
        public static OpenIdConnectApplicationIssuerMode CUSTOMURL = new OpenIdConnectApplicationIssuerMode("CUSTOM_URL");
        /// <summary>
        /// StringEnum OpenIdConnectApplicationIssuerMode for value: DYNAMIC
        /// </summary>
        public static OpenIdConnectApplicationIssuerMode DYNAMIC = new OpenIdConnectApplicationIssuerMode("DYNAMIC");
        /// <summary>
        /// StringEnum OpenIdConnectApplicationIssuerMode for value: ORG_URL
        /// </summary>
        public static OpenIdConnectApplicationIssuerMode ORGURL = new OpenIdConnectApplicationIssuerMode("ORG_URL");

        /// <summary>
        /// Implicit operator declaration to accept and convert a string value as a <see cref="OpenIdConnectApplicationIssuerMode"/>
        /// </summary>
        /// <param name="value">The value to use</param>
        public static implicit operator OpenIdConnectApplicationIssuerMode(string value) => new OpenIdConnectApplicationIssuerMode(value);

        /// <summary>
        /// Creates a new <see cref="OpenIdConnectApplicationIssuerMode"/> instance.
        /// </summary>
        /// <param name="value">The value to use.</param>
        public OpenIdConnectApplicationIssuerMode(string value)
            : base(value)
        {
        }
    }


}