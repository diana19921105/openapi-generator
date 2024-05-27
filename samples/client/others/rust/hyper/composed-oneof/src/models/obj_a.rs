/*
 * oneOf test
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 * Generated by: https://openapi-generator.tech
 */

use crate::models;
use serde::{Deserialize, Serialize};

#[derive(Clone, Default, Debug, PartialEq, Serialize, Deserialize)]
pub struct ObjA {
    #[serde(rename = "realtype", skip_serializing_if = "Option::is_none")]
    pub realtype: Option<String>,
    #[serde(rename = "message", skip_serializing_if = "Option::is_none")]
    pub message: Option<String>,
}

impl ObjA {
    pub fn new() -> ObjA {
        ObjA {
            realtype: None,
            message: None,
        }
    }
}

