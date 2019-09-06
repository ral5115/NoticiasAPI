using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoticiasAPI.Models
{
    public class Noticias
    {
       
        public int NoticiaID { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string Contenido { get; set; }
        public DateTime Fecha { get; set; }
       public int AutorID { get; set; }
        
        public Autores Autor { get; set; }

        public class Mapeo {

            public Mapeo(EntityTypeBuilder<Noticias> mapeoNoticias)
            {
                mapeoNoticias.HasKey(K => K.NoticiaID);
                mapeoNoticias.HasOne(a => a.Autor);

            }
        }

    }
}
