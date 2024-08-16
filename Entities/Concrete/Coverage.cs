

using Core.Entities;

namespace Entities.Concrete
{
	public class Coverage : IEntity
	{
		public int Coverage_Code { get; set; } // Primary Key
		public string Coverage_Network { get; set; }
		public string Coverage_Model { get; set; }
		public decimal Coverage_Amount { get; set; }
		public decimal Premium { get; set; }
		public decimal City_Organization { get; set; }
		public decimal Neighbor_City_Organization { get; set; }
		public decimal Country_Organization { get; set; }
		public int City_Id { get; set; }

		public Coverage()
		{
		}

		public Coverage(
		int coverage_code,
		string coverage_network,
		string coverage_model,
		decimal coverage_amount,
		decimal premium,
		decimal city_organization,
		decimal neighbor_city_organization,
		decimal country_organization,
		int city_id
		)
		{
			Coverage_Code = coverage_code;
			Coverage_Network = coverage_network;
			Coverage_Model = coverage_model;
			Coverage_Amount = coverage_amount;
			Premium = premium;
			City_Organization = city_organization;
			Neighbor_City_Organization = neighbor_city_organization;
			Country_Organization = country_organization;
			City_Id = city_id;
		}
	}
}
