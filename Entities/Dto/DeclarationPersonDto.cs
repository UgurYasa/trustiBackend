using Core.Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto
{
	public class DeclarationPersonDto : DeclarationPerson, IDto
	{

		public string declaration_question { get; set; }
		public string firstname { get; set; }
		public string lastname { get; set; }



		public DeclarationPersonDto(
			int DeclarationId,
			int CustomerId,
			string answer,
			string description,
			string declaration_question,

			string firstname,
			string lastname
			) : base(DeclarationId, CustomerId, answer, description)
		{
			this.declaration_question = declaration_question;
			this.firstname = firstname;
			this.lastname = lastname;

		}
	}
}
