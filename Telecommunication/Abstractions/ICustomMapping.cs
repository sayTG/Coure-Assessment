using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telecommunication.EntityDTOs;
using Telecommunication.Models;

namespace Telecommunication.Abstractions
{
    public interface ICustomMapping
    {
        DetailsDTO Map(string number, Country country, DetailsDTO detailsDTO);
    }
}
