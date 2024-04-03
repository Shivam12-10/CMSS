using CMSS.Interfaces;
using CMSS.Model;
using CMSS.Utility;
using CMSS.Utility.API_Response;
using static CMSS.Services.CountryService;

namespace CMSS.Services
{
    public class CountryService : ICountryService
    {
       
            private readonly ICountryRepository _countryRepository;
            public CountryService(ICountryRepository countryRepository)
            {
            _countryRepository = countryRepository;
            }

            public async Task<CountryResponse<List<Country>>> GetCountryByCountryName(string countryName)
            {
                var result = await _countryRepository.GetCountryByCountryName(countryName);
                return BuildResponse.SuccessResponse(result, CountryConstant.SuccessResponse);
            }

            public async Task<CountryResponse<bool>> AddCountry(Country country)
            {
                var result = await _countryRepository.AddCountry(country);
                return BuildResponse.SuccessResponse(result, CountryConstant.AddResponse);
            }

        public async Task<CountryResponse<bool>> UpdateCountry(Country country)
        {
            var result =  await _countryRepository.UpdateCountry(country);
            return BuildResponse.SuccessResponse(result, CountryConstant.UpdateResponse);
           
        }
        public async Task<CountryResponse<bool>> RemoveCountry(Country country)
        {
            var result = await _countryRepository.RemoveCountry(country);
            return BuildResponse.SuccessResponse(result, CountryConstant.UpdateResponse);

        }
    }
}
