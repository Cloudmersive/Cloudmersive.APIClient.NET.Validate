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
    /// Result of validating a state
    /// </summary>
    [DataContract]
    public partial class ValidateStateResponse :  IEquatable<ValidateStateResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateStateResponse" /> class.
        /// </summary>
        /// <param name="validState">True if the address is valid, false otherwise.</param>
        /// <param name="stateOrProvince">If valid; State or province corresponding to the input state name, such as &#39;CA&#39; or &#39;California&#39;.</param>
        /// <param name="latitude">If the postal code is valid, the degrees latitude of the centroid of the state, null otherwise.</param>
        /// <param name="longitude">If the postal code is valid, the degrees longitude of the centroid of the state, null otherwise.</param>
        public ValidateStateResponse(bool? validState = default(bool?), string stateOrProvince = default(string), double? latitude = default(double?), double? longitude = default(double?))
        {
            this.ValidState = validState;
            this.StateOrProvince = stateOrProvince;
            this.Latitude = latitude;
            this.Longitude = longitude;
        }
        
        /// <summary>
        /// True if the address is valid, false otherwise
        /// </summary>
        /// <value>True if the address is valid, false otherwise</value>
        [DataMember(Name="ValidState", EmitDefaultValue=false)]
        public bool? ValidState { get; set; }

        /// <summary>
        /// If valid; State or province corresponding to the input state name, such as &#39;CA&#39; or &#39;California&#39;
        /// </summary>
        /// <value>If valid; State or province corresponding to the input state name, such as &#39;CA&#39; or &#39;California&#39;</value>
        [DataMember(Name="StateOrProvince", EmitDefaultValue=false)]
        public string StateOrProvince { get; set; }

        /// <summary>
        /// If the postal code is valid, the degrees latitude of the centroid of the state, null otherwise
        /// </summary>
        /// <value>If the postal code is valid, the degrees latitude of the centroid of the state, null otherwise</value>
        [DataMember(Name="Latitude", EmitDefaultValue=false)]
        public double? Latitude { get; set; }

        /// <summary>
        /// If the postal code is valid, the degrees longitude of the centroid of the state, null otherwise
        /// </summary>
        /// <value>If the postal code is valid, the degrees longitude of the centroid of the state, null otherwise</value>
        [DataMember(Name="Longitude", EmitDefaultValue=false)]
        public double? Longitude { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ValidateStateResponse {\n");
            sb.Append("  ValidState: ").Append(ValidState).Append("\n");
            sb.Append("  StateOrProvince: ").Append(StateOrProvince).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
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
            return this.Equals(input as ValidateStateResponse);
        }

        /// <summary>
        /// Returns true if ValidateStateResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ValidateStateResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ValidateStateResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ValidState == input.ValidState ||
                    (this.ValidState != null &&
                    this.ValidState.Equals(input.ValidState))
                ) && 
                (
                    this.StateOrProvince == input.StateOrProvince ||
                    (this.StateOrProvince != null &&
                    this.StateOrProvince.Equals(input.StateOrProvince))
                ) && 
                (
                    this.Latitude == input.Latitude ||
                    (this.Latitude != null &&
                    this.Latitude.Equals(input.Latitude))
                ) && 
                (
                    this.Longitude == input.Longitude ||
                    (this.Longitude != null &&
                    this.Longitude.Equals(input.Longitude))
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
                if (this.ValidState != null)
                    hashCode = hashCode * 59 + this.ValidState.GetHashCode();
                if (this.StateOrProvince != null)
                    hashCode = hashCode * 59 + this.StateOrProvince.GetHashCode();
                if (this.Latitude != null)
                    hashCode = hashCode * 59 + this.Latitude.GetHashCode();
                if (this.Longitude != null)
                    hashCode = hashCode * 59 + this.Longitude.GetHashCode();
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