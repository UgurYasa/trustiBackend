using Business.Abstract;
using Core.Utilities;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CoverageManager : ICoverageService
	{
		private ICoverageDal _coverageDal;
		public CoverageManager(ICoverageDal coverageDal)
		{
			_coverageDal = coverageDal;
		}
		public Response<Coverage> AddCoverage(Coverage coverage)
		{
			_coverageDal.Add(coverage);
			return new Response<Coverage>().Success("Başarıyla eklendi");
		}

		public Response<List<Coverage>> GetCoverageList()
		{
			try
			{
				var result = _coverageDal.GetList();
				return new Response<List<Coverage>>().Success(result);
			}
			catch (Exception ex)
			{
				return new Response<List<Coverage>>().Error(ex.Message);
			}
		}

		public Response<Coverage> GetFilterByCoverageId(int CoverageId)
		{
			try
			{
				var result = _coverageDal.Get(x => x.Coverage_Code == CoverageId);
				if(result!=null)
					return new Response<Coverage>().Success(result);
				return new Response<Coverage>().Error("Coverage Not Found");

			}
			catch (Exception ex)
			{
				return new Response<Coverage>().Error(ex.Message);
			}
			
		}

		public Response<List<NetworkDto>> GetNetworkByCity(int id)
		{
			var result = _coverageDal.GetNetworkList(id);
			var sortedList = result
	.OrderBy(obj => obj.Coverage_Network == "Pembe" ? 1 : obj.Coverage_Network == "Yeşil" ? 2 : 3)
	.ThenBy(obj => obj.Coverage_Model == "Yatarak Tedavi" ? 1 : 2)
	.ToList();
			return new Response<List<NetworkDto>>().Success(sortedList);
		}

		public Response<Coverage> UpdateCoverage(Coverage coverage)
		{
			_coverageDal.Update(coverage);
			return new Response<Coverage>().Success("Başarıyla güncellendi");
		}
	}
}



