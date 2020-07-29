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
    /// The result of a User-Agent validation request
    /// </summary>
    [DataContract]
    public partial class UserAgentValidateResponse :  IEquatable<UserAgentValidateResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserAgentValidateResponse" /> class.
        /// </summary>
        /// <param name="successful">True if the operation was successful, false otherwise.</param>
        /// <param name="isBot">True if the request is a known robot, false otherwise.</param>
        /// <param name="botName">Optional; name of the robot if the request was from a known robot, otherwise null.</param>
        /// <param name="botURL">Optional; if available, the URL to the robot.</param>
        /// <param name="operatingSystem">Operating System of the User-Agent (e.g. Windows).</param>
        /// <param name="operatingSystemCPUPlatform">The CPU platform of the User-Agent (e.g. x64).</param>
        /// <param name="operatingSystemVersion">The version of the operating system of the User-Agent (e.g. \&quot;10\&quot; for Windows 10).</param>
        /// <param name="deviceType">Device type of the User-Agent; possible values are \&quot;DESKTOP\&quot;, \&quot;SMARTPHONE\&quot;, \&quot;TABLET\&quot;.</param>
        /// <param name="deviceBrandName">Brand name of the User-Agent.</param>
        /// <param name="deviceModel">Model name or number of the User-Agent.</param>
        /// <param name="browserName">Name of the Browser.</param>
        /// <param name="browserVersion">Version of the Browser.</param>
        /// <param name="browserEngineName">Name of the Browser Engine.</param>
        /// <param name="browserEngineVersion">Version of the Browser Engine.</param>
        public UserAgentValidateResponse(bool? successful = default(bool?), bool? isBot = default(bool?), string botName = default(string), string botURL = default(string), string operatingSystem = default(string), string operatingSystemCPUPlatform = default(string), string operatingSystemVersion = default(string), string deviceType = default(string), string deviceBrandName = default(string), string deviceModel = default(string), string browserName = default(string), string browserVersion = default(string), string browserEngineName = default(string), string browserEngineVersion = default(string))
        {
            this.Successful = successful;
            this.IsBot = isBot;
            this.BotName = botName;
            this.BotURL = botURL;
            this.OperatingSystem = operatingSystem;
            this.OperatingSystemCPUPlatform = operatingSystemCPUPlatform;
            this.OperatingSystemVersion = operatingSystemVersion;
            this.DeviceType = deviceType;
            this.DeviceBrandName = deviceBrandName;
            this.DeviceModel = deviceModel;
            this.BrowserName = browserName;
            this.BrowserVersion = browserVersion;
            this.BrowserEngineName = browserEngineName;
            this.BrowserEngineVersion = browserEngineVersion;
        }
        
        /// <summary>
        /// True if the operation was successful, false otherwise
        /// </summary>
        /// <value>True if the operation was successful, false otherwise</value>
        [DataMember(Name="Successful", EmitDefaultValue=false)]
        public bool? Successful { get; set; }

        /// <summary>
        /// True if the request is a known robot, false otherwise
        /// </summary>
        /// <value>True if the request is a known robot, false otherwise</value>
        [DataMember(Name="IsBot", EmitDefaultValue=false)]
        public bool? IsBot { get; set; }

        /// <summary>
        /// Optional; name of the robot if the request was from a known robot, otherwise null
        /// </summary>
        /// <value>Optional; name of the robot if the request was from a known robot, otherwise null</value>
        [DataMember(Name="BotName", EmitDefaultValue=false)]
        public string BotName { get; set; }

        /// <summary>
        /// Optional; if available, the URL to the robot
        /// </summary>
        /// <value>Optional; if available, the URL to the robot</value>
        [DataMember(Name="BotURL", EmitDefaultValue=false)]
        public string BotURL { get; set; }

        /// <summary>
        /// Operating System of the User-Agent (e.g. Windows)
        /// </summary>
        /// <value>Operating System of the User-Agent (e.g. Windows)</value>
        [DataMember(Name="OperatingSystem", EmitDefaultValue=false)]
        public string OperatingSystem { get; set; }

        /// <summary>
        /// The CPU platform of the User-Agent (e.g. x64)
        /// </summary>
        /// <value>The CPU platform of the User-Agent (e.g. x64)</value>
        [DataMember(Name="OperatingSystemCPUPlatform", EmitDefaultValue=false)]
        public string OperatingSystemCPUPlatform { get; set; }

        /// <summary>
        /// The version of the operating system of the User-Agent (e.g. \&quot;10\&quot; for Windows 10)
        /// </summary>
        /// <value>The version of the operating system of the User-Agent (e.g. \&quot;10\&quot; for Windows 10)</value>
        [DataMember(Name="OperatingSystemVersion", EmitDefaultValue=false)]
        public string OperatingSystemVersion { get; set; }

        /// <summary>
        /// Device type of the User-Agent; possible values are \&quot;DESKTOP\&quot;, \&quot;SMARTPHONE\&quot;, \&quot;TABLET\&quot;
        /// </summary>
        /// <value>Device type of the User-Agent; possible values are \&quot;DESKTOP\&quot;, \&quot;SMARTPHONE\&quot;, \&quot;TABLET\&quot;</value>
        [DataMember(Name="DeviceType", EmitDefaultValue=false)]
        public string DeviceType { get; set; }

        /// <summary>
        /// Brand name of the User-Agent
        /// </summary>
        /// <value>Brand name of the User-Agent</value>
        [DataMember(Name="DeviceBrandName", EmitDefaultValue=false)]
        public string DeviceBrandName { get; set; }

        /// <summary>
        /// Model name or number of the User-Agent
        /// </summary>
        /// <value>Model name or number of the User-Agent</value>
        [DataMember(Name="DeviceModel", EmitDefaultValue=false)]
        public string DeviceModel { get; set; }

        /// <summary>
        /// Name of the Browser
        /// </summary>
        /// <value>Name of the Browser</value>
        [DataMember(Name="BrowserName", EmitDefaultValue=false)]
        public string BrowserName { get; set; }

        /// <summary>
        /// Version of the Browser
        /// </summary>
        /// <value>Version of the Browser</value>
        [DataMember(Name="BrowserVersion", EmitDefaultValue=false)]
        public string BrowserVersion { get; set; }

        /// <summary>
        /// Name of the Browser Engine
        /// </summary>
        /// <value>Name of the Browser Engine</value>
        [DataMember(Name="BrowserEngineName", EmitDefaultValue=false)]
        public string BrowserEngineName { get; set; }

        /// <summary>
        /// Version of the Browser Engine
        /// </summary>
        /// <value>Version of the Browser Engine</value>
        [DataMember(Name="BrowserEngineVersion", EmitDefaultValue=false)]
        public string BrowserEngineVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserAgentValidateResponse {\n");
            sb.Append("  Successful: ").Append(Successful).Append("\n");
            sb.Append("  IsBot: ").Append(IsBot).Append("\n");
            sb.Append("  BotName: ").Append(BotName).Append("\n");
            sb.Append("  BotURL: ").Append(BotURL).Append("\n");
            sb.Append("  OperatingSystem: ").Append(OperatingSystem).Append("\n");
            sb.Append("  OperatingSystemCPUPlatform: ").Append(OperatingSystemCPUPlatform).Append("\n");
            sb.Append("  OperatingSystemVersion: ").Append(OperatingSystemVersion).Append("\n");
            sb.Append("  DeviceType: ").Append(DeviceType).Append("\n");
            sb.Append("  DeviceBrandName: ").Append(DeviceBrandName).Append("\n");
            sb.Append("  DeviceModel: ").Append(DeviceModel).Append("\n");
            sb.Append("  BrowserName: ").Append(BrowserName).Append("\n");
            sb.Append("  BrowserVersion: ").Append(BrowserVersion).Append("\n");
            sb.Append("  BrowserEngineName: ").Append(BrowserEngineName).Append("\n");
            sb.Append("  BrowserEngineVersion: ").Append(BrowserEngineVersion).Append("\n");
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
            return this.Equals(input as UserAgentValidateResponse);
        }

        /// <summary>
        /// Returns true if UserAgentValidateResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of UserAgentValidateResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserAgentValidateResponse input)
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
                    this.IsBot == input.IsBot ||
                    (this.IsBot != null &&
                    this.IsBot.Equals(input.IsBot))
                ) && 
                (
                    this.BotName == input.BotName ||
                    (this.BotName != null &&
                    this.BotName.Equals(input.BotName))
                ) && 
                (
                    this.BotURL == input.BotURL ||
                    (this.BotURL != null &&
                    this.BotURL.Equals(input.BotURL))
                ) && 
                (
                    this.OperatingSystem == input.OperatingSystem ||
                    (this.OperatingSystem != null &&
                    this.OperatingSystem.Equals(input.OperatingSystem))
                ) && 
                (
                    this.OperatingSystemCPUPlatform == input.OperatingSystemCPUPlatform ||
                    (this.OperatingSystemCPUPlatform != null &&
                    this.OperatingSystemCPUPlatform.Equals(input.OperatingSystemCPUPlatform))
                ) && 
                (
                    this.OperatingSystemVersion == input.OperatingSystemVersion ||
                    (this.OperatingSystemVersion != null &&
                    this.OperatingSystemVersion.Equals(input.OperatingSystemVersion))
                ) && 
                (
                    this.DeviceType == input.DeviceType ||
                    (this.DeviceType != null &&
                    this.DeviceType.Equals(input.DeviceType))
                ) && 
                (
                    this.DeviceBrandName == input.DeviceBrandName ||
                    (this.DeviceBrandName != null &&
                    this.DeviceBrandName.Equals(input.DeviceBrandName))
                ) && 
                (
                    this.DeviceModel == input.DeviceModel ||
                    (this.DeviceModel != null &&
                    this.DeviceModel.Equals(input.DeviceModel))
                ) && 
                (
                    this.BrowserName == input.BrowserName ||
                    (this.BrowserName != null &&
                    this.BrowserName.Equals(input.BrowserName))
                ) && 
                (
                    this.BrowserVersion == input.BrowserVersion ||
                    (this.BrowserVersion != null &&
                    this.BrowserVersion.Equals(input.BrowserVersion))
                ) && 
                (
                    this.BrowserEngineName == input.BrowserEngineName ||
                    (this.BrowserEngineName != null &&
                    this.BrowserEngineName.Equals(input.BrowserEngineName))
                ) && 
                (
                    this.BrowserEngineVersion == input.BrowserEngineVersion ||
                    (this.BrowserEngineVersion != null &&
                    this.BrowserEngineVersion.Equals(input.BrowserEngineVersion))
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
                if (this.IsBot != null)
                    hashCode = hashCode * 59 + this.IsBot.GetHashCode();
                if (this.BotName != null)
                    hashCode = hashCode * 59 + this.BotName.GetHashCode();
                if (this.BotURL != null)
                    hashCode = hashCode * 59 + this.BotURL.GetHashCode();
                if (this.OperatingSystem != null)
                    hashCode = hashCode * 59 + this.OperatingSystem.GetHashCode();
                if (this.OperatingSystemCPUPlatform != null)
                    hashCode = hashCode * 59 + this.OperatingSystemCPUPlatform.GetHashCode();
                if (this.OperatingSystemVersion != null)
                    hashCode = hashCode * 59 + this.OperatingSystemVersion.GetHashCode();
                if (this.DeviceType != null)
                    hashCode = hashCode * 59 + this.DeviceType.GetHashCode();
                if (this.DeviceBrandName != null)
                    hashCode = hashCode * 59 + this.DeviceBrandName.GetHashCode();
                if (this.DeviceModel != null)
                    hashCode = hashCode * 59 + this.DeviceModel.GetHashCode();
                if (this.BrowserName != null)
                    hashCode = hashCode * 59 + this.BrowserName.GetHashCode();
                if (this.BrowserVersion != null)
                    hashCode = hashCode * 59 + this.BrowserVersion.GetHashCode();
                if (this.BrowserEngineName != null)
                    hashCode = hashCode * 59 + this.BrowserEngineName.GetHashCode();
                if (this.BrowserEngineVersion != null)
                    hashCode = hashCode * 59 + this.BrowserEngineVersion.GetHashCode();
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