using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
	public class EfCustomerDal : EfEntityRepositoryBase<Customer, QuickContext>, ICustomerDal
	{
		public List<CustomerDto> GetCustomerDto()
		{
			using (var context = new QuickContext())
			{
				var result = from customer in context.Customer
							 join city in context.City on customer.City_Id equals city.City_Id
							 select new CustomerDto(
								 customer.Customer_No,
								 customer.TCKNo,
								 customer.Birth_Date,
								 customer.First_Name,
								 customer.Last_Name,
								 customer.Email,
								 customer.Phone,
								 customer.Gender,
								 customer.Family_Member,
								 customer.City_Id,
								 city.City_Name
								 );
				return result.ToList();
			}

		}

		public CustomerDto GetCustomerDtoById(int customerId)
		{
			using (var context = new QuickContext())
			{
				var result = from customer in context.Customer
							 join city in context.City on customer.City_Id equals city.City_Id
							 where customer.Customer_No == customerId
							 select new CustomerDto(
								 customer.Customer_No,
								 customer.TCKNo,
								 customer.Birth_Date,
								 customer.First_Name,
								 customer.Last_Name,
								 customer.Email,
								 customer.Phone, customer.Gender,
								 customer.Family_Member,
								 customer.City_Id,
								 city.City_Name
								 );
				return result.Single();
			}
		}

		public CustomerDto GetCustomerDtoByTCKNo (string tckno)
		{
			using (var context = new QuickContext())
			{
				var result = from customer in context.Customer
							 join city in context.City on customer.City_Id equals city.City_Id
							 where String.Equals(customer.TCKNo, tckno)
							 select new CustomerDto(
								 customer.Customer_No,
								 customer.TCKNo,
								 customer.Birth_Date,
								 customer.First_Name,
								 customer.Last_Name,
								 customer.Email,
								 customer.Phone, customer.Gender,
								 customer.Family_Member,
								 customer.City_Id,
								 city.City_Name
								 );
				return result.SingleOrDefault();
			}
		}
	}
}