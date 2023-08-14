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
    public class PolicyManager : IPolicyService
    {
        private readonly IPolicyDal _policyDal;

        public PolicyManager(IPolicyDal policyDal)
        {
            _policyDal = policyDal;
        }

        public void TDelete(Policy t)
        {
          _policyDal.Delete(t);
        }

        public Policy TGetById(int id)
        {
           return _policyDal.GetById(id);
        }

        public List<Policy> TGetList()
        {
            return _policyDal.GetList();
        }

        public void TInsert(Policy t)
        {
            _policyDal.Insert(t);
        }

        public void TUpdate(Policy t)
        {
            _policyDal.Update(t);   
        }
    }
}
