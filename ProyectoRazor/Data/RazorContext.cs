using ProyectoRazor.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProyectoRazor.Data
{
    public class RazorContext : DbContext
    {
        public RazorContext() : base("name=cadenarazor") { }
        public DbSet<Piloto> Pilotos { get; set; }
        public DbSet<Equipo> Equipos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
    }
}