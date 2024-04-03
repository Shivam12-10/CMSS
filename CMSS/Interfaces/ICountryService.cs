using CMSS.Model;
using CMSS.Utility;
using CMSS.Utility.API_Response;

namespace CMSS.Interfaces
{
    public interface ICountryService
    {
        Task<CountryResponse<List<Country>>> GetCountryByCountryName(string name);
        Task<CountryResponse<bool>> AddCountry(Country country);
        Task<CountryResponse<bool>> UpdateCountry(Country country);
        Task<CountryResponse<bool>> RemoveCountry(Country country);
    }
}
