package org.openapitools.model;

import java.net.URI;
import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonIgnoreProperties;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonCreator;
import com.fasterxml.jackson.annotation.JsonSubTypes;
import com.fasterxml.jackson.annotation.JsonTypeInfo;
import java.math.BigDecimal;
import org.openapitools.model.Entity;
import org.openapitools.jackson.nullable.JsonNullable;
import java.time.OffsetDateTime;
import javax.validation.Valid;
import javax.validation.constraints.*;
import io.swagger.v3.oas.annotations.media.Schema;


import java.util.*;
import javax.annotation.Generated;

/**
 * Pizza
 */

@JsonTypeInfo(use = JsonTypeInfo.Id.NAME, include = JsonTypeInfo.As.PROPERTY, property = "@type", visible = true)
@JsonSubTypes({
  @JsonSubTypes.Type(value = PizzaSpeziale.class, name = "PizzaSpeziale")
})

@Generated(value = "org.openapitools.codegen.languages.SpringCodegen")
public class Pizza extends Entity {

  private BigDecimal pizzaSize;

  public Pizza() {
    super();
  }

  /**
   * Constructor with only required parameters
   */
  public Pizza(String atType) {
    super(atType);
  }

  public Pizza pizzaSize(BigDecimal pizzaSize) {
    this.pizzaSize = pizzaSize;
    return this;
  }

  /**
   * Get pizzaSize
   * @return pizzaSize
  */
  @Valid 
  @Schema(name = "pizzaSize", requiredMode = Schema.RequiredMode.NOT_REQUIRED)
  @JsonProperty("pizzaSize")
  public BigDecimal getPizzaSize() {
    return pizzaSize;
  }

  public void setPizzaSize(BigDecimal pizzaSize) {
    this.pizzaSize = pizzaSize;
  }


  public Pizza href(String href) {
    super.href(href);
    return this;
  }

  public Pizza id(String id) {
    super.id(id);
    return this;
  }

  public Pizza atSchemaLocation(String atSchemaLocation) {
    super.atSchemaLocation(atSchemaLocation);
    return this;
  }

  public Pizza atBaseType(String atBaseType) {
    super.atBaseType(atBaseType);
    return this;
  }

  public Pizza atType(String atType) {
    super.atType(atType);
    return this;
  }
  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    Pizza pizza = (Pizza) o;
    return Objects.equals(this.pizzaSize, pizza.pizzaSize) &&
        super.equals(o);
  }

  @Override
  public int hashCode() {
    return Objects.hash(pizzaSize, super.hashCode());
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class Pizza {\n");
    sb.append("    ").append(toIndentedString(super.toString())).append("\n");
    sb.append("    pizzaSize: ").append(toIndentedString(pizzaSize)).append("\n");
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

