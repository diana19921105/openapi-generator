package org.openapitools.model;

import java.net.URI;
import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonIgnoreProperties;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonCreator;
import com.fasterxml.jackson.annotation.JsonSubTypes;
import com.fasterxml.jackson.annotation.JsonTypeInfo;
import com.fasterxml.jackson.annotation.JsonValue;
import java.util.Arrays;
import org.openapitools.jackson.nullable.JsonNullable;
import java.util.NoSuchElementException;
import org.openapitools.jackson.nullable.JsonNullable;
import java.time.OffsetDateTime;
import jakarta.validation.constraints.NotNull;


import java.util.*;
import jakarta.annotation.Generated;

/**
 * ParentWithNullable
 */

@JsonTypeInfo(use = JsonTypeInfo.Id.NAME, include = JsonTypeInfo.As.PROPERTY, property = "type", visible = true)
@JsonSubTypes({
  @JsonSubTypes.Type(value = ChildWithNullable.class, name = "ChildWithNullable")
})

@Generated(value = "org.openapitools.codegen.languages.SpringCodegen", comments = "Generator version: 7.7.0-SNAPSHOT")
public class ParentWithNullable {

  /**
   * Gets or Sets type
   */
  public enum TypeEnum {
    CHILD_WITH_NULLABLE("ChildWithNullable");

    private String value;

    TypeEnum(String value) {
      this.value = value;
    }

    @JsonValue
    public String getValue() {
      return value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }

    @JsonCreator
    public static TypeEnum fromValue(String value) {
      for (TypeEnum b : TypeEnum.values()) {
        if (b.value.equals(value)) {
          return b;
        }
      }
      throw new IllegalArgumentException("Unexpected value '" + value + "'");
    }
  }

  private TypeEnum type;

  private JsonNullable<String> nullableProperty = JsonNullable.<String>undefined();

  public ParentWithNullable type(TypeEnum type) {
    this.type = type;
    return this;
  }

  /**
   * Get type
   * @return type
  */
  
  @JsonProperty("type")
  public TypeEnum getType() {
    return type;
  }

  public void setType(TypeEnum type) {
    this.type = type;
  }

  public ParentWithNullable nullableProperty(String nullableProperty) {
    this.nullableProperty = JsonNullable.of(nullableProperty);
    return this;
  }

  /**
   * Get nullableProperty
   * @return nullableProperty
  */
  
  @JsonProperty("nullableProperty")
  public JsonNullable<String> getNullableProperty() {
    return nullableProperty;
  }

  public void setNullableProperty(JsonNullable<String> nullableProperty) {
    this.nullableProperty = nullableProperty;
  }

  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ParentWithNullable parentWithNullable = (ParentWithNullable) o;
    return Objects.equals(this.type, parentWithNullable.type) &&
        equalsNullable(this.nullableProperty, parentWithNullable.nullableProperty);
  }

  private static <T> boolean equalsNullable(JsonNullable<T> a, JsonNullable<T> b) {
    return a == b || (a != null && b != null && a.isPresent() && b.isPresent() && Objects.deepEquals(a.get(), b.get()));
  }

  @Override
  public int hashCode() {
    return Objects.hash(type, hashCodeNullable(nullableProperty));
  }

  private static <T> int hashCodeNullable(JsonNullable<T> a) {
    if (a == null) {
      return 1;
    }
    return a.isPresent() ? Arrays.deepHashCode(new Object[]{a.get()}) : 31;
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ParentWithNullable {\n");
    sb.append("    type: ").append(toIndentedString(type)).append("\n");
    sb.append("    nullableProperty: ").append(toIndentedString(nullableProperty)).append("\n");
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
}

