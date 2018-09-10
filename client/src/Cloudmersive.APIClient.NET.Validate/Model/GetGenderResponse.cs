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
    /// Result of the GetGender operation
    /// </summary>
    [DataContract]
    public partial class GetGenderResponse :  IEquatable<GetGenderResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetGenderResponse" /> class.
        /// </summary>
        /// <param name="Successful">True if successful, false otherwise.</param>
        /// <param name="Gender">Gender for this name; possible values are Male, Female, and Neutral (can be applied to Male or Female).</param>
        public GetGenderResponse(bool? Successful = default(bool?), string Gender = default(string))
        {
            this.Successful = Successful;
            this.Gender = Gender;
        }
        
        /// <summary>
        /// True if successful, false otherwise
        /// </summary>
        /// <value>True if successful, false otherwise</value>
        [DataMember(Name="Successful", EmitDefaultValue=false)]
        public bool? Successful { get; set; }

        /// <summary>
        /// Gender for this name; possible values are Male, Female, and Neutral (can be applied to Male or Female)
        /// </summary>
        /// <value>Gender for this name; possible values are Male, Female, and Neutral (can be applied to Male or Female)</value>
        [DataMember(Name="Gender", EmitDefaultValue=false)]
        public string Gender { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetGenderResponse {\n");
            sb.Append("  Successful: ").Append(Successful).Append("\n");
            sb.Append("  Gender: ").Append(Gender).Append("\n");
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
            return this.Equals(input as GetGenderResponse);
        }

        /// <summary>
        /// Returns true if GetGenderResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetGenderResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetGenderResponse input)
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
                    this.Gender == input.Gender ||
                    (this.Gender != null &&
                    this.Gender.Equals(input.Gender))
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
                if (this.Gender != null)
                    hashCode = hashCode * 59 + this.Gender.GetHashCode();
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
