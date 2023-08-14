using EksiSozluk.BusinessLayer.Abstract;
using EksiSozluk.DataAccessLayer.Abstract;
using EksiSozluk.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksiSozluk.BusinessLayer.Concrete
{
    public class FollowManager : IFollowService
    {
        private readonly IFollowDal _followDal; //dependencyINCEKT

        public FollowManager(IFollowDal followDal)
        {
            _followDal = followDal;
        }

        public void TDelete(Follow t)
        {
            _followDal.Delete(t);
        }

        public Follow TGetById(int id)
        {
            return _followDal.GetById(id);
        }

        public List<Follow> TGetList()
        {
            return _followDal.GetList();
        }

        public void TInsert(Follow t)
        {
            _followDal.Insert(t);
        }

        public void TUpdate(Follow t)
        {
            _followDal.Update(t);
        }
    }
}
