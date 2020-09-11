/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;
using OpenAPIClientUtils = Org.OpenAPITools.Client.ClientUtils;
using Newtonsoft.Json.Linq;
using System.Reflection;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// ApiResponse
    /// </summary>
    [DataContract(Name = "ApiResponse")]
    [JsonConverter(typeof(ApiResponseConverter))]
    public partial class ApiResponse : IEquatable<ApiResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponse" /> class.
        /// </summary>
        /// <param name="code">code.</param>
        /// <param name="type">type.</param>
        /// <param name="message">message.</param>
        public ApiResponse(int code = default(int), string type = default(string), string message = default(string))
        {
            this.Code = code;
            this.Type = type;
            this.Message = message;
            this.AdditionalProperites = new Dictionary<string, dynamic>();
        }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public int Code { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalProperties
        /// </summary>
        [DataMember(Name = "AdditionalProperites", EmitDefaultValue = false)]
        public Dictionary<string, dynamic> AdditionalProperites { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiResponse {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            return OpenAPIClientUtils.compareLogic.Compare(this, input as ApiResponse).AreEqual;
        }

        /// <summary>
        /// Returns true if ApiResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponse input)
        {
            return OpenAPIClientUtils.compareLogic.Compare(this, input).AreEqual;
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
                hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
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

    /// <summary>
    /// Converter for additional properties
    /// </summary>
    public class ApiResponseConverter: JsonConverter
    {
        private readonly Type[] _types;

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseConverter" /> class.
        /// </summary>
        /// <param name="types">Types.</param>
        public ApiResponseConverter(params Type[] types)
        {
            _types = types;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseConverter" /> class.
        /// </summary>
        public ApiResponseConverter()
        {
        }

        /// <summary>
        /// Function to the write JSON string
        /// </summary>
        /// <param name="writer">Json Writer</param>
        /// <param name="value">Object</param>
        /// <param name="serializer">Json Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            JObject jo = new JObject();
            Type type = value.GetType();

            foreach (PropertyInfo property in type.GetProperties())
            {
                if (property.CanRead)
                {
                    object propertyValue = property.GetValue(value, null);
                    foreach (DataMemberAttribute attribute in property.GetCustomAttributes(typeof(DataMemberAttribute), true))
                    {
                        if (propertyValue != null)
                        {
                            // flatten the dictionary if it's "AdditionalProperites"
                            if (attribute.Name == "AdditionalProperites")
                            {
                                foreach (var item in (Dictionary<string, dynamic>)propertyValue)
                                {
                                    jo.Add(item.Key, JToken.FromObject(item.Value, serializer));
                                }
                            }
                            else
                            {
                                jo.Add(attribute.Name, JToken.FromObject(propertyValue, serializer));
                            }
                        }
                    }
                }
            }
            jo.WriteTo(writer);
        }
    
        /// <summary>
        /// Function to convert JSON string into ApiResponse 
        /// </summary>
        /// <param name="reader">Json Reader</param>
        /// <param name="objectType">Object type</param>
        /// <param name="existingValue">Input be serialized</param>
        /// <param name="serializer">Json Serializer</param>
        /// <returns>An instance of ApiResponse serialized from the JSON string</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            //var result = base.ReadJson(reader, objectType, existingValue, serializer)
            return null;
        }

        /// <summary>
        /// A boolean property named CanRead
        /// </summary>
        public override bool CanRead
        {
            get { return false; }
        }

        /// <summary>
        /// Returns true if the input can be converted
        /// </summary>
        /// <returns>Boolean</returns>
        public override bool CanConvert(Type objectType)
        {
            return _types.Any(t => t == objectType);
        }
    }


}
