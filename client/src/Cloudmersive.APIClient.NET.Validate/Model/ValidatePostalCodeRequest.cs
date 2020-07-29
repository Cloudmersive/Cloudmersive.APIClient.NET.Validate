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
    /// Request to Validate a Postal Code
    /// </summary>
    [DataContract]
    public partial class ValidatePostalCodeRequest :  IEquatable<ValidatePostalCodeRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidatePostalCodeRequest" /> class.
        /// </summary>
        /// <param name="postalCode">Optional (recommended); Zip code or postal code of the address to validate, such as &#39;94597&#39;.</param>
        /// <param name="countryFullName">Optional (recommended); Name of the country, such as &#39;United States&#39;.  If left blank, and CountryCode is also left blank, will default to United States.  Global countries are supported..</param>
        /// <param name="countryCode">Optional; two-letter country code (Two-letter ISO 3166-1 country code) of the country.  If left blank, and CountryFullName is also left blank, will default to United States.  Global countries are supported..</param>
        public ValidatePostalCodeRequest(string postalCode = default(string), string countryFullName = default(string), string countryCode = default(string))
        {
            this.PostalCode = postalCode;
            this.CountryFullName = countryFullName;
            this.CountryCode = countryCode;
        }
        
        /// <summary>
        /// Optional (recommended); Zip code or postal code of the address to validate, such as &#39;94597&#39;
        /// </summary>
        /// <value>Optional (recommended); Zip code or postal code of the address to validate, such as &#39;94597&#39;</value>
        [DataMember(Name="PostalCode", EmitDefaultValue=false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Optional (recommended); Name of the country, such as &#39;United States&#39;.  If left blank, and CountryCode is also left blank, will default to United States.  Global countries are supported.
        /// </summary>
        /// <value>Optional (recommended); Name of the country, such as &#39;United States&#39;.  If left blank, and CountryCode is also left blank, will default to United States.  Global countries are supported.</value>
        [DataMember(Name="CountryFullName", EmitDefaultValue=false)]
        public string CountryFullName { get; set; }

        /// <summary>
        /// Optional; two-letter country code (Two-letter ISO 3166-1 country code) of the country.  If left blank, and CountryFullName is also left blank, will default to United States.  Global countries are supported.
        /// </summary>
        /// <value>Optional; two-letter country code (Two-letter ISO 3166-1 country code) of the country.  If left blank, and CountryFullName is also left blank, will default to United States.  Global countries are supported.</value>
        [DataMember(Name="CountryCode", EmitDefaultValue=false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ValidatePostalCodeRequest {\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  CountryFullName: ").Append(CountryFullName).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
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
            return this.Equals(input as ValidatePostalCodeRequest);
        }

        /// <summary>
        /// Returns true if ValidatePostalCodeRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ValidatePostalCodeRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ValidatePostalCodeRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PostalCode == input.PostalCode ||
                    (this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode))
                ) && 
                (
                    this.CountryFullName == input.CountryFullName ||
                    (this.CountryFullName != null &&
                    this.CountryFullName.Equals(input.CountryFullName))
                ) && 
                (
                    this.CountryCode == input.CountryCode ||
                    (this.CountryCode != null &&
                    this.CountryCode.Equals(input.CountryCode))
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
                if (this.PostalCode != null)
                    hashCode = hashCode * 59 + this.PostalCode.GetHashCode();
                if (this.CountryFullName != null)
                    hashCode = hashCode * 59 + this.CountryFullName.GetHashCode();
                if (this.CountryCode != null)
                    hashCode = hashCode * 59 + this.CountryCode.GetHashCode();
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