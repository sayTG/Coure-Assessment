using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telecommunication.Abstractions;
using Telecommunication.EntityDTOs;
using Telecommunication.Models;

namespace Telecommunication.Implementation
{
    public class CustomMapping : ICustomMapping
    {
        public DetailsDTO Map(string number, Country country, DetailsDTO detailsDTO)
        {
            detailsDTO.Number = number;
            detailsDTO.CountryDTO = new CountryDTO()
            {
                CountryCode = country.CountryCode,
                Name = country.Name,
                CountryIso = country.CountryIso
            };
            detailsDTO.CountryDTO.CountryDetailsDTO = new List<CountryDetailsDTO>();
            foreach (CountryDetails details in country.CountryDetails)
            {
                detailsDTO.CountryDTO.CountryDetailsDTO.Add(new CountryDetailsDTO()
                {
                    Operator = details.Operator,
                    OperatorCode = details.OperatorCode
                });
            }
            return detailsDTO;
        }
    }
}
