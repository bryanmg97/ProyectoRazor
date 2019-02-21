using ProyectoRazor.Models;
using ProyectoRazor.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoRazor.Controllers
{
    public class HomeController : Controller
    {
        RepositoryRazor repo;
        public HomeController()
        {
            this.repo = new RepositoryRazor();
        }
        // GET: Index
        public ActionResult Index()
        {
            List<Piloto> pilotos = this.repo.GetPilotos();
            return View(pilotos);
        }
        public ActionResult ListaEquiposPilotosCategoria(int idcategoria)
        {
            List<Piloto> pilotos = this.repo.GetPilotosCategoria(idcategoria);
            List<Equipo> equipos = this.repo.GetEquiposCategoria(idcategoria);
            String categoria = this.repo.GetNombreCategoria(idcategoria);
            ViewBag.Pilotos = pilotos;
            ViewBag.Categoria = categoria;
            return View(equipos);
        }
        public ActionResult DetalleEquipo(int idequipo)
        {
            Equipo equipo = this.repo.DetalleEquipo(idequipo);
            List<Piloto> pilotos = this.repo.GetPilotosEquipo(idequipo);
            ViewBag.Equipo = equipo;
            return View(pilotos);
        }
        public ActionResult DetallePiloto(int idpiloto)
        {
            Piloto piloto = this.repo.DetallePiloto(idpiloto);
            String categoria = this.repo.GetNombreCategoria(piloto.Categoria);
            String equipo = this.repo.GetNombreEquipo(piloto.Equipo);
            ViewBag.Categoria = categoria;
            ViewBag.Equipo = equipo;
            return View(piloto);
        }
        [ChildActionOnly]
        public ActionResult _PartialCategorias()
        {
            List<Categoria> categorias = this.repo.GetCategorias();
            return PartialView(categorias);
        }
    }
}