using Core.Utilities;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
	public interface IDeclarationPersonService
	{
		Response<List<DeclarationPerson>> GetDeclarationPerson();
		Response<List<DeclarationPersonDto>> GetDeclarationPersonDto();
		Response<DeclarationPerson>AddDeclarationPerson(List<DeclarationPerson> declarationPersonDtos);
		Response<List<DeclarationPersonDto>> DeclarationPersonFilterById(int customer_no);
		Response<DeclarationPerson> UpdateDeclarationPerson(List<DeclarationPerson> declarationPersonDtos);

		Response<DeclarationPerson> DeleteDeclarationPerson(int declaration_Id);


	}
}
