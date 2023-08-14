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
    public class TermsOfUseManager  : ITermsOfUseService
    {
        private readonly ITermsOfUseDal _termsOfUseDal;

        public TermsOfUseManager(ITermsOfUseDal termsOfUseDal)
        {
            _termsOfUseDal = termsOfUseDal;
        }

        public void TDelete(TermsOfUse t)
        {
           _termsOfUseDal.Delete(t);
        }

        public TermsOfUse TGetById(int id)
        {
           return _termsOfUseDal.GetById(id);   
        }

        public List<TermsOfUse> TGetList()
        {
            return _termsOfUseDal.GetList();
        }

        public void TInsert(TermsOfUse t)
        {
            _termsOfUseDal.Insert(t);
        }

        public void TUpdate(TermsOfUse t)
        {
            _termsOfUseDal.Update(t);
        }
    }
}
