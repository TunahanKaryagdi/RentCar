using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IColorService
    {
        public IDataResult<List<Color>> GetAll();
        public IDataResult<Color> GetById(int id);
        public IResult Add(Color color);
        public IResult Update(Color color);
        public IResult Delete(int id);
    }
}
