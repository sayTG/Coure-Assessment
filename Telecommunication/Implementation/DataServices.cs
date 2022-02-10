using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Telecommunication.Abstractions;
using Telecommunication.EntityConfiguration;
using Telecommunication.EntityDTOs;
using Telecommunication.Models;

namespace Telecommunication.Implementation
{
    public class DataServices : IDataService
    {
        private readonly AppDbContext _context;
        public DataServices(AppDbContext context)
        {
            _context = context;
        }
        public Country GetDetails(string countryCode, string number)
        {
            return _context.Country.Where(x => x.CountryCode.Equals(countryCode))
                                              .Include(x => x.CountryDetails)
                                              .FirstOrDefault();
             
        }
    }
}
