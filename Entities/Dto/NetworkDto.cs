using Core.Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto
{
    public class NetworkDto :Coverage,IDto
    {
        public string City_Name { get; set; }
        public NetworkDto(
            int coverageCode,
            string coverageNetwork,
            string coverageModel,
            decimal coverageAmount,
            decimal premium,
            decimal cityOrganization,
            decimal neighborCityOrganization,
            decimal countryOrganization,
            int cityId,
            string cityName):base(coverageCode,coverageNetwork,coverageModel,coverageAmount,premium,cityOrganization,neighborCityOrganization,countryOrganization,cityId)
        {
            
            City_Name = cityName;
        }
    }
}
