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
	public interface ICustomerService
	{

		Response<CustomerDto> GetCustomerById(int customerId);
		Response<Customer> GetCustomerByTCKNo(string TCKNo);
		Response<CustomerDto> GetFilterByTCKNo(string TCKNo);

		Response<List<CustomerDto>> GetListCustomer();
		Response<Customer> AddCustomer(Customer customer);
		Response<Customer> DeleteCustomer(int customerId);
		Response<Customer> UpdateCustomer(Customer customer);




	}
}
