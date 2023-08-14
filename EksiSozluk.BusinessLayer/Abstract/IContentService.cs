using EksiSozluk.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksiSozluk.BusinessLayer.Abstract
{
   public interface IContentService : IGenericeService<Content>
    {
        List<Content> GetListByWriter(int id);
        List<Content> GetListByHeadingID(int id);
      
    }
}
