# Cloudmersive.APIClient.NET.Validate.Model.PhoneNumberValidationResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsValid** | **bool?** | True if the phone number is valid, false otherwise | [optional] 
**Successful** | **bool?** | True if the operation was successful, false if there was an error during validation.  See IsValid for validation result. | [optional] 
**PhoneNumberType** | **string** | Type of phone number; possible values are: FixedLine, Mobile, FixedLineOrMobile, TollFree, PremiumRate,   SharedCost, Voip, PersonalNumber, Pager, Uan, Voicemail, Unknown | [optional] 
**E164Format** | **string** | E.164 format of the phone number | [optional] 
**InternationalFormat** | **string** | Internaltional format of the phone number | [optional] 
**NationalFormat** | **string** | National format of the phone number | [optional] 
**CountryCode** | **string** | Two digit country code of the phone number | [optional] 
**CountryName** | **string** | User-friendly long name of the country for the phone number | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

