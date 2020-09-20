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
    /// Result of performing a domain quality score operation
    /// </summary>
    [DataContract]
    public partial class DomainQualityResponse :  IEquatable<DomainQualityResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainQualityResponse" /> class.
        /// </summary>
        /// <param name="domainQualityScore">The quality score of the domain name; possible values are 0.0 to 10.0 with 10.0 being the highest and 0.0 being the lowest quality..</param>
        public DomainQualityResponse(double? domainQualityScore = default(double?))
        {
            this.DomainQualityScore = domainQualityScore;
        }
        
        /// <summary>
        /// The quality score of the domain name; possible values are 0.0 to 10.0 with 10.0 being the highest and 0.0 being the lowest quality.
        /// </summary>
        /// <value>The quality score of the domain name; possible values are 0.0 to 10.0 with 10.0 being the highest and 0.0 being the lowest quality.</value>
        [DataMember(Name="DomainQualityScore", EmitDefaultValue=false)]
        public double? DomainQualityScore { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DomainQualityResponse {\n");
            sb.Append("  DomainQualityScore: ").Append(DomainQualityScore).Append("\n");
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
            return this.Equals(input as DomainQualityResponse);
        }

        /// <summary>
        /// Returns true if DomainQualityResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of DomainQualityResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DomainQualityResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DomainQualityScore == input.DomainQualityScore ||
                    (this.DomainQualityScore != null &&
                    this.DomainQualityScore.Equals(input.DomainQualityScore))
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
                if (this.DomainQualityScore != null)
                    hashCode = hashCode * 59 + this.DomainQualityScore.GetHashCode();
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
