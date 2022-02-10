using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telecommunication.Models;

namespace Telecommunication.EntityDTOs
{
    public class DetailsDTO
    {
        public string Number { get; set; }
        public CountryDTO CountryDTO { get; set; }
    }
    public class CountryDTO
    {
        public string CountryCode { get; set; }
        public string Name { get; set; }
        public string CountryIso { get; set; }
        public List<CountryDetailsDTO> CountryDetailsDTO { get; set; }
    }
    public class CountryDetailsDTO
    {
        public string Operator { get; set; }
        public string OperatorCode { get; set; }
    }
}
