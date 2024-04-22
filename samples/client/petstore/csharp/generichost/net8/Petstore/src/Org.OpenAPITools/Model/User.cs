// <auto-generated>
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
    /// User
    /// </summary>
    public partial class User : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        /// <param name="anyTypeProp">test code generation for any type Here the &#39;type&#39; attribute is not specified, which means the value can be anything, including the null value, string, number, boolean, array or object. See https://github.com/OAI/OpenAPI-Specification/issues/1389</param>
        /// <param name="anyTypePropNullable">test code generation for any type Here the &#39;type&#39; attribute is not specified, which means the value can be anything, including the null value, string, number, boolean, array or object. The &#39;nullable&#39; attribute does not change the allowed values.</param>
        /// <param name="email">email</param>
        /// <param name="firstName">firstName</param>
        /// <param name="id">id</param>
        /// <param name="lastName">lastName</param>
        /// <param name="objectWithNoDeclaredProps">test code generation for objects Value must be a map of strings to values. It cannot be the &#39;null&#39; value.</param>
        /// <param name="objectWithNoDeclaredPropsNullable">test code generation for nullable objects. Value must be a map of strings to values or the &#39;null&#39; value.</param>
        /// <param name="password">password</param>
        /// <param name="phone">phone</param>
        /// <param name="userStatus">User Status</param>
        /// <param name="username">username</param>
        [JsonConstructor]
        public User(Option<Object> anyTypeProp = default, Option<Object> anyTypePropNullable = default, Option<string> email = default, Option<string> firstName = default, Option<long?> id = default, Option<string> lastName = default, Option<Object> objectWithNoDeclaredProps = default, Option<Object> objectWithNoDeclaredPropsNullable = default, Option<string> password = default, Option<string> phone = default, Option<int?> userStatus = default, Option<string> username = default)
        {
            AnyTypePropOption = anyTypeProp;
            AnyTypePropNullableOption = anyTypePropNullable;
            EmailOption = email;
            FirstNameOption = firstName;
            IdOption = id;
            LastNameOption = lastName;
            ObjectWithNoDeclaredPropsOption = objectWithNoDeclaredProps;
            ObjectWithNoDeclaredPropsNullableOption = objectWithNoDeclaredPropsNullable;
            PasswordOption = password;
            PhoneOption = phone;
            UserStatusOption = userStatus;
            UsernameOption = username;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of AnyTypeProp
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Object> AnyTypePropOption { get; private set; }

        /// <summary>
        /// test code generation for any type Here the &#39;type&#39; attribute is not specified, which means the value can be anything, including the null value, string, number, boolean, array or object. See https://github.com/OAI/OpenAPI-Specification/issues/1389
        /// </summary>
        /// <value>test code generation for any type Here the &#39;type&#39; attribute is not specified, which means the value can be anything, including the null value, string, number, boolean, array or object. See https://github.com/OAI/OpenAPI-Specification/issues/1389</value>
        [JsonPropertyName("anyTypeProp")]
        public Object AnyTypeProp { get { return this.AnyTypePropOption; } set { this.AnyTypePropOption = new(value); } }

        /// <summary>
        /// Used to track the state of AnyTypePropNullable
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Object> AnyTypePropNullableOption { get; private set; }

        /// <summary>
        /// test code generation for any type Here the &#39;type&#39; attribute is not specified, which means the value can be anything, including the null value, string, number, boolean, array or object. The &#39;nullable&#39; attribute does not change the allowed values.
        /// </summary>
        /// <value>test code generation for any type Here the &#39;type&#39; attribute is not specified, which means the value can be anything, including the null value, string, number, boolean, array or object. The &#39;nullable&#39; attribute does not change the allowed values.</value>
        [JsonPropertyName("anyTypePropNullable")]
        public Object AnyTypePropNullable { get { return this.AnyTypePropNullableOption; } set { this.AnyTypePropNullableOption = new(value); } }

        /// <summary>
        /// Used to track the state of Email
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> EmailOption { get; private set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get { return this.EmailOption; } set { this.EmailOption = new(value); } }

        /// <summary>
        /// Used to track the state of FirstName
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> FirstNameOption { get; private set; }

        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [JsonPropertyName("firstName")]
        public string FirstName { get { return this.FirstNameOption; } set { this.FirstNameOption = new(value); } }

        /// <summary>
        /// Used to track the state of Id
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<long?> IdOption { get; private set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [JsonPropertyName("id")]
        public long? Id { get { return this.IdOption; } set { this.IdOption = new(value); } }

        /// <summary>
        /// Used to track the state of LastName
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> LastNameOption { get; private set; }

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [JsonPropertyName("lastName")]
        public string LastName { get { return this.LastNameOption; } set { this.LastNameOption = new(value); } }

        /// <summary>
        /// Used to track the state of ObjectWithNoDeclaredProps
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Object> ObjectWithNoDeclaredPropsOption { get; private set; }

        /// <summary>
        /// test code generation for objects Value must be a map of strings to values. It cannot be the &#39;null&#39; value.
        /// </summary>
        /// <value>test code generation for objects Value must be a map of strings to values. It cannot be the &#39;null&#39; value.</value>
        [JsonPropertyName("objectWithNoDeclaredProps")]
        public Object ObjectWithNoDeclaredProps { get { return this.ObjectWithNoDeclaredPropsOption; } set { this.ObjectWithNoDeclaredPropsOption = new(value); } }

        /// <summary>
        /// Used to track the state of ObjectWithNoDeclaredPropsNullable
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Object> ObjectWithNoDeclaredPropsNullableOption { get; private set; }

        /// <summary>
        /// test code generation for nullable objects. Value must be a map of strings to values or the &#39;null&#39; value.
        /// </summary>
        /// <value>test code generation for nullable objects. Value must be a map of strings to values or the &#39;null&#39; value.</value>
        [JsonPropertyName("objectWithNoDeclaredPropsNullable")]
        public Object ObjectWithNoDeclaredPropsNullable { get { return this.ObjectWithNoDeclaredPropsNullableOption; } set { this.ObjectWithNoDeclaredPropsNullableOption = new(value); } }

        /// <summary>
        /// Used to track the state of Password
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> PasswordOption { get; private set; }

        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [JsonPropertyName("password")]
        public string Password { get { return this.PasswordOption; } set { this.PasswordOption = new(value); } }

        /// <summary>
        /// Used to track the state of Phone
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> PhoneOption { get; private set; }

        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        [JsonPropertyName("phone")]
        public string Phone { get { return this.PhoneOption; } set { this.PhoneOption = new(value); } }

        /// <summary>
        /// Used to track the state of UserStatus
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> UserStatusOption { get; private set; }

        /// <summary>
        /// User Status
        /// </summary>
        /// <value>User Status</value>
        [JsonPropertyName("userStatus")]
        public int? UserStatus { get { return this.UserStatusOption; } set { this.UserStatusOption = new(value); } }

        /// <summary>
        /// Used to track the state of Username
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> UsernameOption { get; private set; }

        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [JsonPropertyName("username")]
        public string Username { get { return this.UsernameOption; } set { this.UsernameOption = new(value); } }

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
            sb.Append("class User {\n");
            sb.Append("  AnyTypeProp: ").Append(AnyTypeProp).Append("\n");
            sb.Append("  AnyTypePropNullable: ").Append(AnyTypePropNullable).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  ObjectWithNoDeclaredProps: ").Append(ObjectWithNoDeclaredProps).Append("\n");
            sb.Append("  ObjectWithNoDeclaredPropsNullable: ").Append(ObjectWithNoDeclaredPropsNullable).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  UserStatus: ").Append(UserStatus).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
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
    /// A Json converter for type <see cref="User" />
    /// </summary>
    public class UserJsonConverter : JsonConverter<User>
    {
        /// <summary>
        /// Deserializes json to <see cref="User" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override User Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<Object> anyTypeProp = default;
            Option<Object> anyTypePropNullable = default;
            Option<string> email = default;
            Option<string> firstName = default;
            Option<long?> id = default;
            Option<string> lastName = default;
            Option<Object> objectWithNoDeclaredProps = default;
            Option<Object> objectWithNoDeclaredPropsNullable = default;
            Option<string> password = default;
            Option<string> phone = default;
            Option<int?> userStatus = default;
            Option<string> username = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (localVarJsonPropertyName)
                    {
                        case "anyTypeProp":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                anyTypeProp = new Option<Object>(JsonSerializer.Deserialize<Object>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "anyTypePropNullable":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                anyTypePropNullable = new Option<Object>(JsonSerializer.Deserialize<Object>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "email":
                            email = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "firstName":
                            firstName = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "id":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                id = new Option<long?>(utf8JsonReader.GetInt64());
                            break;
                        case "lastName":
                            lastName = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "objectWithNoDeclaredProps":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                objectWithNoDeclaredProps = new Option<Object>(JsonSerializer.Deserialize<Object>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "objectWithNoDeclaredPropsNullable":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                objectWithNoDeclaredPropsNullable = new Option<Object>(JsonSerializer.Deserialize<Object>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "password":
                            password = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "phone":
                            phone = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "userStatus":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                userStatus = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "username":
                            username = new Option<string>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (email.IsSet && email.Value == null)
                throw new ArgumentNullException(nameof(email), "Property is not nullable for class User.");

            if (firstName.IsSet && firstName.Value == null)
                throw new ArgumentNullException(nameof(firstName), "Property is not nullable for class User.");

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class User.");

            if (lastName.IsSet && lastName.Value == null)
                throw new ArgumentNullException(nameof(lastName), "Property is not nullable for class User.");

            if (objectWithNoDeclaredProps.IsSet && objectWithNoDeclaredProps.Value == null)
                throw new ArgumentNullException(nameof(objectWithNoDeclaredProps), "Property is not nullable for class User.");

            if (password.IsSet && password.Value == null)
                throw new ArgumentNullException(nameof(password), "Property is not nullable for class User.");

            if (phone.IsSet && phone.Value == null)
                throw new ArgumentNullException(nameof(phone), "Property is not nullable for class User.");

            if (userStatus.IsSet && userStatus.Value == null)
                throw new ArgumentNullException(nameof(userStatus), "Property is not nullable for class User.");

            if (username.IsSet && username.Value == null)
                throw new ArgumentNullException(nameof(username), "Property is not nullable for class User.");

            return new User(anyTypeProp, anyTypePropNullable, email, firstName, id, lastName, objectWithNoDeclaredProps, objectWithNoDeclaredPropsNullable, password, phone, userStatus, username);
        }

        /// <summary>
        /// Serializes a <see cref="User" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="user"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, User user, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, user, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="User" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="user"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, User user, JsonSerializerOptions jsonSerializerOptions)
        {
            if (user.EmailOption.IsSet && user.Email == null)
                throw new ArgumentNullException(nameof(user.Email), "Property is required for class User.");

            if (user.FirstNameOption.IsSet && user.FirstName == null)
                throw new ArgumentNullException(nameof(user.FirstName), "Property is required for class User.");

            if (user.LastNameOption.IsSet && user.LastName == null)
                throw new ArgumentNullException(nameof(user.LastName), "Property is required for class User.");

            if (user.ObjectWithNoDeclaredPropsOption.IsSet && user.ObjectWithNoDeclaredProps == null)
                throw new ArgumentNullException(nameof(user.ObjectWithNoDeclaredProps), "Property is required for class User.");

            if (user.PasswordOption.IsSet && user.Password == null)
                throw new ArgumentNullException(nameof(user.Password), "Property is required for class User.");

            if (user.PhoneOption.IsSet && user.Phone == null)
                throw new ArgumentNullException(nameof(user.Phone), "Property is required for class User.");

            if (user.UsernameOption.IsSet && user.Username == null)
                throw new ArgumentNullException(nameof(user.Username), "Property is required for class User.");

            if (user.AnyTypePropOption.IsSet)
                if (user.AnyTypePropOption.Value != null)
                {
                    writer.WritePropertyName("anyTypeProp");
                    JsonSerializer.Serialize(writer, user.AnyTypeProp, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("anyTypeProp");
            if (user.AnyTypePropNullableOption.IsSet)
                if (user.AnyTypePropNullableOption.Value != null)
                {
                    writer.WritePropertyName("anyTypePropNullable");
                    JsonSerializer.Serialize(writer, user.AnyTypePropNullable, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("anyTypePropNullable");
            if (user.EmailOption.IsSet)
                writer.WriteString("email", user.Email);

            if (user.FirstNameOption.IsSet)
                writer.WriteString("firstName", user.FirstName);

            if (user.IdOption.IsSet)
                writer.WriteNumber("id", user.IdOption.Value.Value);

            if (user.LastNameOption.IsSet)
                writer.WriteString("lastName", user.LastName);

            if (user.ObjectWithNoDeclaredPropsOption.IsSet)
            {
                writer.WritePropertyName("objectWithNoDeclaredProps");
                JsonSerializer.Serialize(writer, user.ObjectWithNoDeclaredProps, jsonSerializerOptions);
            }
            if (user.ObjectWithNoDeclaredPropsNullableOption.IsSet)
                if (user.ObjectWithNoDeclaredPropsNullableOption.Value != null)
                {
                    writer.WritePropertyName("objectWithNoDeclaredPropsNullable");
                    JsonSerializer.Serialize(writer, user.ObjectWithNoDeclaredPropsNullable, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("objectWithNoDeclaredPropsNullable");
            if (user.PasswordOption.IsSet)
                writer.WriteString("password", user.Password);

            if (user.PhoneOption.IsSet)
                writer.WriteString("phone", user.Phone);

            if (user.UserStatusOption.IsSet)
                writer.WriteNumber("userStatus", user.UserStatusOption.Value.Value);

            if (user.UsernameOption.IsSet)
                writer.WriteString("username", user.Username);
        }
    }
}
