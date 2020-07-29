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
    /// Input lead contact; fill in known fields to extend them with matched field values
    /// </summary>
    [DataContract]
    public partial class LeadEnrichmentRequest :  IEquatable<LeadEnrichmentRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LeadEnrichmentRequest" /> class.
        /// </summary>
        /// <param name="contactBusinessEmail">The person&#39;s business email address for the lead.</param>
        /// <param name="contactFirstName">The person&#39;s first name for the lead.</param>
        /// <param name="contactLastName">The person&#39;s last name for the lead.</param>
        /// <param name="companyName">Name of the company for the lead.</param>
        /// <param name="companyDomainName">Domain name / website for the lead.</param>
        /// <param name="companyHouseNumber">House number of the address of the company for the lead.</param>
        /// <param name="companyStreet">Street name of the address of the company for the lead.</param>
        /// <param name="companyCity">City of the address of the company for the lead.</param>
        /// <param name="companyStateOrProvince">State or Province of the address of the company for the lead.</param>
        /// <param name="companyPostalCode">Postal Code of the address of the company for the lead.</param>
        /// <param name="companyCountry">Country of the address of the company for the lead.</param>
        /// <param name="companyCountryCode">Country Code (2-letter ISO 3166-1) of the address of the company for the lead.</param>
        /// <param name="companyTelephone">Telephone of the company office for the lead.</param>
        /// <param name="companyVATNumber">VAT number of the company for the lead.</param>
        public LeadEnrichmentRequest(string contactBusinessEmail = default(string), string contactFirstName = default(string), string contactLastName = default(string), string companyName = default(string), string companyDomainName = default(string), string companyHouseNumber = default(string), string companyStreet = default(string), string companyCity = default(string), string companyStateOrProvince = default(string), string companyPostalCode = default(string), string companyCountry = default(string), string companyCountryCode = default(string), string companyTelephone = default(string), string companyVATNumber = default(string))
        {
            this.ContactBusinessEmail = contactBusinessEmail;
            this.ContactFirstName = contactFirstName;
            this.ContactLastName = contactLastName;
            this.CompanyName = companyName;
            this.CompanyDomainName = companyDomainName;
            this.CompanyHouseNumber = companyHouseNumber;
            this.CompanyStreet = companyStreet;
            this.CompanyCity = companyCity;
            this.CompanyStateOrProvince = companyStateOrProvince;
            this.CompanyPostalCode = companyPostalCode;
            this.CompanyCountry = companyCountry;
            this.CompanyCountryCode = companyCountryCode;
            this.CompanyTelephone = companyTelephone;
            this.CompanyVATNumber = companyVATNumber;
        }
        
        /// <summary>
        /// The person&#39;s business email address for the lead
        /// </summary>
        /// <value>The person&#39;s business email address for the lead</value>
        [DataMember(Name="ContactBusinessEmail", EmitDefaultValue=false)]
        public string ContactBusinessEmail { get; set; }

        /// <summary>
        /// The person&#39;s first name for the lead
        /// </summary>
        /// <value>The person&#39;s first name for the lead</value>
        [DataMember(Name="ContactFirstName", EmitDefaultValue=false)]
        public string ContactFirstName { get; set; }

        /// <summary>
        /// The person&#39;s last name for the lead
        /// </summary>
        /// <value>The person&#39;s last name for the lead</value>
        [DataMember(Name="ContactLastName", EmitDefaultValue=false)]
        public string ContactLastName { get; set; }

        /// <summary>
        /// Name of the company for the lead
        /// </summary>
        /// <value>Name of the company for the lead</value>
        [DataMember(Name="CompanyName", EmitDefaultValue=false)]
        public string CompanyName { get; set; }

        /// <summary>
        /// Domain name / website for the lead
        /// </summary>
        /// <value>Domain name / website for the lead</value>
        [DataMember(Name="CompanyDomainName", EmitDefaultValue=false)]
        public string CompanyDomainName { get; set; }

        /// <summary>
        /// House number of the address of the company for the lead
        /// </summary>
        /// <value>House number of the address of the company for the lead</value>
        [DataMember(Name="CompanyHouseNumber", EmitDefaultValue=false)]
        public string CompanyHouseNumber { get; set; }

        /// <summary>
        /// Street name of the address of the company for the lead
        /// </summary>
        /// <value>Street name of the address of the company for the lead</value>
        [DataMember(Name="CompanyStreet", EmitDefaultValue=false)]
        public string CompanyStreet { get; set; }

        /// <summary>
        /// City of the address of the company for the lead
        /// </summary>
        /// <value>City of the address of the company for the lead</value>
        [DataMember(Name="CompanyCity", EmitDefaultValue=false)]
        public string CompanyCity { get; set; }

        /// <summary>
        /// State or Province of the address of the company for the lead
        /// </summary>
        /// <value>State or Province of the address of the company for the lead</value>
        [DataMember(Name="CompanyStateOrProvince", EmitDefaultValue=false)]
        public string CompanyStateOrProvince { get; set; }

        /// <summary>
        /// Postal Code of the address of the company for the lead
        /// </summary>
        /// <value>Postal Code of the address of the company for the lead</value>
        [DataMember(Name="CompanyPostalCode", EmitDefaultValue=false)]
        public string CompanyPostalCode { get; set; }

        /// <summary>
        /// Country of the address of the company for the lead
        /// </summary>
        /// <value>Country of the address of the company for the lead</value>
        [DataMember(Name="CompanyCountry", EmitDefaultValue=false)]
        public string CompanyCountry { get; set; }

        /// <summary>
        /// Country Code (2-letter ISO 3166-1) of the address of the company for the lead
        /// </summary>
        /// <value>Country Code (2-letter ISO 3166-1) of the address of the company for the lead</value>
        [DataMember(Name="CompanyCountryCode", EmitDefaultValue=false)]
        public string CompanyCountryCode { get; set; }

        /// <summary>
        /// Telephone of the company office for the lead
        /// </summary>
        /// <value>Telephone of the company office for the lead</value>
        [DataMember(Name="CompanyTelephone", EmitDefaultValue=false)]
        public string CompanyTelephone { get; set; }

        /// <summary>
        /// VAT number of the company for the lead
        /// </summary>
        /// <value>VAT number of the company for the lead</value>
        [DataMember(Name="CompanyVATNumber", EmitDefaultValue=false)]
        public string CompanyVATNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LeadEnrichmentRequest {\n");
            sb.Append("  ContactBusinessEmail: ").Append(ContactBusinessEmail).Append("\n");
            sb.Append("  ContactFirstName: ").Append(ContactFirstName).Append("\n");
            sb.Append("  ContactLastName: ").Append(ContactLastName).Append("\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  CompanyDomainName: ").Append(CompanyDomainName).Append("\n");
            sb.Append("  CompanyHouseNumber: ").Append(CompanyHouseNumber).Append("\n");
            sb.Append("  CompanyStreet: ").Append(CompanyStreet).Append("\n");
            sb.Append("  CompanyCity: ").Append(CompanyCity).Append("\n");
            sb.Append("  CompanyStateOrProvince: ").Append(CompanyStateOrProvince).Append("\n");
            sb.Append("  CompanyPostalCode: ").Append(CompanyPostalCode).Append("\n");
            sb.Append("  CompanyCountry: ").Append(CompanyCountry).Append("\n");
            sb.Append("  CompanyCountryCode: ").Append(CompanyCountryCode).Append("\n");
            sb.Append("  CompanyTelephone: ").Append(CompanyTelephone).Append("\n");
            sb.Append("  CompanyVATNumber: ").Append(CompanyVATNumber).Append("\n");
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
            return this.Equals(input as LeadEnrichmentRequest);
        }

        /// <summary>
        /// Returns true if LeadEnrichmentRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of LeadEnrichmentRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LeadEnrichmentRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ContactBusinessEmail == input.ContactBusinessEmail ||
                    (this.ContactBusinessEmail != null &&
                    this.ContactBusinessEmail.Equals(input.ContactBusinessEmail))
                ) && 
                (
                    this.ContactFirstName == input.ContactFirstName ||
                    (this.ContactFirstName != null &&
                    this.ContactFirstName.Equals(input.ContactFirstName))
                ) && 
                (
                    this.ContactLastName == input.ContactLastName ||
                    (this.ContactLastName != null &&
                    this.ContactLastName.Equals(input.ContactLastName))
                ) && 
                (
                    this.CompanyName == input.CompanyName ||
                    (this.CompanyName != null &&
                    this.CompanyName.Equals(input.CompanyName))
                ) && 
                (
                    this.CompanyDomainName == input.CompanyDomainName ||
                    (this.CompanyDomainName != null &&
                    this.CompanyDomainName.Equals(input.CompanyDomainName))
                ) && 
                (
                    this.CompanyHouseNumber == input.CompanyHouseNumber ||
                    (this.CompanyHouseNumber != null &&
                    this.CompanyHouseNumber.Equals(input.CompanyHouseNumber))
                ) && 
                (
                    this.CompanyStreet == input.CompanyStreet ||
                    (this.CompanyStreet != null &&
                    this.CompanyStreet.Equals(input.CompanyStreet))
                ) && 
                (
                    this.CompanyCity == input.CompanyCity ||
                    (this.CompanyCity != null &&
                    this.CompanyCity.Equals(input.CompanyCity))
                ) && 
                (
                    this.CompanyStateOrProvince == input.CompanyStateOrProvince ||
                    (this.CompanyStateOrProvince != null &&
                    this.CompanyStateOrProvince.Equals(input.CompanyStateOrProvince))
                ) && 
                (
                    this.CompanyPostalCode == input.CompanyPostalCode ||
                    (this.CompanyPostalCode != null &&
                    this.CompanyPostalCode.Equals(input.CompanyPostalCode))
                ) && 
                (
                    this.CompanyCountry == input.CompanyCountry ||
                    (this.CompanyCountry != null &&
                    this.CompanyCountry.Equals(input.CompanyCountry))
                ) && 
                (
                    this.CompanyCountryCode == input.CompanyCountryCode ||
                    (this.CompanyCountryCode != null &&
                    this.CompanyCountryCode.Equals(input.CompanyCountryCode))
                ) && 
                (
                    this.CompanyTelephone == input.CompanyTelephone ||
                    (this.CompanyTelephone != null &&
                    this.CompanyTelephone.Equals(input.CompanyTelephone))
                ) && 
                (
                    this.CompanyVATNumber == input.CompanyVATNumber ||
                    (this.CompanyVATNumber != null &&
                    this.CompanyVATNumber.Equals(input.CompanyVATNumber))
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
                if (this.ContactBusinessEmail != null)
                    hashCode = hashCode * 59 + this.ContactBusinessEmail.GetHashCode();
                if (this.ContactFirstName != null)
                    hashCode = hashCode * 59 + this.ContactFirstName.GetHashCode();
                if (this.ContactLastName != null)
                    hashCode = hashCode * 59 + this.ContactLastName.GetHashCode();
                if (this.CompanyName != null)
                    hashCode = hashCode * 59 + this.CompanyName.GetHashCode();
                if (this.CompanyDomainName != null)
                    hashCode = hashCode * 59 + this.CompanyDomainName.GetHashCode();
                if (this.CompanyHouseNumber != null)
                    hashCode = hashCode * 59 + this.CompanyHouseNumber.GetHashCode();
                if (this.CompanyStreet != null)
                    hashCode = hashCode * 59 + this.CompanyStreet.GetHashCode();
                if (this.CompanyCity != null)
                    hashCode = hashCode * 59 + this.CompanyCity.GetHashCode();
                if (this.CompanyStateOrProvince != null)
                    hashCode = hashCode * 59 + this.CompanyStateOrProvince.GetHashCode();
                if (this.CompanyPostalCode != null)
                    hashCode = hashCode * 59 + this.CompanyPostalCode.GetHashCode();
                if (this.CompanyCountry != null)
                    hashCode = hashCode * 59 + this.CompanyCountry.GetHashCode();
                if (this.CompanyCountryCode != null)
                    hashCode = hashCode * 59 + this.CompanyCountryCode.GetHashCode();
                if (this.CompanyTelephone != null)
                    hashCode = hashCode * 59 + this.CompanyTelephone.GetHashCode();
                if (this.CompanyVATNumber != null)
                    hashCode = hashCode * 59 + this.CompanyVATNumber.GetHashCode();
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