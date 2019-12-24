# Cloudmersive.APIClient.NET.Validate.Model.VatLookupResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CountryCode** | **string** | Two-letter country code | [optional] 
**VatNumber** | **string** | VAT number | [optional] 
**IsValid** | **bool?** | True if the VAT code is valid, false otherwise | [optional] 
**BusinessName** | **string** | Name of the business | [optional] 
**BusinessAddress** | **string** | Business address as a single string | [optional] 
**BusinessBuilding** | **string** | For the business address, the name of the building, house or structure if applicable, such as \&quot;Cloudmersive Building 2\&quot;.  This will often by null. | [optional] 
**BusinessStreetNumber** | **string** | For the business address, the street number or house number of the address.  For example, in the address \&quot;1600 Pennsylvania Avenue NW\&quot; the street number would be \&quot;1600\&quot;.  This value will typically be populated for most addresses. | [optional] 
**BusinessStreet** | **string** | For the business address, the name of the street or road of the address.  For example, in the address \&quot;1600 Pennsylvania Avenue NW\&quot; the street number would be \&quot;Pennsylvania Avenue NW\&quot;. | [optional] 
**BusinessCity** | **string** | For the business address, the city of the address. | [optional] 
**BusinessStateOrProvince** | **string** | For the business address, the state or province of the address. | [optional] 
**BusinessPostalCode** | **string** | For the business address, the postal code or zip code of the address. | [optional] 
**BusinessCountry** | **string** | For the business address, country of the address, if present in the address.  If not included in the address it will be null. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

