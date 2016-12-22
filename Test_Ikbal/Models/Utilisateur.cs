using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test_Ikbal.Models
{
    public class Utilisateur
    {
        public int IDUtilisateur { get; set; }
        public string Login { get; set; }
        public string Pass { get; set; }
        public string Nom { get; set; }
        public string PreNom { get; set; }
        public string Telephone { get; set; }
        public bool Mail { get; set; }
    }

}