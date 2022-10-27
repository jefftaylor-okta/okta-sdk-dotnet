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
    /// Defines GrantOrTokenStatus
    /// </summary>
    [JsonConverter(typeof(StringEnumSerializingConverter))]
    public sealed class GrantOrTokenStatus : StringEnum
    {
        /// <summary>
        /// StringEnum GrantOrTokenStatus for value: ACTIVE
        /// </summary>
        public static GrantOrTokenStatus ACTIVE = new GrantOrTokenStatus("ACTIVE");
        /// <summary>
        /// StringEnum GrantOrTokenStatus for value: REVOKED
        /// </summary>
        public static GrantOrTokenStatus REVOKED = new GrantOrTokenStatus("REVOKED");

        /// <summary>
        /// Implicit operator declaration to accept and convert a string value as a <see cref="GrantOrTokenStatus"/>
        /// </summary>
        /// <param name="value">The value to use</param>
        public static implicit operator GrantOrTokenStatus(string value) => new GrantOrTokenStatus(value);

        /// <summary>
        /// Creates a new <see cref="GrantOrTokenStatus"/> instance.
        /// </summary>
        /// <param name="value">The value to use.</param>
        public GrantOrTokenStatus(string value)
            : base(value)
        {
        }
    }


}