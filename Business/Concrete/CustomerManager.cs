using Business.Abstract;
using Core.Utilities;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto;


namespace Business.Concrete
{
	public class CustomerManager : ICustomerService
	{
		private ICustomerDal _customerDal;
		public CustomerManager(ICustomerDal customerDal)
		{
			_customerDal = customerDal;
		}
		public Response<Customer> AddCustomer(Customer customer)
		{
			try
			{
				_customerDal.Add(customer);
				return new Response<Customer>().Success("Başarıyla Eklendi");
			}
			catch (Exception ex)
			{
				return new Response<Customer>().Error(ex.Message);
			}

		}

		public Response<Customer> DeleteCustomer(int customerId)
		{
			try {
				var customer = _customerDal.Get(c => c.Customer_No == customerId);
				if (customer != null)
				{
					_customerDal.Delete(customer);
					return new Response<Customer>().Success("Başarıyla Silindi");
				}
				return new Response<Customer>().Error("Customer Not Found");
			}
			catch (Exception ex) {
			return new Response<Customer>().Error(ex.Message);
			}
		}

		public Response<List<CustomerDto>> GetListCustomer()
		{
			return new Response<List<CustomerDto>>().Success(_customerDal.GetCustomerDto());

		}

		public Response<CustomerDto> GetCustomerById(int customerId)
		{
			try
			{
				var result = _customerDal.GetCustomerDtoById(customerId);
				if (result != null)
					return new Response<CustomerDto>().Success(result);
				return new Response<CustomerDto>().Error("Customer Not Found");
			}
			catch (Exception ex)
			{
				return new Response<CustomerDto>().Error(ex.Message);
			}
		}

		public Response<Customer> GetCustomerByTCKNo(string TCKNo)
		{
			try
			{
				var result = _customerDal.Get(c => String.Equals(c.TCKNo, TCKNo));
				if (result != null)
				{
					return new Response<Customer>().Success(result);
				}
				else
				{
					return new Response<Customer>().Error("Customer Not Found");
				}
			}
			catch (Exception ex)
			{
				return new Response<Customer>().Error(ex.Message);
			}
		}

		public Response<Customer> UpdateCustomer(Customer customer)
		{
			try
			{
				_customerDal.Update(customer);
				return new Response<Customer>().Success("Başarıyla Güncellendi");
			}
			catch (Exception ex)
			{
				return new Response<Customer>().Error(ex.Message);
			}
		}

		public Response<CustomerDto> GetFilterByTCKNo(string TCKNo)
		{

			try
			{
				var result = _customerDal.GetCustomerDtoByTCKNo(TCKNo);
				if (result != null)
				{
					return new Response<CustomerDto>().Success(result);
				}
				else
				{
					return new Response<CustomerDto>().Error("Customer Not Found");
				}
			}
			catch (Exception ex)
			{
				return new Response<CustomerDto>().Error(ex.Message);
			}
		}
	}
}
