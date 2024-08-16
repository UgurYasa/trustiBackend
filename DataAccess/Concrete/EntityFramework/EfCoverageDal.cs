using Core.DataAccess.EntityFramework;
using Core.Utilities;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using Entities.Dto;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCoverageDal : EfEntityRepositoryBase<Coverage, QuickContext>, ICoverageDal
	{
		public List<NetworkDto> GetNetworkList(int cityId)
		{
			using (var context = new QuickContext())
			{
				var result = from coverage in context.Coverage
							 join city in context.City on coverage.City_Id equals city.City_Id
							 where coverage.City_Id == cityId
							 select new NetworkDto(
								 coverage.Coverage_Code,
								 coverage.Coverage_Network,
								 coverage.Coverage_Model,
								 coverage.Coverage_Amount,
								 coverage.Premium,
								 coverage.City_Organization,
								 coverage.Neighbor_City_Organization,
								 coverage.Country_Organization,
								 coverage.City_Id,
								 city.City_Name

								 );
				return result.ToList();
			}
		}
	}
}
