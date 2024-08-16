

using Core.Entities;

namespace Entities.Concrete
{
	public class PolicyCoverage:IEntity
	{
		public int Policy_No { get; set; }
		public int Coverage_Code { get; set; }
		public decimal Amount { get; set; }
		public decimal Prim { get; set; }

	}
}
