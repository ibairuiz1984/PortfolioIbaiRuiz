using Portfolio.Models;

namespace Portfolio.Servicios
{
    public interface IRepositorioProyectos
    {
        List<Proyecto> ObtenerProyectos();
    }
    public class RepositorioProyectos : IRepositorioProyectos
    {

        public List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>(){
            new Proyecto
            {
                Titulo = "CRUD ASP.NET Core",
                Descripcion = "CRUD de películas con base de datos en SQL. Utilicé tecnología ASP.NET Core con C#, JavaScript y HTML + css.",
                Link = "/Home/Enproceso",
                ImagenURL = "/img/CRUD3.png",
                EsPaginaInterna = true
            },
            new Proyecto
            {
                Titulo = "Juego Rubber",
                Descripcion = "Proyecto realizado en Unity 3D para dispositivos móviles",
                Link = "/Home/Rubber",
                ImagenURL = "/img/Rubber2.gif",
                EsPaginaInterna = true
            },
            new Proyecto
            {
                Titulo = "Battleship React",
                Descripcion = "El proyecto está basado en MERN y usamos como lenguaje de programación JavaScript. Además, utilizamos la librería Socket.IO para crear las conexiones entre los jugadores. ",
                Link = "/Home/Battleship",
                ImagenURL = "/img/Battleship.gif",
                EsPaginaInterna = true
            },
            new Proyecto
            {
                Titulo = "El misterio de lezama",
                Descripcion = "App didáctica de Lezama con Android Studio y Kotlin",
                Link = "/Home/Lezama",
                ImagenURL = "/img/lezama.gif",
                EsPaginaInterna = true
            }

        };
        }
    }
}
