using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using Telecommunication.Abstractions;
using Telecommunication.EntityConfiguration;
using Telecommunication.EntityDTOs;
using Telecommunication.HelperMethods;
using Telecommunication.Models;

namespace Telecommunication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TelecomsController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IDataService _dataService;
        private readonly ICustomMapping _custom;

        public TelecomsController(AppDbContext context, IDataService dataService, ICustomMapping custom)
        {
            _context = context;
            _dataService = dataService;
            _custom = custom;
        }
        [HttpGet("countrydetails")]
        public IActionResult GetCountryDetails(string phoneNumber)
        {
            if (string.IsNullOrEmpty(phoneNumber))
                return BadRequest("please provide a phone number");
            string countryCode = phoneNumber.CountryCode();
            if (string.IsNullOrEmpty(countryCode))
                return BadRequest("Could not retrieve country code");
            Country country = _dataService.GetDetails(countryCode, phoneNumber);
            if (country == null)
                return BadRequest("Record not found");
            DetailsDTO detailsDTO = _custom.Map(phoneNumber, country, new DetailsDTO());
            return Ok(detailsDTO);
        }
    }
}
