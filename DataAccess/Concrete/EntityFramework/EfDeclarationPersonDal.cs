using Core.DataAccess.EntityFramework;
using Core.Utilities;
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
	public class EfDeclarationPersonDal : EfEntityRepositoryBase<DeclarationPerson, QuickContext>, IDeclarationPersonDal
	{
		public List<DeclarationPersonDto> getDeclarationPersonDtoList()
		{
			using (var context = new QuickContext())
			{
				var result = from declarationperson in context.Declaration_Person
							 join declaration in context.Declaration on declarationperson.Declaration_Id equals declaration.Declaration_Id
							 join customer in context.Customer on declarationperson.Customer_No equals customer.Customer_No
							 select new DeclarationPersonDto(
								 declarationperson.Declaration_Id,
								 declarationperson.Customer_No,
								 declarationperson.Answer,
								 declarationperson.Description,
								 declaration.Declaration_Question,
								 customer.First_Name,
								 customer.Last_Name
								 );
				return result.ToList();
			}
		}
	}
}

