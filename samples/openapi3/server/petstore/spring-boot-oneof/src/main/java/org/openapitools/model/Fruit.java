package org.openapitools.model;

import java.net.URI;
import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonIgnoreProperties;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonCreator;
import com.fasterxml.jackson.annotation.JsonSubTypes;
import com.fasterxml.jackson.annotation.JsonTypeInfo;
import com.fasterxml.jackson.annotation.JsonValue;
import org.openapitools.model.Apple;
import org.openapitools.model.Banana;
import org.openapitools.model.FruitType;
import org.openapitools.jackson.nullable.JsonNullable;
import java.time.OffsetDateTime;
import javax.validation.Valid;
import javax.validation.constraints.*;
import io.swagger.v3.oas.annotations.media.Schema;


import java.util.*;
import javax.annotation.Generated;


@JsonTypeInfo(use = JsonTypeInfo.Id.NAME, include = JsonTypeInfo.As.PROPERTY, property = "fruitType", visible = true)
@JsonSubTypes({
  @JsonSubTypes.Type(value = Apple.class, name = "APPLE"),
  @JsonSubTypes.Type(value = Banana.class, name = "BANANA"),
  @JsonSubTypes.Type(value = Apple.class, name = "Apple"),
  @JsonSubTypes.Type(value = Banana.class, name = "Banana")
})

@Generated(value = "org.openapitools.codegen.languages.SpringCodegen")
public interface Fruit {
    public FruitType getFruitType();
}
