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
	public class DeclarationManager : IDeclarationService
	{
		private IDeclarationDal _declarationDal;
		private IDeclarationPersonService _declarationPersonService;
		public DeclarationManager(IDeclarationDal declarationDal,IDeclarationPersonService declarationPersonService)
		{
			_declarationDal = declarationDal;
			_declarationPersonService = declarationPersonService;
		}

		public Response<Declaration> AddDeclaration(Declaration declaration)
		{
			try
			{
				_declarationDal.Add(declaration);
				return new Response<Declaration>().Success("Başarıyla Kaydedildi");
			}
			catch (Exception ex)
			{
				return new Response<Declaration>().Error(ex.Message);
			}
		}

		public Response<Declaration> DeleteDeclaration(int id)
		{
			try
			{
				_declarationPersonService.DeleteDeclarationPerson(id);
				var result = _declarationDal.Get(x => x.Declaration_Id == id);
				_declarationDal.Delete(result);
				return new Response<Declaration>().Success("Başarıyla Silindi");
			}
			catch (Exception ex)
			{
				return new Response<Declaration>().Error(ex.Message);
			}
		}

		public Response<Declaration> GetDeclarationById(int id)
		{
			try
			{
				var result = _declarationDal.Get(x => x.Declaration_Id == id);
				if (result != null)
				{
					return new Response<Declaration>().Success(result);
				}
				return new Response<Declaration>().Error("Declaration Not Found");
			}
			catch (Exception ex)
			{
				return new Response<Declaration>().Error(ex.Message);
			}
		}

		public Response<List<Declaration>> GetDeclarationList()
		{
			try
			{
				var result = _declarationDal.GetList();
				if (result != null)
				{
					return new Response<List<Declaration>>().Success(result);
				}
				return new Response<List<Declaration>>().Error("Declaration Not Found");
			}
			catch (Exception ex)
			{
				return new Response<List<Declaration>>().Error(ex.Message);
			}
		}
	}
}
