using Core.Utilities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
	public interface IPaymentService
	{
		Response<List<Payment>> GetPaymentList();
		Response<Payment> GetPaymentById(int id);
		Response<Payment> AddPayment(Payment payment);
	}
}
