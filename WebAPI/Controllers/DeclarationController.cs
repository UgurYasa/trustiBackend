using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
	[Route("[controller]")]
	[ApiController]
	public class DeclarationController : ControllerBase
	{
		private IDeclarationService _declarationService;

		public DeclarationController(IDeclarationService declarationService)
		{
			_declarationService = declarationService;
		}
		[HttpGet("getall")]
		public IActionResult GetDeclarationList()
		{
			var result = _declarationService.GetDeclarationList();
			if (result.IsSuccess)
			{
				return new OkObjectResult(result);
			}
			return new BadRequestObjectResult(result);
		}

		[HttpGet("{id}")]
		public IActionResult GetDeclarationById(int id)
		{
			var result = _declarationService.GetDeclarationById(id);
			if (result.IsSuccess)
			{
				return new OkObjectResult(result);
			}
			return new BadRequestObjectResult(result);
		}
		[HttpPost("add")]
		public IActionResult AddDeclaration(Declaration declaration)
		{
			var result = _declarationService.AddDeclaration(declaration);
			if (result.IsSuccess)
			{
				return new OkObjectResult(result);
			}
			return new BadRequestObjectResult(result);
		}

		[HttpDelete("{id}")]
		public IActionResult DeleteDeclaration(int id)
		{
			var result = _declarationService.DeleteDeclaration(id);
			if (result.IsSuccess)
			{
				return new OkObjectResult(result);
			}
			return new BadRequestObjectResult(result);
		}
	}
}
