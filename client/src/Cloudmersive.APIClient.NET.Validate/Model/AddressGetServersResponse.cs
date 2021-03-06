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
    /// Result of a partial email address validation
    /// </summary>
    [DataContract]
    public partial class AddressGetServersResponse :  IEquatable<AddressGetServersResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressGetServersResponse" /> class.
        /// </summary>
        /// <param name="success">True if partial address validation was successufl, false otherwise.</param>
        /// <param name="servers">Email servers for this email address.</param>
        public AddressGetServersResponse(bool? success = default(bool?), List<string> servers = default(List<string>))
        {
            this.Success = success;
            this.Servers = servers;
        }
        
        /// <summary>
        /// True if partial address validation was successufl, false otherwise
        /// </summary>
        /// <value>True if partial address validation was successufl, false otherwise</value>
        [DataMember(Name="Success", EmitDefaultValue=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// Email servers for this email address
        /// </summary>
        /// <value>Email servers for this email address</value>
        [DataMember(Name="Servers", EmitDefaultValue=false)]
        public List<string> Servers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddressGetServersResponse {\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
            sb.Append("  Servers: ").Append(Servers).Append("\n");
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
            return this.Equals(input as AddressGetServersResponse);
        }

        /// <summary>
        /// Returns true if AddressGetServersResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AddressGetServersResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddressGetServersResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Success == input.Success ||
                    (this.Success != null &&
                    this.Success.Equals(input.Success))
                ) && 
                (
                    this.Servers == input.Servers ||
                    this.Servers != null &&
                    this.Servers.SequenceEqual(input.Servers)
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
                if (this.Success != null)
                    hashCode = hashCode * 59 + this.Success.GetHashCode();
                if (this.Servers != null)
                    hashCode = hashCode * 59 + this.Servers.GetHashCode();
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
