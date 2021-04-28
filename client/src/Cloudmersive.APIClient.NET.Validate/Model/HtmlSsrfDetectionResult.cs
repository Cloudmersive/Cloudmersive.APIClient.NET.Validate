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
    /// Result of performing an XXE threat detection operation
    /// </summary>
    [DataContract]
    public partial class HtmlSsrfDetectionResult :  IEquatable<HtmlSsrfDetectionResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlSsrfDetectionResult" /> class.
        /// </summary>
        /// <param name="successful">True if the operation was successful, false otherwise.</param>
        /// <param name="containedThreats">True if the input contained SSRF threats, false otherwise.</param>
        public HtmlSsrfDetectionResult(bool? successful = default(bool?), bool? containedThreats = default(bool?))
        {
            this.Successful = successful;
            this.ContainedThreats = containedThreats;
        }
        
        /// <summary>
        /// True if the operation was successful, false otherwise
        /// </summary>
        /// <value>True if the operation was successful, false otherwise</value>
        [DataMember(Name="Successful", EmitDefaultValue=false)]
        public bool? Successful { get; set; }

        /// <summary>
        /// True if the input contained SSRF threats, false otherwise
        /// </summary>
        /// <value>True if the input contained SSRF threats, false otherwise</value>
        [DataMember(Name="ContainedThreats", EmitDefaultValue=false)]
        public bool? ContainedThreats { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HtmlSsrfDetectionResult {\n");
            sb.Append("  Successful: ").Append(Successful).Append("\n");
            sb.Append("  ContainedThreats: ").Append(ContainedThreats).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as HtmlSsrfDetectionResult);
        }

        /// <summary>
        /// Returns true if HtmlSsrfDetectionResult instances are equal
        /// </summary>
        /// <param name="input">Instance of HtmlSsrfDetectionResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HtmlSsrfDetectionResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Successful == input.Successful ||
                    (this.Successful != null &&
                    this.Successful.Equals(input.Successful))
                ) && 
                (
                    this.ContainedThreats == input.ContainedThreats ||
                    (this.ContainedThreats != null &&
                    this.ContainedThreats.Equals(input.ContainedThreats))
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
                if (this.Successful != null)
                    hashCode = hashCode * 59 + this.Successful.GetHashCode();
                if (this.ContainedThreats != null)
                    hashCode = hashCode * 59 + this.ContainedThreats.GetHashCode();
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
