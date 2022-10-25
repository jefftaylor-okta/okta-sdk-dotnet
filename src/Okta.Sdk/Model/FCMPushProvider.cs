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
using JsonSubTypes;
using OpenAPIDateConverter = Okta.Sdk.Client.OpenAPIDateConverter;

namespace Okta.Sdk.Model
{
    /// <summary>
    /// Template: ModelGeneric
    /// FCMPushProvider
    /// </summary>
    [DataContract(Name = "FCMPushProvider")]
    [JsonConverter(typeof(JsonSubtypes), "ProviderType")]
    [JsonSubtypes.KnownSubType(typeof(APNSPushProvider), "APNS")]
    [JsonSubtypes.KnownSubType(typeof(FCMPushProvider), "FCM")]
    
    public partial class FCMPushProvider : PushProvider, IEquatable<FCMPushProvider>
    {
        
        /// <summary>
        /// Gets or Sets _Configuration
        /// </summary>
        [DataMember(Name = "configuration", EmitDefaultValue = false)]
        public FCMConfiguration _Configuration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FCMPushProvider {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  _Configuration: ").Append(_Configuration).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as FCMPushProvider);
        }

        /// <summary>
        /// Returns true if FCMPushProvider instances are equal
        /// </summary>
        /// <param name="input">Instance of FCMPushProvider to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FCMPushProvider input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this._Configuration == input._Configuration ||
                    (this._Configuration != null &&
                    this._Configuration.Equals(input._Configuration))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = base.GetHashCode();
                
                if (this._Configuration != null)
                {
                    hashCode = (hashCode * 59) + this._Configuration.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
