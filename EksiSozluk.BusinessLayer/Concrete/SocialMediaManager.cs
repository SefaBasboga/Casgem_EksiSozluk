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
    public class SocialMediaManager  : ISocialMediaService
    {
        private readonly ISocialMediaDal _socialMediaDal;

        public SocialMediaManager(ISocialMediaDal socialMediaDal)
        {
            _socialMediaDal = socialMediaDal;
        }

        public void TDelete(SocialMedia t)
        {
           _socialMediaDal.Delete(t);   
        }

        public SocialMedia TGetById(int id)
        {
            return _socialMediaDal.GetById(id); 
        }

        public List<SocialMedia> TGetList()
        {
           return _socialMediaDal.GetList();    
        }

        public void TInsert(SocialMedia t)
        {
            _socialMediaDal.Insert(t);
        }

        public void TUpdate(SocialMedia t)
        {
          _socialMediaDal.Update(t);
        }
    }
}
