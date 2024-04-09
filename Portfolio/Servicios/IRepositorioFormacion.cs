using Portfolio.Models;
using System;
using System.Collections.Generic;

namespace Portfolio.Servicios
{
    public interface IRepositorioFormacion
    {
        List<FormacionViewModel> ObtenerFormacion();
    }

    public class RepositorioFormacion : IRepositorioFormacion
    {
        public List<FormacionViewModel> ObtenerFormacion()
        {
            return new List<FormacionViewModel>
            {
                new FormacionViewModel
                {
                    Titulo = "Técnico Superior en Desarrollo de Aplicaciones Web",
                    Institucion = "CIFP Txurdinaga LHII",
                    FechaInicio = new DateTime(2022, 1, 1),
                    FechaFin = new DateTime(2024, 1, 1),
                    Descripcion = "Actualmente estoy cursando el programa de Técnico Superior en Desarrollo de Aplicaciones Web, donde estoy adquiriendo conocimientos en el desarrollo de aplicaciones web utilizando diversas tecnologías como HTML, CSS, JavaScript, ASP.NET, y bases de datos SQL y MongoDB."
                },
                new FormacionViewModel
                {
                    Titulo = "Desarrollo de videojuegos y RV con UNITY 3D",
                    Institucion = "Centro de Estudios Almi",
                    FechaInicio = new DateTime(2022, 1, 1),
                    FechaFin = new DateTime(2022, 4, 1),
                    Descripcion = "Completé un curso de 300 horas en Desarrollo de videojuegos y Realidad Virtual con UNITY 3D. Durante este curso, adquirí habilidades en la creación de entornos interactivos, personajes y mecánicas de juego utilizando la plataforma UNITY 3D."
                },
                new FormacionViewModel
                {
                    Titulo = "Full Stack Javascript",
                    Institucion = "BBK Bootcamp",
                    FechaInicio = new DateTime(2021, 1, 1),
                    FechaFin = new DateTime(2021, 6, 1),
                    Descripcion = "Completé el programa de Full Stack Javascript en BBK Bootcamp, donde adquirí habilidades en el desarrollo web tanto en el front-end como en el back-end. Utilicé tecnologías como Node.js, Express, MongoDB y React para construir aplicaciones web dinámicas y escalables."
                },
                new FormacionViewModel
                {
                    Titulo = "Full Stack Back-end",
                    Institucion = "BBK Bootcamp",
                    FechaInicio = new DateTime(2020, 1, 1),
                    FechaFin = new DateTime(2020, 6, 1),
                    Descripcion = "Participé en el programa de Full Stack Back-end en BBK Bootcamp, donde me enfoqué en el desarrollo del lado del servidor y la gestión de bases de datos. Adquirí habilidades en tecnologías como ASP.NET Core, SQL Server y Entity Framework Core."
                },
                new FormacionViewModel
                {
                    Titulo = "SAP Business One",
                    Institucion = "CIPSA",
                    FechaInicio = new DateTime(2019, 1, 1),
                    FechaFin = new DateTime(2020, 1, 1),
                    Descripcion = "Realicé un curso de SAP Business One en CIPSA, donde adquirí conocimientos en el manejo de este sistema de planificación de recursos empresariales. Aprendí a gestionar procesos de negocio como finanzas, ventas, inventario y producción utilizando SAP Business One."
                },
                new FormacionViewModel
                {
                    Titulo = "Gestión de RRHH",
                    Institucion = "Juan de los Toyos",
                    FechaInicio = new DateTime(2019, 1, 1),
                    FechaFin = new DateTime(2019, 6, 1),
                    Descripcion = "Participé en un curso de Gestión de Recursos Humanos en Juan de los Toyos, donde adquirí conocimientos en reclutamiento, selección, formación y gestión del talento humano. Aprendí estrategias para gestionar eficazmente el capital humano en las organizaciones."
                },
                new FormacionViewModel
                {
                    Titulo = "Contratación laboral ALMI",
                    Institucion = "ALMI",
                    FechaInicio = new DateTime(2019, 1, 1),
                    FechaFin = new DateTime(2019, 6, 1),
                    Descripcion = "Realicé un curso sobre Contratación Laboral impartido por ALMI, donde adquirí conocimientos en los aspectos legales y prácticos relacionados con la contratación de personal en el ámbito laboral. Aprendí sobre los diferentes tipos de contratos, derechos y obligaciones de empleadores y empleados."
                },
                new FormacionViewModel
                {
                    Titulo = "Aplicaciones informáticas de Gestión",
                    Institucion = "Centric Formación",
                    FechaInicio = new DateTime(2009, 1, 1),
                    FechaFin = new DateTime(2009, 6, 1),
                    Descripcion = "Realicé un curso sobre Aplicaciones Informáticas de Gestión con la plataforma Centric en Formación X, donde adquirí habilidades en el uso de este software para la gestión de procesos empresariales como contabilidad, ventas, compras y gestión de inventarios."
                },
                new FormacionViewModel
                {
                    Titulo = "Administración y Finanzas F.P. II",
                    Institucion = "IFPS Ategorri-Tartanga de Erandio",
                    FechaInicio = new DateTime(2004, 1, 1),
                    FechaFin = new DateTime(2006, 6, 1),
                    Descripcion = "Obtuve el título de Administración y Finanzas de nivel II en el IFPS Ategorri-Tartanga de Erandio. Durante este programa de estudios, adquirí conocimientos en áreas como contabilidad, gestión financiera, marketing y recursos humanos, lo que me proporcionó una base sólida para mi desarrollo profesional en el ámbito empresarial."
                }
            };
        }
    }
}
