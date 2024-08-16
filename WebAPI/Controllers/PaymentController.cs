using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
	[Route("[controller]")]
	[ApiController]
	public class PaymentController : ControllerBase
	{
		private IPaymentService _paymentService;
		public PaymentController(IPaymentService paymentService)
		{
			_paymentService = paymentService;
		}
		[HttpGet("getAll")]
		public IActionResult GetAll()
		{
			var result = _paymentService.GetPaymentList();
			if (result.IsSuccess)
			{
				return new OkObjectResult(result);
			}
			return new BadRequestObjectResult(result);
		}
		[HttpPost("add")]
		public IActionResult Add(Payment payment)
		{
			var result = _paymentService.AddPayment(payment);
			if (result.IsSuccess)
			{
				return new OkObjectResult(result);
			}
			return new BadRequestObjectResult(result);
		}
	}

}
