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
    /// Full email addresss validation result
    /// </summary>
    [DataContract]
    public partial class FullEmailValidationResponse :  IEquatable<FullEmailValidationResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FullEmailValidationResponse" /> class.
        /// </summary>
        /// <param name="ValidAddress">True if the email address is valid, false otherwise.</param>
        /// <param name="MailServerUsedForValidation">Email server connected to for verification.</param>
        public FullEmailValidationResponse(bool? ValidAddress = default(bool?), string MailServerUsedForValidation = default(string))
        {
            this.ValidAddress = ValidAddress;
            this.MailServerUsedForValidation = MailServerUsedForValidation;
        }
        
        /// <summary>
        /// True if the email address is valid, false otherwise
        /// </summary>
        /// <value>True if the email address is valid, false otherwise</value>
        [DataMember(Name="ValidAddress", EmitDefaultValue=false)]
        public bool? ValidAddress { get; set; }

        /// <summary>
        /// Email server connected to for verification
        /// </summary>
        /// <value>Email server connected to for verification</value>
        [DataMember(Name="MailServerUsedForValidation", EmitDefaultValue=false)]
        public string MailServerUsedForValidation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FullEmailValidationResponse {\n");
            sb.Append("  ValidAddress: ").Append(ValidAddress).Append("\n");
            sb.Append("  MailServerUsedForValidation: ").Append(MailServerUsedForValidation).Append("\n");
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
            return this.Equals(input as FullEmailValidationResponse);
        }

        /// <summary>
        /// Returns true if FullEmailValidationResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of FullEmailValidationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FullEmailValidationResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ValidAddress == input.ValidAddress ||
                    (this.ValidAddress != null &&
                    this.ValidAddress.Equals(input.ValidAddress))
                ) && 
                (
                    this.MailServerUsedForValidation == input.MailServerUsedForValidation ||
                    (this.MailServerUsedForValidation != null &&
                    this.MailServerUsedForValidation.Equals(input.MailServerUsedForValidation))
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
                if (this.ValidAddress != null)
                    hashCode = hashCode * 59 + this.ValidAddress.GetHashCode();
                if (this.MailServerUsedForValidation != null)
                    hashCode = hashCode * 59 + this.MailServerUsedForValidation.GetHashCode();
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
