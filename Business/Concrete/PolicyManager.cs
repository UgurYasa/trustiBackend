using Business.Abstract;
using Core.Utilities;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
	public class PolicyManager : IPolicyService
	{
		private IPolicyDal _policyDal;
        public PolicyManager(IPolicyDal policyDal)
        {
            _policyDal = policyDal;
        }
        public Response<List<Policy>> GetListPolicy()
		{
			try
			{
				var result = _policyDal.GetList();
				if (result != null)
				{
					return new Response<List<Policy>>().Success(result);
				}
				return new Response<List<Policy>>().Error("Policy Not Found");
			} catch (Exception ex) {
				return new Response<List<Policy>>().Error(ex.Message);
			}
		}
	}
}
