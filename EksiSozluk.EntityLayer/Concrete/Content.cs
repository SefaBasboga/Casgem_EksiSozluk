using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksiSozluk.EntityLayer.Concrete
{
    public class Content
    {
     
        public int ContentID { get; set; }
        public string ContentTitle { get; set; }
        public DateTime ContentDate { get; set; }
        public bool ContentStatus { get; set; }

        public int HeadingID { get; set; }
        public  Heading Heading { get; set; }

      
        public AppUser AppUser { get; set; }

    }
}
