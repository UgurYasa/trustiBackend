using Business.Abstract;
using Core.Utilities;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
	public class PolicyCoverageManager : IPolicyCoverageService
	{
		private IPolicyCoverageDal _coverageDal;
		public PolicyCoverageManager(IPolicyCoverageDal coverageDal)
		{
			_coverageDal = coverageDal;
		}

		public Response<PolicyCoverage> AddPolicyCoverage(PolicyCoverage policyCoverage)
		{
			try
			{
				_coverageDal.Add(policyCoverage);
				return new Response<PolicyCoverage>().Success("Başarıyla Eklendi");
			}catch(Exception ex)
			{
				return new Response<PolicyCoverage>().Error(ex.Message);
			}
		}

		public Response<List<PolicyCoverage>> getPolicyCoverageList()
		{
			try {
				var result = _coverageDal.GetList();
				if (result != null)
				{
					return new Response<List<PolicyCoverage>>().Success(result);
				}
				return new Response<List<PolicyCoverage>>().Error("Policy Coverage Data Not Found");
			} catch (Exception ex) {
				return new Response<List<PolicyCoverage>>().Error(ex.Message);
			}
		}
	}
}
