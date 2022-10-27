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
    /// The Log Stream type specifies the streaming provider used. Okta supports [AWS EventBridge](https://aws.amazon.com/eventbridge/) and [Splunk Cloud](https://www.splunk.com/en_us/software/splunk-cloud-platform.html).
    /// </summary>
    /// <value>The Log Stream type specifies the streaming provider used. Okta supports [AWS EventBridge](https://aws.amazon.com/eventbridge/) and [Splunk Cloud](https://www.splunk.com/en_us/software/splunk-cloud-platform.html).</value>
    [JsonConverter(typeof(StringEnumSerializingConverter))]
    public sealed class LogStreamType : StringEnum
    {
        /// <summary>
        /// StringEnum LogStreamType for value: aws_eventbridge
        /// </summary>
        public static LogStreamType AwsEventbridge = new LogStreamType("aws_eventbridge");
        /// <summary>
        /// StringEnum LogStreamType for value: splunk_cloud_logstreaming
        /// </summary>
        public static LogStreamType SplunkCloudLogstreaming = new LogStreamType("splunk_cloud_logstreaming");

        /// <summary>
        /// Implicit operator declaration to accept and convert a string value as a <see cref="LogStreamType"/>
        /// </summary>
        /// <param name="value">The value to use</param>
        public static implicit operator LogStreamType(string value) => new LogStreamType(value);

        /// <summary>
        /// Creates a new <see cref="LogStreamType"/> instance.
        /// </summary>
        /// <param name="value">The value to use.</param>
        public LogStreamType(string value)
            : base(value)
        {
        }
    }


}