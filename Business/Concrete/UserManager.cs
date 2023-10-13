using Business.Abstract;
using Business.Constants;
using Core.Entity.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        IDataResult<List<OperationClaim>> IUserService.GetClaims(User user)
        {
            var result = _userDal.GetClaims(user);
            if (result !=null)
            {
                return new SuccessDataResult<List<OperationClaim>>(result);
            }
            return new ErrorDataResult<List<OperationClaim>>(Messages.ClaimsCannotListed);
        }

        IResult IUserService.Add(User user)
        {
            _userDal.Add(user);
            return new SuccessResult();
        }

        IDataResult<User> IUserService.GetByMail(string email)
        {
            var result = _userDal.Get(u => u.Email == email);
            if (result != null)
            {
                return new SuccessDataResult<User>(result);
            }
            return new ErrorDataResult<User>(Messages.UserCannotFindByEmail);
        }
    }
}
