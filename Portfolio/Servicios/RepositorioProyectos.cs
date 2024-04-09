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
                Titulo = "Amazon",
                Descripcion = "E-Comerce realizado en ASP.NET Core",
                Link = "https://amazon.com",
                ImagenURL = "/img/amazon.png"
            },
            new Proyecto
            {
                Titulo = "Reddit",
                Descripcion = "Proyecto realizado en Unity 3D",
                Link = "https://reddit.com",
                ImagenURL = "/img/reddit.png"
            },
            new Proyecto
            {
                Titulo = "NyT",
                Descripcion = "Plataforma de NyT",
                Link = "https://NYT.com",
                ImagenURL = "/img/nyt.png"
            },
            new Proyecto
            {
                Titulo = "Steam",
                Descripcion = "Plataforma de venta de Steam",
                Link = "https://Steam.com",
                ImagenURL = "/img/steam.png"
            }

        };
        }
    }
}
