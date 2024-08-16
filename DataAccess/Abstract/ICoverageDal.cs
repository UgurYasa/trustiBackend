using Core.DataAccess;
using Entities.Concrete;
using Entities.Dto;

namespace DataAccess.Abstract
{
    public interface ICoverageDal : IEntityRepository<Coverage>
	{
		List<NetworkDto> GetNetworkList(int cityId);

	}
}
