

using Core.Entities;

namespace Entities.Concrete
{
	public class Payment:IEntity
	{
		public int Payment_Id { get; set; }//Primary Key
		public int Policy_No { get; set; }//Foreign Key
		public int Customer_No { get; set; }//Foreign Key
		public string Card_No { get; set; }
		public string Cvv { get; set; }
		public DateTime Expiry_Date { get; set; }

	}
}
