using Core.Entities;

namespace Entities.Concrete
{
	public class Policy : IEntity
	{
		public int Policy_No { get; set; }//Primary Key
		public int Insured_No { get; set; }//Foreign Key
		public int Policyholder_No { get; set; }//Foreign Key

		public decimal Amount { get; set; }
		public DateTime Start_Date { get; set; }
		public DateTime End_Date { get; set; }
		public bool Offer_Status { get; set; }
	}
}
