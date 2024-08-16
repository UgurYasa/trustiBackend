using Core.Utilities;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICoverageService
	{
		Response<List<Coverage>> GetCoverageList();
		Response<Coverage> GetFilterByCoverageId(int CoverageId);
		Response<List<NetworkDto>> GetNetworkByCity(int id);

		Response<Coverage> UpdateCoverage(Coverage coverage);
		Response<Coverage> AddCoverage(Coverage coverage);

	}
}
