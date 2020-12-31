# Cloudmersive.APIClient.NET.Validate.Model.IPIntelligenceResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsBot** | **bool?** | True if the IP address is a known bot, otherwise false | [optional] 
**IsTorNode** | **bool?** | True if the IP address is a known Tor exit node, otherwise false | [optional] 
**IsThreat** | **bool?** | True if the IP address is a known threat IP, otherwise false | [optional] 
**IsEU** | **bool?** | True if the IP address is in the European Union, otherwise false | [optional] 
**Location** | [**GeolocateResponse**](GeolocateResponse.md) | Returns the location of the IP address | [optional] 
**CurrencyCode** | **string** | ISO 4217 currency code for the IP address location | [optional] 
**CurrencyName** | **string** | Name of the currency in English | [optional] 
**RegionArea** | **string** | Region (continent) in which the country is located; possible values are None, Europe, Americas, Asia, Africa, Oceania | [optional] 
**SubregionArea** | **string** | Subregion in which the country is located; possible values are None, NorthernEurope, WesternEurope, SouthernEurope, EasternEurope, CentralAmerica, NorthernAmerica, SouthAmerica, EasternAfrica, MiddleAfrica, NorthernAfrica , SouthernAfrica , WesternAfrica , CentralAsia , EasternAsia , SouthernAsia , SouthEasternAsia , WesternAsia , Southern , Middle , AustraliaandNewZealand , Melanesia , Polynesia , Micronesia , Caribbean, | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

