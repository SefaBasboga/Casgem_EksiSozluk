using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksiSozluk.EntityLayer.Concrete
{
    public class AppUser : IdentityUser<int>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string WriterImage { get; set; }

        public bool WriterStatus { get; set; }
        public List<Heading> Headings { get; set; }
        public List<Content> Contents { get; set; }

    }
}
