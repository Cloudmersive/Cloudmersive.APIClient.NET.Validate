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
    /// Result of parsing an address into its component parts
    /// </summary>
    [DataContract]
    public partial class ParseAddressResponse :  IEquatable<ParseAddressResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ParseAddressResponse" /> class.
        /// </summary>
        /// <param name="successful">True if the parsing operation was successful, false otherwise.</param>
        /// <param name="building">The name of the building, house or structure if applicable, such as \&quot;Cloudmersive Building 2\&quot;.  This will often by null..</param>
        /// <param name="streetNumber">The street number or house number of the address.  For example, in the address \&quot;1600 Pennsylvania Avenue NW\&quot; the street number would be \&quot;1600\&quot;.  This value will typically be populated for most addresses..</param>
        /// <param name="street">The name of the street or road of the address.  For example, in the address \&quot;1600 Pennsylvania Avenue NW\&quot; the street number would be \&quot;Pennsylvania Avenue NW\&quot;..</param>
        /// <param name="city">The city of the address..</param>
        /// <param name="stateOrProvince">The state or province of the address..</param>
        /// <param name="postalCode">The postal code or zip code of the address..</param>
        /// <param name="countryFullName">Country of the address, if present in the address.  If not included in the address it will be null..</param>
        /// <param name="iSOTwoLetterCode">Two-letter ISO 3166-1 country code.</param>
        public ParseAddressResponse(bool? successful = default(bool?), string building = default(string), string streetNumber = default(string), string street = default(string), string city = default(string), string stateOrProvince = default(string), string postalCode = default(string), string countryFullName = default(string), string iSOTwoLetterCode = default(string))
        {
            this.Successful = successful;
            this.Building = building;
            this.StreetNumber = streetNumber;
            this.Street = street;
            this.City = city;
            this.StateOrProvince = stateOrProvince;
            this.PostalCode = postalCode;
            this.CountryFullName = countryFullName;
            this.ISOTwoLetterCode = iSOTwoLetterCode;
        }
        
        /// <summary>
        /// True if the parsing operation was successful, false otherwise
        /// </summary>
        /// <value>True if the parsing operation was successful, false otherwise</value>
        [DataMember(Name="Successful", EmitDefaultValue=false)]
        public bool? Successful { get; set; }

        /// <summary>
        /// The name of the building, house or structure if applicable, such as \&quot;Cloudmersive Building 2\&quot;.  This will often by null.
        /// </summary>
        /// <value>The name of the building, house or structure if applicable, such as \&quot;Cloudmersive Building 2\&quot;.  This will often by null.</value>
        [DataMember(Name="Building", EmitDefaultValue=false)]
        public string Building { get; set; }

        /// <summary>
        /// The street number or house number of the address.  For example, in the address \&quot;1600 Pennsylvania Avenue NW\&quot; the street number would be \&quot;1600\&quot;.  This value will typically be populated for most addresses.
        /// </summary>
        /// <value>The street number or house number of the address.  For example, in the address \&quot;1600 Pennsylvania Avenue NW\&quot; the street number would be \&quot;1600\&quot;.  This value will typically be populated for most addresses.</value>
        [DataMember(Name="StreetNumber", EmitDefaultValue=false)]
        public string StreetNumber { get; set; }

        /// <summary>
        /// The name of the street or road of the address.  For example, in the address \&quot;1600 Pennsylvania Avenue NW\&quot; the street number would be \&quot;Pennsylvania Avenue NW\&quot;.
        /// </summary>
        /// <value>The name of the street or road of the address.  For example, in the address \&quot;1600 Pennsylvania Avenue NW\&quot; the street number would be \&quot;Pennsylvania Avenue NW\&quot;.</value>
        [DataMember(Name="Street", EmitDefaultValue=false)]
        public string Street { get; set; }

        /// <summary>
        /// The city of the address.
        /// </summary>
        /// <value>The city of the address.</value>
        [DataMember(Name="City", EmitDefaultValue=false)]
        public string City { get; set; }

        /// <summary>
        /// The state or province of the address.
        /// </summary>
        /// <value>The state or province of the address.</value>
        [DataMember(Name="StateOrProvince", EmitDefaultValue=false)]
        public string StateOrProvince { get; set; }

        /// <summary>
        /// The postal code or zip code of the address.
        /// </summary>
        /// <value>The postal code or zip code of the address.</value>
        [DataMember(Name="PostalCode", EmitDefaultValue=false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Country of the address, if present in the address.  If not included in the address it will be null.
        /// </summary>
        /// <value>Country of the address, if present in the address.  If not included in the address it will be null.</value>
        [DataMember(Name="CountryFullName", EmitDefaultValue=false)]
        public string CountryFullName { get; set; }

        /// <summary>
        /// Two-letter ISO 3166-1 country code
        /// </summary>
        /// <value>Two-letter ISO 3166-1 country code</value>
        [DataMember(Name="ISOTwoLetterCode", EmitDefaultValue=false)]
        public string ISOTwoLetterCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ParseAddressResponse {\n");
            sb.Append("  Successful: ").Append(Successful).Append("\n");
            sb.Append("  Building: ").Append(Building).Append("\n");
            sb.Append("  StreetNumber: ").Append(StreetNumber).Append("\n");
            sb.Append("  Street: ").Append(Street).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  StateOrProvince: ").Append(StateOrProvince).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  CountryFullName: ").Append(CountryFullName).Append("\n");
            sb.Append("  ISOTwoLetterCode: ").Append(ISOTwoLetterCode).Append("\n");
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
            return this.Equals(input as ParseAddressResponse);
        }

        /// <summary>
        /// Returns true if ParseAddressResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ParseAddressResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ParseAddressResponse input)
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
                    this.Building == input.Building ||
                    (this.Building != null &&
                    this.Building.Equals(input.Building))
                ) && 
                (
                    this.StreetNumber == input.StreetNumber ||
                    (this.StreetNumber != null &&
                    this.StreetNumber.Equals(input.StreetNumber))
                ) && 
                (
                    this.Street == input.Street ||
                    (this.Street != null &&
                    this.Street.Equals(input.Street))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.StateOrProvince == input.StateOrProvince ||
                    (this.StateOrProvince != null &&
                    this.StateOrProvince.Equals(input.StateOrProvince))
                ) && 
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
                    this.ISOTwoLetterCode == input.ISOTwoLetterCode ||
                    (this.ISOTwoLetterCode != null &&
                    this.ISOTwoLetterCode.Equals(input.ISOTwoLetterCode))
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
                if (this.Building != null)
                    hashCode = hashCode * 59 + this.Building.GetHashCode();
                if (this.StreetNumber != null)
                    hashCode = hashCode * 59 + this.StreetNumber.GetHashCode();
                if (this.Street != null)
                    hashCode = hashCode * 59 + this.Street.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.StateOrProvince != null)
                    hashCode = hashCode * 59 + this.StateOrProvince.GetHashCode();
                if (this.PostalCode != null)
                    hashCode = hashCode * 59 + this.PostalCode.GetHashCode();
                if (this.CountryFullName != null)
                    hashCode = hashCode * 59 + this.CountryFullName.GetHashCode();
                if (this.ISOTwoLetterCode != null)
                    hashCode = hashCode * 59 + this.ISOTwoLetterCode.GetHashCode();
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