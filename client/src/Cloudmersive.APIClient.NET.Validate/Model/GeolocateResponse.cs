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
    /// Geolocation result of performing an IP address geolocation operation.  This product includes GeoLite2 data created by MaxMind, available from www.maxmind.com.
    /// </summary>
    [DataContract]
    public partial class GeolocateResponse :  IEquatable<GeolocateResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GeolocateResponse" /> class.
        /// </summary>
        /// <param name="countryCode">Two-letter country code of IP address.</param>
        /// <param name="countryName">Country name of IP address.</param>
        /// <param name="city">City of IP address.</param>
        /// <param name="regionCode">State/region code of IP address.</param>
        /// <param name="regionName">State/region of IP address.</param>
        /// <param name="zipCode">Zip or postal code of IP address.</param>
        /// <param name="timezoneStandardName">Timezone of IP address.</param>
        /// <param name="latitude">Latitude of IP address.</param>
        /// <param name="longitude">Longitude of IP address.</param>
        public GeolocateResponse(string countryCode = default(string), string countryName = default(string), string city = default(string), string regionCode = default(string), string regionName = default(string), string zipCode = default(string), string timezoneStandardName = default(string), double? latitude = default(double?), double? longitude = default(double?))
        {
            this.CountryCode = countryCode;
            this.CountryName = countryName;
            this.City = city;
            this.RegionCode = regionCode;
            this.RegionName = regionName;
            this.ZipCode = zipCode;
            this.TimezoneStandardName = timezoneStandardName;
            this.Latitude = latitude;
            this.Longitude = longitude;
        }
        
        /// <summary>
        /// Two-letter country code of IP address
        /// </summary>
        /// <value>Two-letter country code of IP address</value>
        [DataMember(Name="CountryCode", EmitDefaultValue=false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Country name of IP address
        /// </summary>
        /// <value>Country name of IP address</value>
        [DataMember(Name="CountryName", EmitDefaultValue=false)]
        public string CountryName { get; set; }

        /// <summary>
        /// City of IP address
        /// </summary>
        /// <value>City of IP address</value>
        [DataMember(Name="City", EmitDefaultValue=false)]
        public string City { get; set; }

        /// <summary>
        /// State/region code of IP address
        /// </summary>
        /// <value>State/region code of IP address</value>
        [DataMember(Name="RegionCode", EmitDefaultValue=false)]
        public string RegionCode { get; set; }

        /// <summary>
        /// State/region of IP address
        /// </summary>
        /// <value>State/region of IP address</value>
        [DataMember(Name="RegionName", EmitDefaultValue=false)]
        public string RegionName { get; set; }

        /// <summary>
        /// Zip or postal code of IP address
        /// </summary>
        /// <value>Zip or postal code of IP address</value>
        [DataMember(Name="ZipCode", EmitDefaultValue=false)]
        public string ZipCode { get; set; }

        /// <summary>
        /// Timezone of IP address
        /// </summary>
        /// <value>Timezone of IP address</value>
        [DataMember(Name="TimezoneStandardName", EmitDefaultValue=false)]
        public string TimezoneStandardName { get; set; }

        /// <summary>
        /// Latitude of IP address
        /// </summary>
        /// <value>Latitude of IP address</value>
        [DataMember(Name="Latitude", EmitDefaultValue=false)]
        public double? Latitude { get; set; }

        /// <summary>
        /// Longitude of IP address
        /// </summary>
        /// <value>Longitude of IP address</value>
        [DataMember(Name="Longitude", EmitDefaultValue=false)]
        public double? Longitude { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GeolocateResponse {\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  CountryName: ").Append(CountryName).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  RegionCode: ").Append(RegionCode).Append("\n");
            sb.Append("  RegionName: ").Append(RegionName).Append("\n");
            sb.Append("  ZipCode: ").Append(ZipCode).Append("\n");
            sb.Append("  TimezoneStandardName: ").Append(TimezoneStandardName).Append("\n");
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
            return this.Equals(input as GeolocateResponse);
        }

        /// <summary>
        /// Returns true if GeolocateResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GeolocateResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GeolocateResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CountryCode == input.CountryCode ||
                    (this.CountryCode != null &&
                    this.CountryCode.Equals(input.CountryCode))
                ) && 
                (
                    this.CountryName == input.CountryName ||
                    (this.CountryName != null &&
                    this.CountryName.Equals(input.CountryName))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.RegionCode == input.RegionCode ||
                    (this.RegionCode != null &&
                    this.RegionCode.Equals(input.RegionCode))
                ) && 
                (
                    this.RegionName == input.RegionName ||
                    (this.RegionName != null &&
                    this.RegionName.Equals(input.RegionName))
                ) && 
                (
                    this.ZipCode == input.ZipCode ||
                    (this.ZipCode != null &&
                    this.ZipCode.Equals(input.ZipCode))
                ) && 
                (
                    this.TimezoneStandardName == input.TimezoneStandardName ||
                    (this.TimezoneStandardName != null &&
                    this.TimezoneStandardName.Equals(input.TimezoneStandardName))
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
                if (this.CountryCode != null)
                    hashCode = hashCode * 59 + this.CountryCode.GetHashCode();
                if (this.CountryName != null)
                    hashCode = hashCode * 59 + this.CountryName.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.RegionCode != null)
                    hashCode = hashCode * 59 + this.RegionCode.GetHashCode();
                if (this.RegionName != null)
                    hashCode = hashCode * 59 + this.RegionName.GetHashCode();
                if (this.ZipCode != null)
                    hashCode = hashCode * 59 + this.ZipCode.GetHashCode();
                if (this.TimezoneStandardName != null)
                    hashCode = hashCode * 59 + this.TimezoneStandardName.GetHashCode();
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
