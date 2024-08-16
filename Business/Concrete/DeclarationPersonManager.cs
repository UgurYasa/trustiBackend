using Business.Abstract;
using Core.Utilities;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
	public class DeclarationPersonManager : IDeclarationPersonService
	{
		private IDeclarationPersonDal _declarationPersondal;
		public DeclarationPersonManager(IDeclarationPersonDal declarationPersondal)
		{
			_declarationPersondal = declarationPersondal;
		}

		public Response<DeclarationPerson> AddDeclarationPerson(List<DeclarationPerson> declarationPersonDtos)
		{
			try
			{
				foreach (var i in declarationPersonDtos)
				{
					_declarationPersondal.Add(i);
				}
				return new Response<DeclarationPerson>().Success("Declaration Person Added");
			}
			catch (Exception ex)
			{
				return new Response<DeclarationPerson>().Error(ex.Message);
			}

		}

		public Response<List<DeclarationPersonDto>> DeclarationPersonFilterById(int customer_no)
		{
			try
			{
				var result = _declarationPersondal.getDeclarationPersonDtoList().Where(x => x.Customer_No == customer_no).ToList();
				if (result != null)
				{
					return new Response<List<DeclarationPersonDto>>().Success(result);
				}
				return new Response<List<DeclarationPersonDto>>().Error("Declaration Person Data Not Found");
			}
			catch (Exception ex)
			{
				return new Response<List<DeclarationPersonDto>>().Error(ex.Message);
			}
		}

		public Response<DeclarationPerson> DeleteDeclarationPerson(int declaration_Id)
		{
			try
			{ 
				var result = _declarationPersondal.Get(x => x.Declaration_Id == declaration_Id);
				if (result != null) {
					_declarationPersondal.Delete(result);
					return new Response<DeclarationPerson>().Success("Declaration Person Deleted");
				}
				return new Response<DeclarationPerson>().Error("Declaration Person Not Found");
				

			}catch(Exception ex)
			{
				return new Response<DeclarationPerson>().Error(ex.Message);
			}
		}


		

		public Response<List<DeclarationPerson>> GetDeclarationPerson()
		{

			try
			{
				var result = _declarationPersondal.GetList();
				if (result != null && result.Count>0)
				{
					return new Response<List<DeclarationPerson>>().Success(result);
				}
				return new Response<List<DeclarationPerson>>().Error("Declaration-Person No Found!!");
			}
			catch (Exception ex)
			{
				return new Response<List<DeclarationPerson>>().Error(ex.Message);
			}
		}

		public Response<List<DeclarationPersonDto>> GetDeclarationPersonDto()
		{
			try
			{
				var result = _declarationPersondal.getDeclarationPersonDtoList();
				if (result != null)
				{
					return new Response<List<DeclarationPersonDto>>().Success(result);
				}
				return new Response<List<DeclarationPersonDto>>().Error("Declaration Person Data Not Found");
			}
			catch (Exception ex)
			{
				return new Response<List<DeclarationPersonDto>>().Error(ex.Message);
			}
		}

		public Response<DeclarationPerson> UpdateDeclarationPerson(List<DeclarationPerson> declarationPersonDtos)
		{
			try
			{
				foreach (var i in declarationPersonDtos)
				{
					_declarationPersondal.Update(i);
				}
				return new Response<DeclarationPerson>().Success("Declaration Person Updated");
			}
			catch (Exception ex)
			{
				return new Response<DeclarationPerson>().Error(ex.Message);
			}
		}
	}
}
