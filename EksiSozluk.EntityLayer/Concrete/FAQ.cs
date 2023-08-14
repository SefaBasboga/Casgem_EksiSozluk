using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksiSozluk.EntityLayer.Concrete
{
    public class FAQ
    {
        public int FAQID { get; set; }
        public string FAQQuestion { get; set; }
        public string FAQReply { get; set; }
    }
}
