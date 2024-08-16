using Business.Abstract;
using Core.Utilities;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
	public class PaymentManager : IPaymentService
	{
		private IPaymentDal _paymentdal;
        public PaymentManager(IPaymentDal paymentDal)
        {
            _paymentdal = paymentDal;
        }
        public Response<Payment> AddPayment(Payment payment)
		{
			try {
				_paymentdal.Add(payment);
				return new Response<Payment>().Success("Başarıyla Kaydedildi");
			}
			catch(Exception ex) {
			return new Response<Payment>().Error(ex.Message);
			}
			
		}

		public Response<Payment> GetPaymentById(int id)
		{
			try
			{
				var result = _paymentdal.Get(p => p.Payment_Id == id);
				if (result != null)
				{
					return new Response<Payment>().Success(result);
				}
				return new Response<Payment>().Error("Payment Not Found");
			}catch(Exception ex)
			{
				return new Response<Payment>().Error(ex.Message);
			}
		}

		public Response<List<Payment>> GetPaymentList()
		{
			try
			{
				var result = _paymentdal.GetList();
				if (result != null)
				{
					return new Response<List<Payment>>().Success(result);
				}
				return new Response<List<Payment>>().Error("Payment Not Found");
			}
			catch (Exception ex)
			{
				return new Response<List<Payment>>().Error(ex.Message);
			}
		}
	}
}
