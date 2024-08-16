using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto
{
	public class CustomerDto : Customer, IDto
	{
		public string City_Name { get; set; }

        public CustomerDto(int customer_No, string tCKNo, DateTime birth_Date, string first_Name, string last_Name, string email, string phone, string gender, string family_Member, int city_Id, string city_name) :
            base(customer_No, tCKNo, birth_Date, first_Name, last_Name, email, phone, gender, family_Member, city_Id)
        {
            City_Name = city_name;   
        }
	}
}
 