using Core.Utilities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
	public interface IPolicyCoverageService
	{
		Response<List<PolicyCoverage>> getPolicyCoverageList();
		Response<PolicyCoverage> AddPolicyCoverage(PolicyCoverage policyCoverage);
	}
}
