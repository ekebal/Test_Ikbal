using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Test_Ikbal.Models
{
    public class NewsContenu
    {
        public int IDNews { get; set; }
        public int IDAuteur { get; set; }
        public int IDCategorie { get; set; }
        public DateTime Date { get; set; }
        public string Sujet { get; set; }
        public string Message { get; set; }
        public int EtatVisible { get; set; }
    }
}