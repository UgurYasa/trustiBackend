using Business.Abstract;
using Core.Utilities;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
	public class CityManager : ICityService
	{
		private ICityDal _cityDal;
		public CityManager(ICityDal cityDal)
		{
			_cityDal = cityDal;
		}

		public Response<City> AddCity(City city)
		{
			_cityDal.Add(city);
			return new Response<City>().Success("Başarıyla Kaydedildi");
		}
		public Response<City> GetById(int cityId)
		{
			try
			{
				var result = _cityDal.Get(c => c.City_Id == cityId);
				if (result!=null)
				{
					return new Response<City>().Success(result);

				}

				return new Response<City>().Error("City Not Found");

			}
			catch (Exception ex)
			{
			return new Response<City>().Error(ex.Message);
			}
		}

		public Response<List<City>> GetListCity()
		{

			return new Response<List<City>>().Success(_cityDal.GetList());
		}

		public Response<City> UpdateCity(City city)
		{
			_cityDal.Update(city);
			return new Response<City>().Success("Başarıyla Güncellendi");
		}
	}
}
