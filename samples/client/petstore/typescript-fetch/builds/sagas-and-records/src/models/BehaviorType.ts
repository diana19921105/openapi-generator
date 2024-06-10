/* tslint:disable */
/* eslint-disable */
/**
 * OpenAPI Petstore
 * This is a sample server Petstore server. For this sample, you can use the api key `special-key` to test the authorization filters.
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


/**
 * Behavior type of a pet
 * @export
 */
export const BehaviorType = {
    Voluntary: 'Voluntary',
    Involuntary: 'Involuntary',
    Overt: 'Overt'
} as const;
export type BehaviorType = typeof BehaviorType[keyof typeof BehaviorType];


export function instanceOfBehaviorType(value: any): boolean {
    for (const key in BehaviorType) {
        if (Object.prototype.hasOwnProperty.call(BehaviorType, key)) {
            if ((BehaviorType as Record<string, BehaviorType>)[key] === value) {
                return true;
            }
        }
    }
    return false;
}

export function BehaviorTypeFromJSON(json: any): BehaviorType {
    return BehaviorTypeFromJSONTyped(json, false);
}

export function BehaviorTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): BehaviorType {
    return json as BehaviorType;
}

export function BehaviorTypeToJSON(value?: BehaviorType | null): any {
    return value as any;
}

