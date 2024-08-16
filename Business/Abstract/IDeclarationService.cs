using Core.Utilities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
	public interface IDeclarationService
	{
		Response<List<Declaration>> GetDeclarationList();
		Response<Declaration> GetDeclarationById(int id);
		Response <Declaration> AddDeclaration(Declaration declaration);
		Response<Declaration> DeleteDeclaration(int id);


	}
}
