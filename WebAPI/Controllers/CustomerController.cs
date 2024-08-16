using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
	[Route("[controller]")]
	[ApiController]
	public class CustomerController : ControllerBase
	{
		private ICustomerService _customerService;

		public CustomerController(ICustomerService customerService)
		{
			_customerService = customerService;
		}

		[HttpGet("customers")]
		public IActionResult GetListCustomer()
		{
			var result = _customerService.GetListCustomer();
			if (result.IsSuccess)
			{
				return new OkObjectResult(result);
			}
			return new BadRequestObjectResult(result);
		}

		[HttpGet("invisible/{TCKNo}")]
		public IActionResult GetCustomerByTCKNo(string TCKNo)
		{
			var result = _customerService.GetCustomerByTCKNo(TCKNo);
			if (result.IsSuccess)
			{
				return new OkObjectResult(result);
			}
			return new BadRequestObjectResult(result);
		}

		[HttpGet("{TCKNo}")]
		public IActionResult GetFilterByTCKNo(string TCKNo)
		{
			var result = _customerService.GetFilterByTCKNo(TCKNo);
			if (result.IsSuccess)
			{
				return new OkObjectResult(result);
			}
			return new BadRequestObjectResult(result);
		}

		[HttpGet("id/{CustomerId}")]
		public IActionResult GetCustomerById(int CustomerId)
		{
			var result = _customerService.GetCustomerById(CustomerId);
			if (result.IsSuccess)
			{
				return new OkObjectResult(result);
			}
			return new BadRequestObjectResult(result);
		}

		[HttpPost("add")]
		public IActionResult AddCustomer(Customer customer)
		{
			var result = _customerService.AddCustomer(customer);
			if (result.IsSuccess)
			{ return new OkObjectResult(result); }
			return new BadRequestObjectResult(result);
		}
		[HttpPut("update")]
		public IActionResult UpdateCustomer(Customer customer)
		{
			var result = _customerService.UpdateCustomer(customer);
			if (result.IsSuccess)
			{ return new OkObjectResult(result); }
			return new BadRequestObjectResult(result);
		}
		[HttpDelete("delete")]
		public IActionResult DeleteCustomer(int customerId)
		{
			var result = _customerService.DeleteCustomer(customerId);
			if (result.IsSuccess)
			{ return new OkObjectResult(result); }
			return new BadRequestObjectResult(result);
		}
	}
}
