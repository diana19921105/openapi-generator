/*
 * OpenAPI Petstore
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


package org.openapitools.client.model;

import java.net.URLEncoder;
import java.nio.charset.StandardCharsets;
import java.util.StringJoiner;
import java.util.Objects;
import java.util.Map;
import java.util.HashMap;
import com.fasterxml.jackson.annotation.JsonIgnoreProperties;
import com.fasterxml.jackson.annotation.JsonInclude;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonCreator;
import com.fasterxml.jackson.annotation.JsonSubTypes;
import com.fasterxml.jackson.annotation.JsonTypeInfo;
import com.fasterxml.jackson.annotation.JsonTypeName;
import com.fasterxml.jackson.annotation.JsonValue;
import java.util.Arrays;
import com.fasterxml.jackson.annotation.JsonPropertyOrder;


import org.openapitools.client.JSON;
import org.openapitools.client.ApiClient;
/**
 * GrandparentAnimal
 */
@JsonPropertyOrder({
  GrandparentAnimal.JSON_PROPERTY_PET_TYPE
})
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", comments = "Generator version: 7.7.0-SNAPSHOT")
    @JsonTypeInfo(use = JsonTypeInfo.Id.NAME, include = JsonTypeInfo.As.PROPERTY, property = "pet_type", visible = true)
        @JsonSubTypes({
      @JsonSubTypes.Type(value = ChildCat.class, name = "ChildCat"),
      @JsonSubTypes.Type(value = ParentPet.class, name = "ParentPet"),
        })


public class GrandparentAnimal {
  public static final String JSON_PROPERTY_PET_TYPE = "pet_type";
  private String petType;

  public GrandparentAnimal() { 
  }

  public GrandparentAnimal petType(String petType) {
    this.petType = petType;
    return this;
  }

   /**
   * Get petType
   * @return petType
  **/
  @javax.annotation.Nonnull
  @JsonProperty(JSON_PROPERTY_PET_TYPE)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)

  public String getPetType() {
    return petType;
  }


  @JsonProperty(JSON_PROPERTY_PET_TYPE)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)
  public void setPetType(String petType) {
    this.petType = petType;
  }


  /**
   * Return true if this GrandparentAnimal object is equal to o.
   */
  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    GrandparentAnimal grandparentAnimal = (GrandparentAnimal) o;
    return Objects.equals(this.petType, grandparentAnimal.petType);
  }

  @Override
  public int hashCode() {
    return Objects.hash(petType);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class GrandparentAnimal {\n");
    sb.append("    petType: ").append(toIndentedString(petType)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }

  /**
   * Convert the instance into URL query string.
   *
   * @return URL query string
   */
  public String toUrlQueryString() {
    return toUrlQueryString(null);
  }

  /**
   * Convert the instance into URL query string.
   *
   * @param prefix prefix of the query string
   * @return URL query string
   */
  public String toUrlQueryString(String prefix) {
    String suffix = "";
    String containerSuffix = "";
    String containerPrefix = "";
    if (prefix == null) {
      // style=form, explode=true, e.g. /pet?name=cat&type=manx
      prefix = "";
    } else {
      // deepObject style e.g. /pet?id[name]=cat&id[type]=manx
      prefix = prefix + "[";
      suffix = "]";
      containerSuffix = "]";
      containerPrefix = "[";
    }

    StringJoiner joiner = new StringJoiner("&");

    // add `pet_type` to the URL query string
    if (getPetType() != null) {
      joiner.add(String.format("%spet_type%s=%s", prefix, suffix, URLEncoder.encode(ApiClient.valueToString(getPetType()), StandardCharsets.UTF_8).replaceAll("\\+", "%20")));
    }

    return joiner.toString();
  }
static {
  // Initialize and register the discriminator mappings.
  Map<String, Class<?>> mappings = new HashMap<String, Class<?>>();
  mappings.put("ChildCat", ChildCat.class);
  mappings.put("ParentPet", ParentPet.class);
  mappings.put("GrandparentAnimal", GrandparentAnimal.class);
  JSON.registerDiscriminator(GrandparentAnimal.class, "pet_type", mappings);
}

    public static class Builder {

    private GrandparentAnimal instance;

    public Builder() {
      this(new GrandparentAnimal());
    }

    protected Builder(GrandparentAnimal instance) {
      this.instance = instance;
    }

    public GrandparentAnimal.Builder petType(String petType) {
      this.instance.petType = petType;
      return this;
    }


    /**
    * returns a built GrandparentAnimal instance.
    *
    * The builder is not reusable.
    */
    public GrandparentAnimal build() {
      try {
        return this.instance;
      } finally {
        // ensure that this.instance is not reused
        this.instance = null;
      }
    }

    @Override
    public String toString() {
      return getClass() + "=(" + instance + ")";
    }
  }

  /**
  * Create a builder with no initialized field.
  */
  public static GrandparentAnimal.Builder builder() {
    return new GrandparentAnimal.Builder();
  }

  /**
  * Create a builder with a shallow copy of this instance.
  */
  public GrandparentAnimal.Builder toBuilder() {
    return new GrandparentAnimal.Builder()
      .petType(getPetType());
  }

}

