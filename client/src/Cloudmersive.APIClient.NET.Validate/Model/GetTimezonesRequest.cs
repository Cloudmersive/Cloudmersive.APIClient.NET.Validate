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
    /// Request to get time zones for a country
    /// </summary>
    [DataContract]
    public partial class GetTimezonesRequest :  IEquatable<GetTimezonesRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTimezonesRequest" /> class.
        /// </summary>
        /// <param name="countryCodeOrName">Can be the two-letter, three-letter country codes or country name.</param>
        public GetTimezonesRequest(string countryCodeOrName = default(string))
        {
            this.CountryCodeOrName = countryCodeOrName;
        }
        
        /// <summary>
        /// Can be the two-letter, three-letter country codes or country name
        /// </summary>
        /// <value>Can be the two-letter, three-letter country codes or country name</value>
        [DataMember(Name="CountryCodeOrName", EmitDefaultValue=false)]
        public string CountryCodeOrName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetTimezonesRequest {\n");
            sb.Append("  CountryCodeOrName: ").Append(CountryCodeOrName).Append("\n");
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
            return this.Equals(input as GetTimezonesRequest);
        }

        /// <summary>
        /// Returns true if GetTimezonesRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GetTimezonesRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetTimezonesRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CountryCodeOrName == input.CountryCodeOrName ||
                    (this.CountryCodeOrName != null &&
                    this.CountryCodeOrName.Equals(input.CountryCodeOrName))
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
                if (this.CountryCodeOrName != null)
                    hashCode = hashCode * 59 + this.CountryCodeOrName.GetHashCode();
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
