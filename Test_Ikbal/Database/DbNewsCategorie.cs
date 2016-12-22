using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Test_Ikbal.Models;

namespace Test_Ikbal.Database
{
    public class DbNewsCategorie : DbConnection
    {
        public int  Add(NewsCategorie newCategorie )
        {
            DbConnection Connection;
            // pour a creation de la  table 
            // ajouter  dans la base de doné 
            int  result = Connection.insert("Insert into NewsCategorie values ( "+ newCategorie.libelleCategorie + "," + newCategorie.IDCategorieParent +");");

            return result;
        }

        public List<NewsCategorie>  getListCategories(int IDCategorieParent)
        {
            List<NewsCategorie> result = Connection.query("SELECT * FROM NewsCategorie catparent, NewsCategorie catchilds   WHERE catchilds.IDCategorieParent + " + IDCategorieParent + " ;");
            foreach (NewsCategorie newscategorie in result) {

                if (newscategorie.hasChilds() ) /// l'idéé c'est qui parcours tout,  a categorie  les sous categorie et les sous sous categorie 
                {
                    result += getListCategories(newscategorie.IDCategorie);
                }
            }
            return result;
        }
    }

}