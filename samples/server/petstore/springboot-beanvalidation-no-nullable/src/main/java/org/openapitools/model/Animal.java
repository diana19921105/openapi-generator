package org.openapitools.model;

import java.net.URI;
import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonIgnoreProperties;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonCreator;
import com.fasterxml.jackson.annotation.JsonSubTypes;
import com.fasterxml.jackson.annotation.JsonTypeInfo;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.time.OffsetDateTime;
import javax.validation.Valid;
import javax.validation.constraints.*;


import java.util.*;
import javax.annotation.Generated;

/**
 * Animal
 */

@JsonTypeInfo(use = JsonTypeInfo.Id.NAME, include = JsonTypeInfo.As.PROPERTY, property = "className", visible = true)
@JsonSubTypes({
  @JsonSubTypes.Type(value = BigCat.class, name = "BigCat"),
  @JsonSubTypes.Type(value = Cat.class, name = "Cat"),
  @JsonSubTypes.Type(value = Dog.class, name = "Dog")
})

@Generated(value = "org.openapitools.codegen.languages.SpringCodegen", comments = "Generator version: 7.6.0-SNAPSHOT")
public class Animal {

  private String className;

  private String color = "red";

  public Animal() {
    super();
  }

  /**
   * Constructor with only required parameters
   */
  public Animal(String className) {
    this.className = className;
  }

  public Animal className(String className) {
    this.className = className;
    return this;
  }

  /**
   * Get className
   * @return className
  */
  @NotNull 
  @ApiModelProperty(required = true, value = "")
  @JsonProperty("className")
  public String getClassName() {
    return className;
  }

  public void setClassName(String className) {
    this.className = className;
  }

  public Animal color(String color) {
    this.color = color;
    return this;
  }

  /**
   * Get color
   * @return color
  */
  
  @ApiModelProperty(value = "")
  @JsonProperty("color")
  public String getColor() {
    return color;
  }

  public void setColor(String color) {
    this.color = color;
  }

  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    Animal animal = (Animal) o;
    return Objects.equals(this.className, animal.className) &&
        Objects.equals(this.color, animal.color);
  }

  @Override
  public int hashCode() {
    return Objects.hash(className, color);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class Animal {\n");
    sb.append("    className: ").append(toIndentedString(className)).append("\n");
    sb.append("    color: ").append(toIndentedString(color)).append("\n");
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

