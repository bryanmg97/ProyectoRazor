using ProyectoRazor.Data;
using ProyectoRazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoRazor.Repositories
{
    public class RepositoryRazor
    {
        RazorContext context;
        public RepositoryRazor()
        {
            this.context = new RazorContext();
        }
        public List<Categoria> GetCategorias()
        {
            var consulta = from datos in this.context.Categorias select datos;
            return consulta.ToList();
        }  
        public String GetNombreEquipo(int idequipo)
        {
            var consulta = from datos in this.context.Equipos where datos.IdEquipo == idequipo select datos.Nombre;
            return consulta.FirstOrDefault();
        }
        public Piloto DetallePiloto(int idpiloto)
        {
            var consulta = from datos in this.context.Pilotos where datos.IdPiloto == idpiloto select datos;
            return consulta.FirstOrDefault();
        }
        public String GetNombreCategoria(int idcategoria)
        {
            var consulta = from datos in this.context.Categorias where datos.IdCategoria == idcategoria select datos.Nombre;
            return consulta.FirstOrDefault();
        }
        public List<Equipo> GetEquiposCategoria(int idcategoria)
        {
            var consulta = from datos in this.context.Equipos where datos.Categoria == idcategoria select datos;
            return consulta.ToList();
        }
        public List<Piloto> GetPilotosCategoria(int idcategoria)
        {
            var consulta = from datos in this.context.Pilotos where datos.Categoria == idcategoria select datos;
            return consulta.ToList();
        }
        public List<Piloto> GetPilotos()
        {
            var consulta = from datos in this.context.Pilotos select datos;
            return consulta.ToList();
        }
        public List<Piloto> GetPilotosEquipo(int idequipo)
        {
            var consulta = from datos in this.context.Pilotos where datos.Equipo == idequipo select datos;
            return consulta.ToList();
        }
        public Equipo DetalleEquipo(int idequipo)
        {
            var consulta = from datos in this.context.Equipos where datos.IdEquipo == idequipo select datos;
            return consulta.FirstOrDefault();
        }      
        public void EliminarPiloto(int idpiloto)
        {
            Piloto piloto = this.DetallePiloto(idpiloto);
            this.context.Pilotos.Remove(piloto);
            this.context.SaveChanges();
        }
    }
}