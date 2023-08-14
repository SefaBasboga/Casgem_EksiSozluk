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
    public class HeadingManager : IHeadingService
    {
        IHeadingDal _headingDal;

        public HeadingManager(IHeadingDal headingDal)
        {
            _headingDal = headingDal;
        }

        //public List<Heading> GetListByWriter(int id)
        //{
        //    //return _headingDal.List(x => x.WriterID == id);
        //}


        public List<Heading> GetListByCategory(int id)
        {
            return _headingDal.List(x => x.CategoryID == id);
        }

        public void TDelete(Heading t)
        {
           _headingDal.Delete(t);   
        }

        public Heading TGetById(int id)
        {
           return _headingDal.GetById(id);
        }

        public List<Heading> TGetList()
        {
          return   _headingDal.GetList();
        }

        public void TInsert(Heading t)
        {
            _headingDal.Insert(t);
        }

        public void TUpdate(Heading t)
        {
           _headingDal.Update(t);   
        }
    }
}
