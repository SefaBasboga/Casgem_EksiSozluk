using EksiSozluk.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksiSozluk.BusinessLayer.Abstract
{
    
    public interface IHeadingService  :IGenericeService<Heading>
    {
      //  List<Heading> GetListByWriter(int id);

        List<Heading> GetListByCategory(int id);
    }
}
