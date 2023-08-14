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
    public class ContactManager : IContactService
    {
        private readonly IContactDal _contactDAL;

        public ContactManager(IContactDal contactDAL)
        {
            _contactDAL = contactDAL;
        }

        public void TDelete(Contact t)
        {
           _contactDAL.Delete(t);   
        }

        public Contact TGetById(int id)
        {
            return _contactDAL.GetById(id);
        }

        public List<Contact> TGetList()
        {
            return _contactDAL.GetList();
        }

        public void TInsert(Contact t)
        {
            _contactDAL.Insert(t);
        }

        public void TUpdate(Contact t)
        {
            _contactDAL.Update(t);
        }
    }
}
