/* 
 * validateapi
 *
 * The validation APIs help you validate data. Check if an E-mail address is real. Check if a domain is real. Check up on an IP address, and even where it is located. All this and much more is available in the validation API.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Cloudmersive.APIClient.NET.Validate.Client.SwaggerDateConverter;

namespace Cloudmersive.APIClient.NET.Validate.Model
{
    /// <summary>
    /// Result of a validation operation
    /// </summary>
    [DataContract]
    public partial class CheckResponse :  IEquatable<CheckResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckResponse" /> class.
        /// </summary>
        /// <param name="ValidDomain">True if the domain name was valid, false if it is not.</param>
        public CheckResponse(bool? ValidDomain = default(bool?))
        {
            this.ValidDomain = ValidDomain;
        }
        
        /// <summary>
        /// True if the domain name was valid, false if it is not
        /// </summary>
        /// <value>True if the domain name was valid, false if it is not</value>
        [DataMember(Name="ValidDomain", EmitDefaultValue=false)]
        public bool? ValidDomain { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckResponse {\n");
            sb.Append("  ValidDomain: ").Append(ValidDomain).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CheckResponse);
        }

        /// <summary>
        /// Returns true if CheckResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CheckResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CheckResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ValidDomain == input.ValidDomain ||
                    (this.ValidDomain != null &&
                    this.ValidDomain.Equals(input.ValidDomain))
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
                if (this.ValidDomain != null)
                    hashCode = hashCode * 59 + this.ValidDomain.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
