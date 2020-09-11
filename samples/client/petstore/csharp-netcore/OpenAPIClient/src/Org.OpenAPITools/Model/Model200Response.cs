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
    /// Model for testing model name starting with number
    /// </summary>
    [DataContract(Name = "200_response")]
    [JsonConverter(typeof(Model200ResponseConverter))]
    public partial class Model200Response : IEquatable<Model200Response>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Model200Response" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="_class">_class.</param>
        public Model200Response(int name = default(int), string _class = default(string))
        {
            this.Name = name;
            this.Class = _class;
            this.AdditionalProperites = new Dictionary<string, dynamic>();
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public int Name { get; set; }

        /// <summary>
        /// Gets or Sets Class
        /// </summary>
        [DataMember(Name = "class", EmitDefaultValue = false)]
        public string Class { get; set; }

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
            sb.Append("class Model200Response {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Class: ").Append(Class).Append("\n");
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
            return OpenAPIClientUtils.compareLogic.Compare(this, input as Model200Response).AreEqual;
        }

        /// <summary>
        /// Returns true if Model200Response instances are equal
        /// </summary>
        /// <param name="input">Instance of Model200Response to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Model200Response input)
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
                hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Class != null)
                    hashCode = hashCode * 59 + this.Class.GetHashCode();
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
    public class Model200ResponseConverter: JsonConverter
    {
        private readonly Type[] _types;

        /// <summary>
        /// Initializes a new instance of the <see cref="Model200ResponseConverter" /> class.
        /// </summary>
        /// <param name="types">Types.</param>
        public Model200ResponseConverter(params Type[] types)
        {
            _types = types;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Model200ResponseConverter" /> class.
        /// </summary>
        public Model200ResponseConverter()
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
        /// Function to convert JSON string into Model200Response 
        /// </summary>
        /// <param name="reader">Json Reader</param>
        /// <param name="objectType">Object type</param>
        /// <param name="existingValue">Input be serialized</param>
        /// <param name="serializer">Json Serializer</param>
        /// <returns>An instance of Model200Response serialized from the JSON string</returns>
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
