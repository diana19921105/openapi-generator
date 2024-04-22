# coding: utf-8

"""
    OpenAPI Petstore

    This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\

    The version of the OpenAPI document: 1.0.0
    Generated by OpenAPI Generator (https://openapi-generator.tech)

    Do not edit the class manually.
"""  # noqa: E501


from __future__ import annotations
from inspect import getfullargspec
import json
import pprint
import re  # noqa: F401

from typing import List, Optional
from pydantic import BaseModel, Field, StrictStr, ValidationError, conint, conlist, constr, validator
from typing import Union, Any, List, TYPE_CHECKING
from pydantic import StrictStr, Field

ANYOFCOLOR_ANY_OF_SCHEMAS = ["List[int]", "str"]

class AnyOfColor(BaseModel):
    """
    Any of RGB array, RGBA array, or hex string.
    """

    # data type: List[int]
    anyof_schema_1_validator: Optional[conlist(conint(strict=True, le=255, ge=0), max_items=3, min_items=3)] = Field(default=None, description="RGB three element array with values 0-255.")
    # data type: List[int]
    anyof_schema_2_validator: Optional[conlist(conint(strict=True, le=255, ge=0), max_items=4, min_items=4)] = Field(default=None, description="RGBA four element array with values 0-255.")
    # data type: str
    anyof_schema_3_validator: Optional[constr(strict=True, max_length=7, min_length=7)] = Field(default=None, description="Hex color string, such as #00FF00.")
    if TYPE_CHECKING:
        actual_instance: Union[List[int], str]
    else:
        actual_instance: Any
    any_of_schemas: List[str] = Field(ANYOFCOLOR_ANY_OF_SCHEMAS, const=True)

    class Config:
        validate_assignment = True

    def __init__(self, *args, **kwargs) -> None:
        if args:
            if len(args) > 1:
                raise ValueError("If a position argument is used, only 1 is allowed to set `actual_instance`")
            if kwargs:
                raise ValueError("If a position argument is used, keyword arguments cannot be used.")
            super().__init__(actual_instance=args[0])
        else:
            super().__init__(**kwargs)

    @validator('actual_instance')
    def actual_instance_must_validate_anyof(cls, v):
        instance = AnyOfColor.construct()
        error_messages = []
        # validate data type: List[int]
        try:
            instance.anyof_schema_1_validator = v
            return v
        except (ValidationError, ValueError) as e:
            error_messages.append(str(e))
        # validate data type: List[int]
        try:
            instance.anyof_schema_2_validator = v
            return v
        except (ValidationError, ValueError) as e:
            error_messages.append(str(e))
        # validate data type: str
        try:
            instance.anyof_schema_3_validator = v
            return v
        except (ValidationError, ValueError) as e:
            error_messages.append(str(e))
        if error_messages:
            # no match
            raise ValueError("No match found when setting the actual_instance in AnyOfColor with anyOf schemas: List[int], str. Details: " + ", ".join(error_messages))
        else:
            return v

    @classmethod
    def from_dict(cls, obj: dict) -> AnyOfColor:
        return cls.from_json(json.dumps(obj))

    @classmethod
    def from_json(cls, json_str: str) -> AnyOfColor:
        """Returns the object represented by the json string"""
        instance = AnyOfColor.construct()
        error_messages = []
        # deserialize data into List[int]
        try:
            # validation
            instance.anyof_schema_1_validator = json.loads(json_str)
            # assign value to actual_instance
            instance.actual_instance = instance.anyof_schema_1_validator
            return instance
        except (ValidationError, ValueError) as e:
            error_messages.append(str(e))
        # deserialize data into List[int]
        try:
            # validation
            instance.anyof_schema_2_validator = json.loads(json_str)
            # assign value to actual_instance
            instance.actual_instance = instance.anyof_schema_2_validator
            return instance
        except (ValidationError, ValueError) as e:
            error_messages.append(str(e))
        # deserialize data into str
        try:
            # validation
            instance.anyof_schema_3_validator = json.loads(json_str)
            # assign value to actual_instance
            instance.actual_instance = instance.anyof_schema_3_validator
            return instance
        except (ValidationError, ValueError) as e:
            error_messages.append(str(e))

        if error_messages:
            # no match
            raise ValueError("No match found when deserializing the JSON string into AnyOfColor with anyOf schemas: List[int], str. Details: " + ", ".join(error_messages))
        else:
            return instance

    def to_json(self) -> str:
        """Returns the JSON representation of the actual instance"""
        if self.actual_instance is None:
            return "null"

        to_json = getattr(self.actual_instance, "to_json", None)
        if callable(to_json):
            return self.actual_instance.to_json()
        else:
            return json.dumps(self.actual_instance)

    def to_dict(self) -> dict:
        """Returns the dict representation of the actual instance"""
        if self.actual_instance is None:
            return "null"

        to_json = getattr(self.actual_instance, "to_json", None)
        if callable(to_json):
            return self.actual_instance.to_dict()
        else:
            return json.dumps(self.actual_instance)

    def to_str(self) -> str:
        """Returns the string representation of the actual instance"""
        return pprint.pformat(self.dict())


