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
    public class AdminMessageManager : IAdminMessageService
    {
        private readonly IAdminMessageDal _adminMessageDal;

        public AdminMessageManager(IAdminMessageDal adminMessageDal)
        {
            _adminMessageDal = adminMessageDal;
        }

        public void TDelete(AdminMessage t)
        {
           _adminMessageDal.Delete(t);
        }

        public AdminMessage TGetById(int id)
        {
           return _adminMessageDal.GetById(id);
        }

        public List<AdminMessage> TGetList()
        {
            return _adminMessageDal.GetList();
        }

        public void TInsert(AdminMessage t)
        {
          _adminMessageDal.Insert(t);
        }

        public void TUpdate(AdminMessage t)
        {
            _adminMessageDal.Update(t);
        }
    }
}
