using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Test_Ikbal.Models
{
    public class NewsCategorie
    {
        public int IDCategorie { get; set; }
        public int libelleCategorie { get; set; }
        public int IDCategorieParent { get; set; }
    }

  
}

