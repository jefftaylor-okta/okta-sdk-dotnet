/*
 * Okta API
 *
 * Allows customers to easily access the Okta API
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
    /// JsonWebKey
    /// </summary>
    [DataContract(Name = "JsonWebKey")]
    
    public partial class JsonWebKey : IEquatable<JsonWebKey>
    {
        
        /// <summary>
        /// Gets or Sets Alg
        /// </summary>
        [DataMember(Name = "alg", EmitDefaultValue = false)]
        public string Alg { get; set; }

        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name = "created", EmitDefaultValue = false)]
        public DateTimeOffset Created { get; set; }

        /// <summary>
        /// Gets or Sets E
        /// </summary>
        [DataMember(Name = "e", EmitDefaultValue = false)]
        public string E { get; set; }

        /// <summary>
        /// Gets or Sets ExpiresAt
        /// </summary>
        [DataMember(Name = "expiresAt", EmitDefaultValue = false)]
        public DateTimeOffset ExpiresAt { get; set; }

        /// <summary>
        /// Gets or Sets KeyOps
        /// </summary>
        [DataMember(Name = "key_ops", EmitDefaultValue = false)]
        public List<string> KeyOps { get; set; }

        /// <summary>
        /// Gets or Sets Kid
        /// </summary>
        [DataMember(Name = "kid", EmitDefaultValue = false)]
        public string Kid { get; set; }

        /// <summary>
        /// Gets or Sets Kty
        /// </summary>
        [DataMember(Name = "kty", EmitDefaultValue = false)]
        public string Kty { get; set; }

        /// <summary>
        /// Gets or Sets LastUpdated
        /// </summary>
        [DataMember(Name = "lastUpdated", EmitDefaultValue = false)]
        public DateTimeOffset LastUpdated { get; set; }

        /// <summary>
        /// Gets or Sets N
        /// </summary>
        [DataMember(Name = "n", EmitDefaultValue = false)]
        public string N { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets Use
        /// </summary>
        [DataMember(Name = "use", EmitDefaultValue = false)]
        public string Use { get; set; }

        /// <summary>
        /// Gets or Sets X5c
        /// </summary>
        [DataMember(Name = "x5c", EmitDefaultValue = false)]
        public List<string> X5c { get; set; }

        /// <summary>
        /// Gets or Sets X5t
        /// </summary>
        [DataMember(Name = "x5t", EmitDefaultValue = false)]
        public string X5t { get; set; }

        /// <summary>
        /// Gets or Sets X5tS256
        /// </summary>
        [DataMember(Name = "x5t#S256", EmitDefaultValue = false)]
        public string X5tS256 { get; set; }

        /// <summary>
        /// Gets or Sets X5u
        /// </summary>
        [DataMember(Name = "x5u", EmitDefaultValue = false)]
        public string X5u { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "_links", EmitDefaultValue = false)]
        public Dictionary<string, Object> Links { get; private set; }

        /// <summary>
        /// Returns false as Links should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLinks()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class JsonWebKey {\n");
            sb.Append("  Alg: ").Append(Alg).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  E: ").Append(E).Append("\n");
            sb.Append("  ExpiresAt: ").Append(ExpiresAt).Append("\n");
            sb.Append("  KeyOps: ").Append(KeyOps).Append("\n");
            sb.Append("  Kid: ").Append(Kid).Append("\n");
            sb.Append("  Kty: ").Append(Kty).Append("\n");
            sb.Append("  LastUpdated: ").Append(LastUpdated).Append("\n");
            sb.Append("  N: ").Append(N).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Use: ").Append(Use).Append("\n");
            sb.Append("  X5c: ").Append(X5c).Append("\n");
            sb.Append("  X5t: ").Append(X5t).Append("\n");
            sb.Append("  X5tS256: ").Append(X5tS256).Append("\n");
            sb.Append("  X5u: ").Append(X5u).Append("\n");
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
            return this.Equals(input as JsonWebKey);
        }

        /// <summary>
        /// Returns true if JsonWebKey instances are equal
        /// </summary>
        /// <param name="input">Instance of JsonWebKey to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JsonWebKey input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Alg == input.Alg ||
                    (this.Alg != null &&
                    this.Alg.Equals(input.Alg))
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.E == input.E ||
                    (this.E != null &&
                    this.E.Equals(input.E))
                ) && 
                (
                    this.ExpiresAt == input.ExpiresAt ||
                    (this.ExpiresAt != null &&
                    this.ExpiresAt.Equals(input.ExpiresAt))
                ) && 
                (
                    this.KeyOps == input.KeyOps ||
                    this.KeyOps != null &&
                    input.KeyOps != null &&
                    this.KeyOps.SequenceEqual(input.KeyOps)
                ) && 
                (
                    this.Kid == input.Kid ||
                    (this.Kid != null &&
                    this.Kid.Equals(input.Kid))
                ) && 
                (
                    this.Kty == input.Kty ||
                    (this.Kty != null &&
                    this.Kty.Equals(input.Kty))
                ) && 
                (
                    this.LastUpdated == input.LastUpdated ||
                    (this.LastUpdated != null &&
                    this.LastUpdated.Equals(input.LastUpdated))
                ) && 
                (
                    this.N == input.N ||
                    (this.N != null &&
                    this.N.Equals(input.N))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Use == input.Use ||
                    (this.Use != null &&
                    this.Use.Equals(input.Use))
                ) && 
                (
                    this.X5c == input.X5c ||
                    this.X5c != null &&
                    input.X5c != null &&
                    this.X5c.SequenceEqual(input.X5c)
                ) && 
                (
                    this.X5t == input.X5t ||
                    (this.X5t != null &&
                    this.X5t.Equals(input.X5t))
                ) && 
                (
                    this.X5tS256 == input.X5tS256 ||
                    (this.X5tS256 != null &&
                    this.X5tS256.Equals(input.X5tS256))
                ) && 
                (
                    this.X5u == input.X5u ||
                    (this.X5u != null &&
                    this.X5u.Equals(input.X5u))
                ) && 
                (
                    this.Links == input.Links ||
                    this.Links != null &&
                    input.Links != null &&
                    this.Links.SequenceEqual(input.Links)
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
                
                if (this.Alg != null)
                {
                    hashCode = (hashCode * 59) + this.Alg.GetHashCode();
                }
                if (this.Created != null)
                {
                    hashCode = (hashCode * 59) + this.Created.GetHashCode();
                }
                if (this.E != null)
                {
                    hashCode = (hashCode * 59) + this.E.GetHashCode();
                }
                if (this.ExpiresAt != null)
                {
                    hashCode = (hashCode * 59) + this.ExpiresAt.GetHashCode();
                }
                if (this.KeyOps != null)
                {
                    hashCode = (hashCode * 59) + this.KeyOps.GetHashCode();
                }
                if (this.Kid != null)
                {
                    hashCode = (hashCode * 59) + this.Kid.GetHashCode();
                }
                if (this.Kty != null)
                {
                    hashCode = (hashCode * 59) + this.Kty.GetHashCode();
                }
                if (this.LastUpdated != null)
                {
                    hashCode = (hashCode * 59) + this.LastUpdated.GetHashCode();
                }
                if (this.N != null)
                {
                    hashCode = (hashCode * 59) + this.N.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.Use != null)
                {
                    hashCode = (hashCode * 59) + this.Use.GetHashCode();
                }
                if (this.X5c != null)
                {
                    hashCode = (hashCode * 59) + this.X5c.GetHashCode();
                }
                if (this.X5t != null)
                {
                    hashCode = (hashCode * 59) + this.X5t.GetHashCode();
                }
                if (this.X5tS256 != null)
                {
                    hashCode = (hashCode * 59) + this.X5tS256.GetHashCode();
                }
                if (this.X5u != null)
                {
                    hashCode = (hashCode * 59) + this.X5u.GetHashCode();
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