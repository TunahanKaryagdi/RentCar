using Core.Utilities.Results;
using Entity.Concrete;

namespace Business.Abstract
{
    public interface IBrandService
    {
        public IDataResult<List<Brand>> GetAll();
    }
}
