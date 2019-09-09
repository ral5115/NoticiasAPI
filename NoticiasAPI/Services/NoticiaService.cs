using NoticiasAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoticiasAPI.Services
{
    public class NoticiaService
    {
        private readonly NoticiasDBContext dBContext;
        public NoticiaService(NoticiasDBContext DBContext)
        {
            dBContext = DBContext;
        }

        public Boolean AgregarNoticia(Noticias noticia)
        {
            try
            {
                dBContext.Noticia.Add(noticia);
                dBContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
           
        }
    }
}
