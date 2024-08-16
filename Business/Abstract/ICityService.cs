using Core.Utilities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
	public interface ICityService
	{
		Response<City> GetById(int cityId);
		Response<List<City>> GetListCity();
		Response<City> AddCity(City city);
		Response<City> UpdateCity(City city);


	}
}
