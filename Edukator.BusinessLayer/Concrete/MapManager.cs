using Edukator.BusinessLayer.Abstract;
using Edukator.DataAccessLayer.Abstract;
using Edukator.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.BusinessLayer.Concrete
{
    public class MapManager : IMapService
    {
        private readonly IMapDal _mapDal;

        public MapManager(IMapDal mapDal)
        {
            _mapDal = mapDal;
        }

        public void TDelete(Map t)
        {
           _mapDal.Delete(t);
        }

        public Map TGetByID(int id)
        {
            return _mapDal.GetByID(id);
        }

        public List<Map> TGetList()
        {
            return _mapDal.GetList();
        }

        public void TInsert(Map t)
        {
            _mapDal.Insert(t);  
        }

        public void TUpdate(Map t)
        {
           _mapDal.Update(t);
        }
    }
}
