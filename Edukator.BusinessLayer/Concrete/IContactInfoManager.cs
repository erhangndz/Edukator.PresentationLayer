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
    public class IContactInfoManager : IContactInfoService

    {
        private readonly IContactInfoDal _contactInfoDal;

        public IContactInfoManager(IContactInfoDal contactInfoDal)
        {
            _contactInfoDal = contactInfoDal;
        }

        public void TDelete(ContactInfo t)
        {
            _contactInfoDal.Delete(t);  
        }

        public ContactInfo TGetByID(int id)
        {
            return _contactInfoDal.GetByID(id);
        }

        public List<ContactInfo> TGetList()
        {
           return _contactInfoDal.GetList();
        }

        public void TInsert(ContactInfo t)
        {
            _contactInfoDal.Insert(t);
        }

        public void TUpdate(ContactInfo t)
        {
           _contactInfoDal.Update(t);
        }
    }
}
