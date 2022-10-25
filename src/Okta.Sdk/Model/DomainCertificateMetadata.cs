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
    /// Template: ModelGeneric
    /// DomainCertificateMetadata
    /// </summary>
    [DataContract(Name = "DomainCertificateMetadata")]
    
    public partial class DomainCertificateMetadata : IEquatable<DomainCertificateMetadata>
    {
        
        /// <summary>
        /// Gets or Sets Expiration
        /// </summary>
        [DataMember(Name = "expiration", EmitDefaultValue = false)]
        public string Expiration { get; set; }

        /// <summary>
        /// Gets or Sets Fingerprint
        /// </summary>
        [DataMember(Name = "fingerprint", EmitDefaultValue = false)]
        public string Fingerprint { get; set; }

        /// <summary>
        /// Gets or Sets Subject
        /// </summary>
        [DataMember(Name = "subject", EmitDefaultValue = false)]
        public string Subject { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DomainCertificateMetadata {\n");
            sb.Append("  Expiration: ").Append(Expiration).Append("\n");
            sb.Append("  Fingerprint: ").Append(Fingerprint).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
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
            return this.Equals(input as DomainCertificateMetadata);
        }

        /// <summary>
        /// Returns true if DomainCertificateMetadata instances are equal
        /// </summary>
        /// <param name="input">Instance of DomainCertificateMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DomainCertificateMetadata input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Expiration == input.Expiration ||
                    (this.Expiration != null &&
                    this.Expiration.Equals(input.Expiration))
                ) && 
                (
                    this.Fingerprint == input.Fingerprint ||
                    (this.Fingerprint != null &&
                    this.Fingerprint.Equals(input.Fingerprint))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
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
                
                if (this.Expiration != null)
                {
                    hashCode = (hashCode * 59) + this.Expiration.GetHashCode();
                }
                if (this.Fingerprint != null)
                {
                    hashCode = (hashCode * 59) + this.Fingerprint.GetHashCode();
                }
                if (this.Subject != null)
                {
                    hashCode = (hashCode * 59) + this.Subject.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
