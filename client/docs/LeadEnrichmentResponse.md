# Cloudmersive.APIClient.NET.Validate.Model.LeadEnrichmentResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Successful** | **bool?** | True if the operation was successful, false otherwise | [optional] 
**LeadType** | **string** | The type of the lead; possible types are Junk (a single individual using a disposable/throwaway email address); Individual (a single individual, typically a consumer, not purchasing on behalf of a business); SmallBusiness (a small business, typically with fewer than 100 employees); MediumBusiness (a medium business, larger than 100 employees but fewer than 1000 employees); Enterprise (a large business with greater than 1000 employees); Business (a business customer of unknown size) | [optional] 
**ContactBusinessEmail** | **string** | The person&#39;s business email address for the lead | [optional] 
**ContactFirstName** | **string** | The person&#39;s first name for the lead | [optional] 
**ContactLastName** | **string** | The person&#39;s last name for the lead | [optional] 
**ContactGender** | **string** | Gender for contact name; possible values are Male, Female, and Neutral (can be applied to Male or Female).  Requires ContactFirstName. | [optional] 
**CompanyName** | **string** | Name of the company for the lead | [optional] 
**CompanyDomainName** | **string** | Domain name / website for the lead | [optional] 
**CompanyHouseNumber** | **string** | House number of the address of the company for the lead | [optional] 
**CompanyStreet** | **string** | Street name of the address of the company for the lead | [optional] 
**CompanyCity** | **string** | City of the address of the company for the lead | [optional] 
**CompanyStateOrProvince** | **string** | State or Province of the address of the company for the lead | [optional] 
**CompanyPostalCode** | **string** | Postal Code of the address of the company for the lead | [optional] 
**CompanyCountry** | **string** | Country Name of the address of the company for the lead | [optional] 
**CompanyCountryCode** | **string** | Country Code (2-letter ISO 3166-1) of the address of the company for the lead | [optional] 
**CompanyTelephone** | **string** | Telephone of the company office for the lead | [optional] 
**CompanyVATNumber** | **string** | VAT number of the company for the lead | [optional] 
**EmployeeCount** | **int?** | Count of employees at the company (estimated), if available | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

