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
    /// Result of the lead enrichment process
    /// </summary>
    [DataContract]
    public partial class LeadEnrichmentResponse :  IEquatable<LeadEnrichmentResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LeadEnrichmentResponse" /> class.
        /// </summary>
        /// <param name="successful">True if the operation was successful, false otherwise.</param>
        /// <param name="contactBusinessEmail">The person&#39;s business email address for the lead.</param>
        /// <param name="companyName">Name of the company for the lead.</param>
        /// <param name="companyDomainName">Domain name / website for the lead.</param>
        /// <param name="companyHouseNumber">House number of the address of the company for the lead.</param>
        /// <param name="companyStreet">Street name of the address of the company for the lead.</param>
        /// <param name="companyCity">City of the address of the company for the lead.</param>
        /// <param name="companyStateOrProvince">State or Province of the address of the company for the lead.</param>
        /// <param name="companyPostalCode">Postal Code of the address of the company for the lead.</param>
        /// <param name="companyCountry">Country of the address of the company for the lead.</param>
        /// <param name="companyVATNumber">VAT number of the company for the lead.</param>
        /// <param name="employeeCount">Count of employees at the company (estimated), if available.</param>
        public LeadEnrichmentResponse(bool? successful = default(bool?), string contactBusinessEmail = default(string), string companyName = default(string), string companyDomainName = default(string), string companyHouseNumber = default(string), string companyStreet = default(string), string companyCity = default(string), string companyStateOrProvince = default(string), string companyPostalCode = default(string), string companyCountry = default(string), string companyVATNumber = default(string), int? employeeCount = default(int?))
        {
            this.Successful = successful;
            this.ContactBusinessEmail = contactBusinessEmail;
            this.CompanyName = companyName;
            this.CompanyDomainName = companyDomainName;
            this.CompanyHouseNumber = companyHouseNumber;
            this.CompanyStreet = companyStreet;
            this.CompanyCity = companyCity;
            this.CompanyStateOrProvince = companyStateOrProvince;
            this.CompanyPostalCode = companyPostalCode;
            this.CompanyCountry = companyCountry;
            this.CompanyVATNumber = companyVATNumber;
            this.EmployeeCount = employeeCount;
        }
        
        /// <summary>
        /// True if the operation was successful, false otherwise
        /// </summary>
        /// <value>True if the operation was successful, false otherwise</value>
        [DataMember(Name="Successful", EmitDefaultValue=false)]
        public bool? Successful { get; set; }

        /// <summary>
        /// The person&#39;s business email address for the lead
        /// </summary>
        /// <value>The person&#39;s business email address for the lead</value>
        [DataMember(Name="ContactBusinessEmail", EmitDefaultValue=false)]
        public string ContactBusinessEmail { get; set; }

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
        /// VAT number of the company for the lead
        /// </summary>
        /// <value>VAT number of the company for the lead</value>
        [DataMember(Name="CompanyVATNumber", EmitDefaultValue=false)]
        public string CompanyVATNumber { get; set; }

        /// <summary>
        /// Count of employees at the company (estimated), if available
        /// </summary>
        /// <value>Count of employees at the company (estimated), if available</value>
        [DataMember(Name="EmployeeCount", EmitDefaultValue=false)]
        public int? EmployeeCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LeadEnrichmentResponse {\n");
            sb.Append("  Successful: ").Append(Successful).Append("\n");
            sb.Append("  ContactBusinessEmail: ").Append(ContactBusinessEmail).Append("\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  CompanyDomainName: ").Append(CompanyDomainName).Append("\n");
            sb.Append("  CompanyHouseNumber: ").Append(CompanyHouseNumber).Append("\n");
            sb.Append("  CompanyStreet: ").Append(CompanyStreet).Append("\n");
            sb.Append("  CompanyCity: ").Append(CompanyCity).Append("\n");
            sb.Append("  CompanyStateOrProvince: ").Append(CompanyStateOrProvince).Append("\n");
            sb.Append("  CompanyPostalCode: ").Append(CompanyPostalCode).Append("\n");
            sb.Append("  CompanyCountry: ").Append(CompanyCountry).Append("\n");
            sb.Append("  CompanyVATNumber: ").Append(CompanyVATNumber).Append("\n");
            sb.Append("  EmployeeCount: ").Append(EmployeeCount).Append("\n");
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
            return this.Equals(input as LeadEnrichmentResponse);
        }

        /// <summary>
        /// Returns true if LeadEnrichmentResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of LeadEnrichmentResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LeadEnrichmentResponse input)
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
                    this.ContactBusinessEmail == input.ContactBusinessEmail ||
                    (this.ContactBusinessEmail != null &&
                    this.ContactBusinessEmail.Equals(input.ContactBusinessEmail))
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
                    this.CompanyVATNumber == input.CompanyVATNumber ||
                    (this.CompanyVATNumber != null &&
                    this.CompanyVATNumber.Equals(input.CompanyVATNumber))
                ) && 
                (
                    this.EmployeeCount == input.EmployeeCount ||
                    (this.EmployeeCount != null &&
                    this.EmployeeCount.Equals(input.EmployeeCount))
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
                if (this.ContactBusinessEmail != null)
                    hashCode = hashCode * 59 + this.ContactBusinessEmail.GetHashCode();
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
                if (this.CompanyVATNumber != null)
                    hashCode = hashCode * 59 + this.CompanyVATNumber.GetHashCode();
                if (this.EmployeeCount != null)
                    hashCode = hashCode * 59 + this.EmployeeCount.GetHashCode();
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
