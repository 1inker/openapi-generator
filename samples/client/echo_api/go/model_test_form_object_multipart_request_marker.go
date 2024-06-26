/*
Echo Server API

Echo Server API

API version: 0.1.0
Contact: team@openapitools.org
*/

// Code generated by OpenAPI Generator (https://openapi-generator.tech); DO NOT EDIT.

package openapi

import (
	"encoding/json"
)

// checks if the TestFormObjectMultipartRequestMarker type satisfies the MappedNullable interface at compile time
var _ MappedNullable = &TestFormObjectMultipartRequestMarker{}

// TestFormObjectMultipartRequestMarker struct for TestFormObjectMultipartRequestMarker
type TestFormObjectMultipartRequestMarker struct {
	Name *string `json:"name,omitempty"`
}

// NewTestFormObjectMultipartRequestMarker instantiates a new TestFormObjectMultipartRequestMarker object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewTestFormObjectMultipartRequestMarker() *TestFormObjectMultipartRequestMarker {
	this := TestFormObjectMultipartRequestMarker{}
	return &this
}

// NewTestFormObjectMultipartRequestMarkerWithDefaults instantiates a new TestFormObjectMultipartRequestMarker object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewTestFormObjectMultipartRequestMarkerWithDefaults() *TestFormObjectMultipartRequestMarker {
	this := TestFormObjectMultipartRequestMarker{}
	return &this
}

// GetName returns the Name field value if set, zero value otherwise.
func (o *TestFormObjectMultipartRequestMarker) GetName() string {
	if o == nil || IsNil(o.Name) {
		var ret string
		return ret
	}
	return *o.Name
}

// GetNameOk returns a tuple with the Name field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *TestFormObjectMultipartRequestMarker) GetNameOk() (*string, bool) {
	if o == nil || IsNil(o.Name) {
		return nil, false
	}
	return o.Name, true
}

// HasName returns a boolean if a field has been set.
func (o *TestFormObjectMultipartRequestMarker) HasName() bool {
	if o != nil && !IsNil(o.Name) {
		return true
	}

	return false
}

// SetName gets a reference to the given string and assigns it to the Name field.
func (o *TestFormObjectMultipartRequestMarker) SetName(v string) {
	o.Name = &v
}

func (o TestFormObjectMultipartRequestMarker) MarshalJSON() ([]byte, error) {
	toSerialize,err := o.ToMap()
	if err != nil {
		return []byte{}, err
	}
	return json.Marshal(toSerialize)
}

func (o TestFormObjectMultipartRequestMarker) ToMap() (map[string]interface{}, error) {
	toSerialize := map[string]interface{}{}
	if !IsNil(o.Name) {
		toSerialize["name"] = o.Name
	}
	return toSerialize, nil
}

type NullableTestFormObjectMultipartRequestMarker struct {
	value *TestFormObjectMultipartRequestMarker
	isSet bool
}

func (v NullableTestFormObjectMultipartRequestMarker) Get() *TestFormObjectMultipartRequestMarker {
	return v.value
}

func (v *NullableTestFormObjectMultipartRequestMarker) Set(val *TestFormObjectMultipartRequestMarker) {
	v.value = val
	v.isSet = true
}

func (v NullableTestFormObjectMultipartRequestMarker) IsSet() bool {
	return v.isSet
}

func (v *NullableTestFormObjectMultipartRequestMarker) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableTestFormObjectMultipartRequestMarker(val *TestFormObjectMultipartRequestMarker) *NullableTestFormObjectMultipartRequestMarker {
	return &NullableTestFormObjectMultipartRequestMarker{value: val, isSet: true}
}

func (v NullableTestFormObjectMultipartRequestMarker) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableTestFormObjectMultipartRequestMarker) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


