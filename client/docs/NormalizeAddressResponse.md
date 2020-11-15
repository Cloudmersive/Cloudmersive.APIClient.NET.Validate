# Cloudmersive.APIClient.NET.Validate.Model.NormalizeAddressResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ValidAddress** | **bool?** | True if the address is valid, false otherwise | [optional] 
**Building** | **string** | The name of the building, house or structure if applicable, such as \&quot;Cloudmersive Building 2\&quot;.  This will often by null. | [optional] 
**StreetNumber** | **string** | The street number or house number of the address.  For example, in the address \&quot;1600 Pennsylvania Avenue NW\&quot; the street number would be \&quot;1600\&quot;.  This value will typically be populated for most addresses. | [optional] 
**Street** | **string** | The name of the street or road of the address.  For example, in the address \&quot;1600 Pennsylvania Avenue NW\&quot; the street number would be \&quot;Pennsylvania Avenue NW\&quot;. | [optional] 
**City** | **string** | The city of the address. | [optional] 
**StateOrProvince** | **string** | The state or province of the address. | [optional] 
**PostalCode** | **string** | The postal code or zip code of the address. | [optional] 
**CountryFullName** | **string** | Country of the address, if present in the address.  If not included in the address it will be null. | [optional] 
**ISOTwoLetterCode** | **string** | Two-letter ISO 3166-1 country code | [optional] 
**Latitude** | **double?** | If the address is valid, the degrees latitude of the validated address, null otherwise | [optional] 
**Longitude** | **double?** | If the address is valid, the degrees longitude of the validated address, null otherwise | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

