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
    /// User-Agent parse and validation request
    /// </summary>
    [DataContract]
    public partial class UserAgentValidateRequest :  IEquatable<UserAgentValidateRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserAgentValidateRequest" /> class.
        /// </summary>
        /// <param name="userAgentString">The user agent string you wish to parse and validate.</param>
        public UserAgentValidateRequest(string userAgentString = default(string))
        {
            this.UserAgentString = userAgentString;
        }
        
        /// <summary>
        /// The user agent string you wish to parse and validate
        /// </summary>
        /// <value>The user agent string you wish to parse and validate</value>
        [DataMember(Name="UserAgentString", EmitDefaultValue=false)]
        public string UserAgentString { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserAgentValidateRequest {\n");
            sb.Append("  UserAgentString: ").Append(UserAgentString).Append("\n");
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
            return this.Equals(input as UserAgentValidateRequest);
        }

        /// <summary>
        /// Returns true if UserAgentValidateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UserAgentValidateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserAgentValidateRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UserAgentString == input.UserAgentString ||
                    (this.UserAgentString != null &&
                    this.UserAgentString.Equals(input.UserAgentString))
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
                if (this.UserAgentString != null)
                    hashCode = hashCode * 59 + this.UserAgentString.GetHashCode();
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