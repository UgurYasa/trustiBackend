using Core.Entities;

namespace Entities.Concrete
{
	public class City:IEntity
	{
		public int City_Id { get; set; } // Primary Key
		public string City_Name { get; set; }
	}
}
