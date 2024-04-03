using CMSS.Interfaces;
using CMSS.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CMSS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly ICountryService _countryService;
        public CountryController(ICountryService countryService)
        {
            _countryService = countryService;
        }

        [HttpGet]
        public async Task<IActionResult> CountryName(string countryName)
        {
            if (ModelState.IsValid)
            {
                var result = await _countryService.GetCountryByCountryName(countryName);
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }

        }

        [HttpPost]
        public async Task<IActionResult> AddCountry(Country country)
        {
            if (ModelState.IsValid)
            {
                var result = await _countryService.AddCountry(country);
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }

        }

        [HttpPut]
        public async Task<IActionResult> UpdateCountry(Country country)
        {
            if (ModelState.IsValid)
            {
                var result = await _countryService.UpdateCountry(country);
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }

        }
        [HttpDelete]
        public async Task<IActionResult> RemoveCountry(Country country)
        {
            if (ModelState.IsValid)
            {
                var result = await _countryService.RemoveCountry(country);
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }

        }
    }
}
