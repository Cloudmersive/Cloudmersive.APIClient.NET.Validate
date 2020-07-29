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
    /// Result of performing a get time zones operation
    /// </summary>
    [DataContract]
    public partial class GetTimezonesResponse :  IEquatable<GetTimezonesResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTimezonesResponse" /> class.
        /// </summary>
        /// <param name="successful">True if successful, false otherwise.</param>
        /// <param name="countryFullName">Full name of the country.</param>
        /// <param name="iSOTwoLetterCode">Two-letter ISO 3166-1 country code.</param>
        /// <param name="fIPSTwoLetterCode">Two-letter FIPS 10-4 country code.</param>
        /// <param name="threeLetterCode">Three-letter ISO 3166-1 country code.</param>
        /// <param name="timezones">Time zones (IANA/Olsen) in the country.</param>
        public GetTimezonesResponse(bool? successful = default(bool?), string countryFullName = default(string), string iSOTwoLetterCode = default(string), string fIPSTwoLetterCode = default(string), string threeLetterCode = default(string), List<Timezone> timezones = default(List<Timezone>))
        {
            this.Successful = successful;
            this.CountryFullName = countryFullName;
            this.ISOTwoLetterCode = iSOTwoLetterCode;
            this.FIPSTwoLetterCode = fIPSTwoLetterCode;
            this.ThreeLetterCode = threeLetterCode;
            this.Timezones = timezones;
        }
        
        /// <summary>
        /// True if successful, false otherwise
        /// </summary>
        /// <value>True if successful, false otherwise</value>
        [DataMember(Name="Successful", EmitDefaultValue=false)]
        public bool? Successful { get; set; }

        /// <summary>
        /// Full name of the country
        /// </summary>
        /// <value>Full name of the country</value>
        [DataMember(Name="CountryFullName", EmitDefaultValue=false)]
        public string CountryFullName { get; set; }

        /// <summary>
        /// Two-letter ISO 3166-1 country code
        /// </summary>
        /// <value>Two-letter ISO 3166-1 country code</value>
        [DataMember(Name="ISOTwoLetterCode", EmitDefaultValue=false)]
        public string ISOTwoLetterCode { get; set; }

        /// <summary>
        /// Two-letter FIPS 10-4 country code
        /// </summary>
        /// <value>Two-letter FIPS 10-4 country code</value>
        [DataMember(Name="FIPSTwoLetterCode", EmitDefaultValue=false)]
        public string FIPSTwoLetterCode { get; set; }

        /// <summary>
        /// Three-letter ISO 3166-1 country code
        /// </summary>
        /// <value>Three-letter ISO 3166-1 country code</value>
        [DataMember(Name="ThreeLetterCode", EmitDefaultValue=false)]
        public string ThreeLetterCode { get; set; }

        /// <summary>
        /// Time zones (IANA/Olsen) in the country
        /// </summary>
        /// <value>Time zones (IANA/Olsen) in the country</value>
        [DataMember(Name="Timezones", EmitDefaultValue=false)]
        public List<Timezone> Timezones { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetTimezonesResponse {\n");
            sb.Append("  Successful: ").Append(Successful).Append("\n");
            sb.Append("  CountryFullName: ").Append(CountryFullName).Append("\n");
            sb.Append("  ISOTwoLetterCode: ").Append(ISOTwoLetterCode).Append("\n");
            sb.Append("  FIPSTwoLetterCode: ").Append(FIPSTwoLetterCode).Append("\n");
            sb.Append("  ThreeLetterCode: ").Append(ThreeLetterCode).Append("\n");
            sb.Append("  Timezones: ").Append(Timezones).Append("\n");
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
            return this.Equals(input as GetTimezonesResponse);
        }

        /// <summary>
        /// Returns true if GetTimezonesResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetTimezonesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetTimezonesResponse input)
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
                    this.CountryFullName == input.CountryFullName ||
                    (this.CountryFullName != null &&
                    this.CountryFullName.Equals(input.CountryFullName))
                ) && 
                (
                    this.ISOTwoLetterCode == input.ISOTwoLetterCode ||
                    (this.ISOTwoLetterCode != null &&
                    this.ISOTwoLetterCode.Equals(input.ISOTwoLetterCode))
                ) && 
                (
                    this.FIPSTwoLetterCode == input.FIPSTwoLetterCode ||
                    (this.FIPSTwoLetterCode != null &&
                    this.FIPSTwoLetterCode.Equals(input.FIPSTwoLetterCode))
                ) && 
                (
                    this.ThreeLetterCode == input.ThreeLetterCode ||
                    (this.ThreeLetterCode != null &&
                    this.ThreeLetterCode.Equals(input.ThreeLetterCode))
                ) && 
                (
                    this.Timezones == input.Timezones ||
                    this.Timezones != null &&
                    this.Timezones.SequenceEqual(input.Timezones)
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
                if (this.CountryFullName != null)
                    hashCode = hashCode * 59 + this.CountryFullName.GetHashCode();
                if (this.ISOTwoLetterCode != null)
                    hashCode = hashCode * 59 + this.ISOTwoLetterCode.GetHashCode();
                if (this.FIPSTwoLetterCode != null)
                    hashCode = hashCode * 59 + this.FIPSTwoLetterCode.GetHashCode();
                if (this.ThreeLetterCode != null)
                    hashCode = hashCode * 59 + this.ThreeLetterCode.GetHashCode();
                if (this.Timezones != null)
                    hashCode = hashCode * 59 + this.Timezones.GetHashCode();
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