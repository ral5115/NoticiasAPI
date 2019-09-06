using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoticiasAPI.Models
{
    public class Autores
    {
        public int AutorID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public class Mapeo
        {

            public Mapeo(EntityTypeBuilder<Autores> mapeoAutores)
            {
                mapeoAutores.HasKey(K => K.AutorID);
            }
        }

    }
}
