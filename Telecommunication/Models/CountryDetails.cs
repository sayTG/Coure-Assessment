using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Telecommunication.Models
{
    public class CountryDetails
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public string Operator { get; set; }
        public string OperatorCode { get; set; }
    }
}
