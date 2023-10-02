using Core.Utilities.Results;
using Entity.Concrete;
using Entity.DTOs;

namespace Business.Abstract
{
    public interface IBrandService
    {
        public IDataResult<List<Brand>> GetAll();
        public IDataResult<Brand> GetById(int id);
        public IResult Add(Brand brand);
        public IResult Update(Brand brand);
        public IResult Delete(int id);

    }
}
