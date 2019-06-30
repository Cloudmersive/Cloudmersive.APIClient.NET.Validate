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
    /// Result from validating a phone number
    /// </summary>
    [DataContract]
    public partial class PhoneNumberValidationResponse :  IEquatable<PhoneNumberValidationResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberValidationResponse" /> class.
        /// </summary>
        /// <param name="isValid">True if the phone number is valid, false otherwise.</param>
        /// <param name="successful">True if the operation was successful, false if there was an error during validation.  See IsValid for validation result..</param>
        /// <param name="phoneNumberType">Type of phone number; possible values are: FixedLine, Mobile, FixedLineOrMobile, TollFree, PremiumRate,   SharedCost, Voip, PersonalNumber, Pager, Uan, Voicemail, Unknown.</param>
        /// <param name="e164Format">E.164 format of the phone number.</param>
        /// <param name="internationalFormat">Internaltional format of the phone number.</param>
        /// <param name="nationalFormat">National format of the phone number.</param>
        /// <param name="countryCode">Two digit country code of the phone number.</param>
        /// <param name="countryName">User-friendly long name of the country for the phone number.</param>
        public PhoneNumberValidationResponse(bool? isValid = default(bool?), bool? successful = default(bool?), string phoneNumberType = default(string), string e164Format = default(string), string internationalFormat = default(string), string nationalFormat = default(string), string countryCode = default(string), string countryName = default(string))
        {
            this.IsValid = isValid;
            this.Successful = successful;
            this.PhoneNumberType = phoneNumberType;
            this.E164Format = e164Format;
            this.InternationalFormat = internationalFormat;
            this.NationalFormat = nationalFormat;
            this.CountryCode = countryCode;
            this.CountryName = countryName;
        }
        
        /// <summary>
        /// True if the phone number is valid, false otherwise
        /// </summary>
        /// <value>True if the phone number is valid, false otherwise</value>
        [DataMember(Name="IsValid", EmitDefaultValue=false)]
        public bool? IsValid { get; set; }

        /// <summary>
        /// True if the operation was successful, false if there was an error during validation.  See IsValid for validation result.
        /// </summary>
        /// <value>True if the operation was successful, false if there was an error during validation.  See IsValid for validation result.</value>
        [DataMember(Name="Successful", EmitDefaultValue=false)]
        public bool? Successful { get; set; }

        /// <summary>
        /// Type of phone number; possible values are: FixedLine, Mobile, FixedLineOrMobile, TollFree, PremiumRate,   SharedCost, Voip, PersonalNumber, Pager, Uan, Voicemail, Unknown
        /// </summary>
        /// <value>Type of phone number; possible values are: FixedLine, Mobile, FixedLineOrMobile, TollFree, PremiumRate,   SharedCost, Voip, PersonalNumber, Pager, Uan, Voicemail, Unknown</value>
        [DataMember(Name="PhoneNumberType", EmitDefaultValue=false)]
        public string PhoneNumberType { get; set; }

        /// <summary>
        /// E.164 format of the phone number
        /// </summary>
        /// <value>E.164 format of the phone number</value>
        [DataMember(Name="E164Format", EmitDefaultValue=false)]
        public string E164Format { get; set; }

        /// <summary>
        /// Internaltional format of the phone number
        /// </summary>
        /// <value>Internaltional format of the phone number</value>
        [DataMember(Name="InternationalFormat", EmitDefaultValue=false)]
        public string InternationalFormat { get; set; }

        /// <summary>
        /// National format of the phone number
        /// </summary>
        /// <value>National format of the phone number</value>
        [DataMember(Name="NationalFormat", EmitDefaultValue=false)]
        public string NationalFormat { get; set; }

        /// <summary>
        /// Two digit country code of the phone number
        /// </summary>
        /// <value>Two digit country code of the phone number</value>
        [DataMember(Name="CountryCode", EmitDefaultValue=false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// User-friendly long name of the country for the phone number
        /// </summary>
        /// <value>User-friendly long name of the country for the phone number</value>
        [DataMember(Name="CountryName", EmitDefaultValue=false)]
        public string CountryName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PhoneNumberValidationResponse {\n");
            sb.Append("  IsValid: ").Append(IsValid).Append("\n");
            sb.Append("  Successful: ").Append(Successful).Append("\n");
            sb.Append("  PhoneNumberType: ").Append(PhoneNumberType).Append("\n");
            sb.Append("  E164Format: ").Append(E164Format).Append("\n");
            sb.Append("  InternationalFormat: ").Append(InternationalFormat).Append("\n");
            sb.Append("  NationalFormat: ").Append(NationalFormat).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  CountryName: ").Append(CountryName).Append("\n");
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
            return this.Equals(input as PhoneNumberValidationResponse);
        }

        /// <summary>
        /// Returns true if PhoneNumberValidationResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PhoneNumberValidationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PhoneNumberValidationResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsValid == input.IsValid ||
                    (this.IsValid != null &&
                    this.IsValid.Equals(input.IsValid))
                ) && 
                (
                    this.Successful == input.Successful ||
                    (this.Successful != null &&
                    this.Successful.Equals(input.Successful))
                ) && 
                (
                    this.PhoneNumberType == input.PhoneNumberType ||
                    (this.PhoneNumberType != null &&
                    this.PhoneNumberType.Equals(input.PhoneNumberType))
                ) && 
                (
                    this.E164Format == input.E164Format ||
                    (this.E164Format != null &&
                    this.E164Format.Equals(input.E164Format))
                ) && 
                (
                    this.InternationalFormat == input.InternationalFormat ||
                    (this.InternationalFormat != null &&
                    this.InternationalFormat.Equals(input.InternationalFormat))
                ) && 
                (
                    this.NationalFormat == input.NationalFormat ||
                    (this.NationalFormat != null &&
                    this.NationalFormat.Equals(input.NationalFormat))
                ) && 
                (
                    this.CountryCode == input.CountryCode ||
                    (this.CountryCode != null &&
                    this.CountryCode.Equals(input.CountryCode))
                ) && 
                (
                    this.CountryName == input.CountryName ||
                    (this.CountryName != null &&
                    this.CountryName.Equals(input.CountryName))
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
                if (this.IsValid != null)
                    hashCode = hashCode * 59 + this.IsValid.GetHashCode();
                if (this.Successful != null)
                    hashCode = hashCode * 59 + this.Successful.GetHashCode();
                if (this.PhoneNumberType != null)
                    hashCode = hashCode * 59 + this.PhoneNumberType.GetHashCode();
                if (this.E164Format != null)
                    hashCode = hashCode * 59 + this.E164Format.GetHashCode();
                if (this.InternationalFormat != null)
                    hashCode = hashCode * 59 + this.InternationalFormat.GetHashCode();
                if (this.NationalFormat != null)
                    hashCode = hashCode * 59 + this.NationalFormat.GetHashCode();
                if (this.CountryCode != null)
                    hashCode = hashCode * 59 + this.CountryCode.GetHashCode();
                if (this.CountryName != null)
                    hashCode = hashCode * 59 + this.CountryName.GetHashCode();
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
