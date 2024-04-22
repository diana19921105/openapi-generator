// <auto-generated>
/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using OpenAPIClientUtils = Org.OpenAPITools.Client.ClientUtils;
using Org.OpenAPITools.Client;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// PolymorphicProperty
    /// </summary>
    public partial class PolymorphicProperty : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PolymorphicProperty" /> class.
        /// </summary>
        /// <param name="bool"></param>
        internal PolymorphicProperty(bool @bool)
        {
            Bool = @bool;
            OnCreated();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PolymorphicProperty" /> class.
        /// </summary>
        /// <param name="string"></param>
        internal PolymorphicProperty(string @string)
        {
            String = @string;
            OnCreated();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PolymorphicProperty" /> class.
        /// </summary>
        /// <param name="object"></param>
        internal PolymorphicProperty(Object @object)
        {
            Object = @object;
            OnCreated();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PolymorphicProperty" /> class.
        /// </summary>
        /// <param name="list"></param>
        internal PolymorphicProperty(List<string> list)
        {
            List = list;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Bool
        /// </summary>
        public bool? Bool { get; set; }

        /// <summary>
        /// Gets or Sets String
        /// </summary>
        public string? String { get; set; }

        /// <summary>
        /// Gets or Sets Object
        /// </summary>
        public Object? Object { get; set; }

        /// <summary>
        /// Gets or Sets List
        /// </summary>
        public List<string>? List { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public Dictionary<string, JsonElement> AdditionalProperties { get; } = new Dictionary<string, JsonElement>();

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PolymorphicProperty {\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
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
    /// A Json converter for type <see cref="PolymorphicProperty" />
    /// </summary>
    public class PolymorphicPropertyJsonConverter : JsonConverter<PolymorphicProperty>
    {
        /// <summary>
        /// Deserializes json to <see cref="PolymorphicProperty" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override PolymorphicProperty Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            bool? varBool = default;
            string? varString = default;
            Object? varObject = default;
            List<string>? list = default;

            Utf8JsonReader utf8JsonReaderOneOf = utf8JsonReader;
            while (utf8JsonReaderOneOf.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReaderOneOf.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReaderOneOf.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReaderOneOf.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReaderOneOf.CurrentDepth)
                    break;

                if (utf8JsonReaderOneOf.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReaderOneOf.CurrentDepth - 1)
                {
                    Utf8JsonReader utf8JsonReaderBool = utf8JsonReader;
                    ClientUtils.TryDeserialize<bool?>(ref utf8JsonReaderBool, jsonSerializerOptions, out varBool);

                    Utf8JsonReader utf8JsonReaderString = utf8JsonReader;
                    ClientUtils.TryDeserialize<string?>(ref utf8JsonReaderString, jsonSerializerOptions, out varString);

                    Utf8JsonReader utf8JsonReaderObject = utf8JsonReader;
                    ClientUtils.TryDeserialize<Object?>(ref utf8JsonReaderObject, jsonSerializerOptions, out varObject);

                    Utf8JsonReader utf8JsonReaderList = utf8JsonReader;
                    ClientUtils.TryDeserialize<List<string>?>(ref utf8JsonReaderList, jsonSerializerOptions, out list);
                }
            }

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string? localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (localVarJsonPropertyName)
                    {
                        default:
                            break;
                    }
                }
            }

            if (varBool != null)
                return new PolymorphicProperty(varBool.Value);

            if (varString != null)
                return new PolymorphicProperty(varString);

            if (varObject != null)
                return new PolymorphicProperty(varObject);

            if (list != null)
                return new PolymorphicProperty(list);

            throw new JsonException();
        }

        /// <summary>
        /// Serializes a <see cref="PolymorphicProperty" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="polymorphicProperty"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, PolymorphicProperty polymorphicProperty, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, polymorphicProperty, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="PolymorphicProperty" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="polymorphicProperty"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, PolymorphicProperty polymorphicProperty, JsonSerializerOptions jsonSerializerOptions)
        {

        }
    }
}
