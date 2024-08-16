

using Core.Entities;

namespace Entities.Concrete
{
	public class Declaration:IEntity
	{
		public int Declaration_Id { get; set; }//Primary Key
		public string Declaration_Question { get; set; }
	}
}
