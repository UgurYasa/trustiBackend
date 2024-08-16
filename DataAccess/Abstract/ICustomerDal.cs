using Core.DataAccess;
using Entities.Concrete;
using Entities.Dto;

namespace DataAccess.Abstract
{
	public interface ICustomerDal:IEntityRepository<Customer>
	{
		public List<CustomerDto> GetCustomerDto();
		public CustomerDto GetCustomerDtoByTCKNo(string tckno);
		public CustomerDto GetCustomerDtoById(int customerId);
	}
}
