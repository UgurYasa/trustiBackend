using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
	public class DeclarationPerson : IEntity
	{
		public int Declaration_Id { get; set; }
		public int Customer_No { get; set; }
		public string Answer { get; set; }
		public string Description { get; set; }
        public DeclarationPerson()
        {
            
        }
        public DeclarationPerson(
			int declaration_Id,
			int customer_no,
			string answer,
			string description
			)
		{
			Declaration_Id = declaration_Id;
			Customer_No = customer_no;
			Answer = answer;
			Description = description;
		}

	}
}
