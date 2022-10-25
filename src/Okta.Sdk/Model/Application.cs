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
    /// Application
    /// </summary>
    [DataContract(Name = "Application")]
    [JsonConverter(typeof(JsonSubtypes), "SignOnMode")]
    [JsonSubtypes.KnownSubType(typeof(AutoLoginApplication), "AUTO_LOGIN")]
    [JsonSubtypes.KnownSubType(typeof(AutoLoginApplication), "AutoLoginApplication")]
    [JsonSubtypes.KnownSubType(typeof(BasicAuthApplication), "BASIC_AUTH")]
    [JsonSubtypes.KnownSubType(typeof(BookmarkApplication), "BOOKMARK")]
    [JsonSubtypes.KnownSubType(typeof(BrowserPluginApplication), "BROWSER_PLUGIN")]
    [JsonSubtypes.KnownSubType(typeof(BasicAuthApplication), "BasicAuthApplication")]
    [JsonSubtypes.KnownSubType(typeof(BookmarkApplication), "BookmarkApplication")]
    [JsonSubtypes.KnownSubType(typeof(BrowserPluginApplication), "BrowserPluginApplication")]
    [JsonSubtypes.KnownSubType(typeof(OpenIdConnectApplication), "OPENID_CONNECT")]
    [JsonSubtypes.KnownSubType(typeof(OpenIdConnectApplication), "OpenIdConnectApplication")]
    [JsonSubtypes.KnownSubType(typeof(SamlApplication), "SAML_1_1")]
    [JsonSubtypes.KnownSubType(typeof(SamlApplication), "SAML_2_0")]
    [JsonSubtypes.KnownSubType(typeof(SecurePasswordStoreApplication), "SECURE_PASSWORD_STORE")]
    [JsonSubtypes.KnownSubType(typeof(SamlApplication), "SamlApplication")]
    [JsonSubtypes.KnownSubType(typeof(SecurePasswordStoreApplication), "SecurePasswordStoreApplication")]
    [JsonSubtypes.KnownSubType(typeof(WsFederationApplication), "WS_FEDERATION")]
    [JsonSubtypes.KnownSubType(typeof(WsFederationApplication), "WsFederationApplication")]
    
    public partial class Application : IEquatable<Application>
    {

        /// <summary>
        /// Gets or Sets SignOnMode
        /// </summary>
        [DataMember(Name = "signOnMode", EmitDefaultValue = false)]
        
        public ApplicationSignOnMode SignOnMode { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        
        public ApplicationLifecycleStatus Status { get; set; }
        
        /// <summary>
        /// Gets or Sets Accessibility
        /// </summary>
        [DataMember(Name = "accessibility", EmitDefaultValue = false)]
        public ApplicationAccessibility Accessibility { get; set; }

        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name = "created", EmitDefaultValue = false)]
        public DateTimeOffset Created { get; private set; }

        /// <summary>
        /// Returns false as Created should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreated()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Features
        /// </summary>
        [DataMember(Name = "features", EmitDefaultValue = false)]
        public List<string> Features { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; private set; }

        /// <summary>
        /// Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [DataMember(Name = "label", EmitDefaultValue = false)]
        public string Label { get; set; }

        /// <summary>
        /// Gets or Sets LastUpdated
        /// </summary>
        [DataMember(Name = "lastUpdated", EmitDefaultValue = false)]
        public DateTimeOffset LastUpdated { get; private set; }

        /// <summary>
        /// Returns false as LastUpdated should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLastUpdated()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Licensing
        /// </summary>
        [DataMember(Name = "licensing", EmitDefaultValue = false)]
        public ApplicationLicensing Licensing { get; set; }

        /// <summary>
        /// Gets or Sets Profile
        /// </summary>
        [DataMember(Name = "profile", EmitDefaultValue = false)]
        public Dictionary<string, Object> Profile { get; set; }

        /// <summary>
        /// Gets or Sets Visibility
        /// </summary>
        [DataMember(Name = "visibility", EmitDefaultValue = false)]
        public ApplicationVisibility Visibility { get; set; }

        /// <summary>
        /// Gets or Sets Embedded
        /// </summary>
        [DataMember(Name = "_embedded", EmitDefaultValue = false)]
        public Dictionary<string, Object> Embedded { get; private set; }

        /// <summary>
        /// Returns false as Embedded should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeEmbedded()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "_links", EmitDefaultValue = false)]
        public ApplicationLinks Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Application {\n");
            sb.Append("  Accessibility: ").Append(Accessibility).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Features: ").Append(Features).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  LastUpdated: ").Append(LastUpdated).Append("\n");
            sb.Append("  Licensing: ").Append(Licensing).Append("\n");
            sb.Append("  Profile: ").Append(Profile).Append("\n");
            sb.Append("  SignOnMode: ").Append(SignOnMode).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Visibility: ").Append(Visibility).Append("\n");
            sb.Append("  Embedded: ").Append(Embedded).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as Application);
        }

        /// <summary>
        /// Returns true if Application instances are equal
        /// </summary>
        /// <param name="input">Instance of Application to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Application input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Accessibility == input.Accessibility ||
                    (this.Accessibility != null &&
                    this.Accessibility.Equals(input.Accessibility))
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.Features == input.Features ||
                    this.Features != null &&
                    input.Features != null &&
                    this.Features.SequenceEqual(input.Features)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
                ) && 
                (
                    this.LastUpdated == input.LastUpdated ||
                    (this.LastUpdated != null &&
                    this.LastUpdated.Equals(input.LastUpdated))
                ) && 
                (
                    this.Licensing == input.Licensing ||
                    (this.Licensing != null &&
                    this.Licensing.Equals(input.Licensing))
                ) && 
                (
                    this.Profile == input.Profile ||
                    this.Profile != null &&
                    input.Profile != null &&
                    this.Profile.SequenceEqual(input.Profile)
                ) && 
                (
                    this.SignOnMode == input.SignOnMode ||
                    this.SignOnMode.Equals(input.SignOnMode)
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.Visibility == input.Visibility ||
                    (this.Visibility != null &&
                    this.Visibility.Equals(input.Visibility))
                ) && 
                (
                    this.Embedded == input.Embedded ||
                    this.Embedded != null &&
                    input.Embedded != null &&
                    this.Embedded.SequenceEqual(input.Embedded)
                ) && 
                (
                    this.Links == input.Links ||
                    (this.Links != null &&
                    this.Links.Equals(input.Links))
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
                int hashCode = 41;
                
                if (this.Accessibility != null)
                {
                    hashCode = (hashCode * 59) + this.Accessibility.GetHashCode();
                }
                if (this.Created != null)
                {
                    hashCode = (hashCode * 59) + this.Created.GetHashCode();
                }
                if (this.Features != null)
                {
                    hashCode = (hashCode * 59) + this.Features.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Label != null)
                {
                    hashCode = (hashCode * 59) + this.Label.GetHashCode();
                }
                if (this.LastUpdated != null)
                {
                    hashCode = (hashCode * 59) + this.LastUpdated.GetHashCode();
                }
                if (this.Licensing != null)
                {
                    hashCode = (hashCode * 59) + this.Licensing.GetHashCode();
                }
                if (this.Profile != null)
                {
                    hashCode = (hashCode * 59) + this.Profile.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SignOnMode.GetHashCode();
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.Visibility != null)
                {
                    hashCode = (hashCode * 59) + this.Visibility.GetHashCode();
                }
                if (this.Embedded != null)
                {
                    hashCode = (hashCode * 59) + this.Embedded.GetHashCode();
                }
                if (this.Links != null)
                {
                    hashCode = (hashCode * 59) + this.Links.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
