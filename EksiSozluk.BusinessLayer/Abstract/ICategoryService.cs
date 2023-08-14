using EksiSozluk.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksiSozluk.BusinessLayer.Abstract
{
   public interface ICategoryService : IGenericeService<Category>
    {
        List<Category> GetActiveCategories();
    }
}
