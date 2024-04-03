using CMSS.Interfaces;
using CMSS.Model;
using Microsoft.EntityFrameworkCore;

namespace CMSS.Repository
{
    public class CountryRepository : ICountryRepository
    {
        private readonly ApplicationDbContext _context;
        public CountryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> AddCountry(Country country)
        {
            try
            {
                await _context.Countries.AddAsync(country);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> UpdateCountry(Country country)
        {
            try
            {
                 _context.Countries.Update(country);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public async Task<bool> RemoveCountry(Country country)
        {
            try
            {
                _context.Countries.Remove(country);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<List<Country>> GetCountryByCountryName(string countryName)
        {
            return await _context.Countries.Where(x => x.CountryName == countryName).ToListAsync();
        }
    }
}
