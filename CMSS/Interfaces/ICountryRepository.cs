using CMSS.Model;

namespace CMSS.Interfaces
{
    public interface ICountryRepository
    {
        Task<List<Country>> GetCountryByCountryName(string countryName);
        Task <bool> AddCountry(Country country);
        Task<bool> UpdateCountry(Country country);
        Task<bool> RemoveCountry(Country country);
    }
}
