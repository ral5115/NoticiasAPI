using Microsoft.EntityFrameworkCore;
using NoticiasAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoticiasAPI
{
    public class NoticiasDBContext: DbContext
    {

        public NoticiasDBContext(DbContextOptions options): base(options)
        {

        }

        public DbSet<Noticias> Noticia { get; set; }
        public DbSet<Autores> Autor { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new Noticias.Mapeo(modelBuilder.Entity<Noticias>());
            new Autores.Mapeo(modelBuilder.Entity<Autores>());
        }
    }
}
