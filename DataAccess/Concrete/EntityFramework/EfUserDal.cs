using Core.DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Core.Entities.Conrete;
using Core.Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, NorthwindContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new NorthwindContext())
            {
                var result = from oC in context.OperationClaims
                join uoC in context.UserOperationClaims on oC.Id equals uoC.OperationClaimId
                where uoC.UserId == user.Id
                select new OperationClaim { Id = oC.Id, Name = oC.Name };
                return result.ToList();
            }
        }
    }
}
