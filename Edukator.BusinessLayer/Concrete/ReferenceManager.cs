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
    public class ReferenceManager : IReferenceService
    {
        private readonly IReferenceDal _referenceDal;

        public ReferenceManager(IReferenceDal referenceDal)
        {
            _referenceDal = referenceDal;
        }

        public void TDelete(Reference t)
        {
            _referenceDal.Delete(t);
        }

        public Reference TGetByID(int id)
        {
            return _referenceDal.GetByID(id);
        }

        public List<Reference> TGetList()
        {
            return _referenceDal.GetList();
        }

        public void TInsert(Reference t)
        {
            _referenceDal.Insert(t);
        }

        public void TUpdate(Reference t)
        {
            _referenceDal.Update(t);
        }
    }
}
