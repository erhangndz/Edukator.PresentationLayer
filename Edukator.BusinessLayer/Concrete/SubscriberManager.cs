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
    public class SubscriberManager : ISubscriberService
    {
        private readonly ISubscriberDal _subscriberDal;

        public SubscriberManager(ISubscriberDal subscriberDal)
        {
            _subscriberDal = subscriberDal;
        }

        public void TDelete(Subscriber t)
        {
            _subscriberDal.Delete(t);
        }

        public Subscriber TGetByID(int id)
        {
            return _subscriberDal.GetByID(id);  
        }

        public List<Subscriber> TGetList()
        {
            return _subscriberDal.GetList();
        }

        public void TInsert(Subscriber t)
        {
            _subscriberDal.Insert(t);
        }

        public void TUpdate(Subscriber t)
        {
            _subscriberDal.Update(t);
        }
    }
}
