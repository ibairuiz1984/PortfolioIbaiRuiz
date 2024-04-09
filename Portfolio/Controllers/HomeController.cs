using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;
using Portfolio.Servicios;
using System;
using System.Diagnostics;
using System.Linq;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepositorioProyectos _repositorioProyectos;
        private readonly IRepositorioExperienciaProfesional _repositorioExperienciaProfesional;
        private readonly IRepositorioFormacion _repositorioFormacion;


        public HomeController(ILogger<HomeController> logger, IRepositorioProyectos repositorioProyectos, IRepositorioExperienciaProfesional repositorioExperienciaProfesional, IRepositorioFormacion repositorioFormacion)
        {
            _logger = logger;
            _repositorioProyectos = repositorioProyectos;
            _repositorioExperienciaProfesional = repositorioExperienciaProfesional;
            _repositorioFormacion = repositorioFormacion;
        }

        public IActionResult Index()
        {
            var persona = new Persona("Ibai Ruiz Bretos", new DateTime(1984, 9, 16));

            var proyectos = _repositorioProyectos.ObtenerProyectos().Take(3).ToList();
            var experienciasProfesionales = _repositorioExperienciaProfesional.ObtenerExperienciasProfesionales();

            var homeIndexViewModel = new HomeIndexViewModel()
            {
                Proyectos = proyectos,
                ExperienciasProfesionales = experienciasProfesionales
            };

            var indexViewModel = new IndexViewModel()
            {
                Persona = persona,
                HomeIndexViewModel = homeIndexViewModel
            };

            return View(indexViewModel);
        }

        public IActionResult Proyectos()
        {
            var proyectos = _repositorioProyectos.ObtenerProyectos();
            return View(proyectos);
        }
        public IActionResult ExperienciaProfesional()
        {
            var experiencias = _repositorioExperienciaProfesional.ObtenerExperienciasProfesionales();

            var homeIndexViewModel = new HomeIndexViewModel()
            {
                ExperienciasProfesionales = experiencias
            };

            return View(homeIndexViewModel);
        }
        public IActionResult Formacion()
        {
            var formaciones = _repositorioFormacion.ObtenerFormacion();

            var homeIndexViewModel = new HomeIndexViewModel()
            {
                Formaciones = formaciones
            };

            return View(homeIndexViewModel);
        }



        public IActionResult Contacto()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contacto(Contacto contacto)
        {
            return RedirectToAction("Gracias");
        }

        public IActionResult Gracias()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
