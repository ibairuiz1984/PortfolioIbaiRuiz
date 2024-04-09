using Portfolio.Models;
using System;
using System.Collections.Generic;

namespace Portfolio.Servicios
{
    public interface IRepositorioExperienciaProfesional
    {
        List<ExperienciaProfesionalViewModel> ObtenerExperienciasProfesionales();
    }

    public class RepositorioExperienciaProfesional : IRepositorioExperienciaProfesional
    {
        public List<ExperienciaProfesionalViewModel> ObtenerExperienciasProfesionales()
        {
            return new List<ExperienciaProfesionalViewModel>
            {
                new ExperienciaProfesionalViewModel
                {
                    Puesto = "Prácticas profesionales (Programación)",
                    Empresa = "Inetum",
                    FechaInicio = new DateTime(2024, 3, 1),
                    FechaFin = new DateTime(2024, 5, 1),
                    Descripcion = "Como practicante profesional en desarrollo web ASP.NET y ciberseguridad en Inetum para el cliente Iberdrola, tuve la oportunidad de participar en proyectos desafiantes que combinaron el desarrollo y mantenimiento de aplicaciones web con un enfoque en la seguridad de la información. Adquirí habilidades y conocimientos valiosos que son fundamentales en el campo de la tecnología de la información y la ciberseguridad."
                },
                new ExperienciaProfesionalViewModel
                {
                    Puesto = "Ayudante de Instrucción (Programación)",
                    Empresa = "Code4Jobs/BBK Bootcamp",
                    FechaInicio = new DateTime(2021, 11, 1),
                    FechaFin = new DateTime(2022, 3, 1),
                    Descripcion = "Como ayudante de instrucción en programación en Code4Jobs/BBK Bootcamp, mi rol consistió en ofrecer tutorías, corregir ejercicios, brindar soporte a profesores y colaborar en la elaboración de material formativo. Esto incluyó trabajar con tecnologías como JavaScript, C#, React, Node, Express y bases de datos relacionales."
                },
                new ExperienciaProfesionalViewModel
                {
                    Puesto = "Administrativo",
                    Empresa = "Jalgi Fundazio Kulturala",
                    FechaInicio = new DateTime(2019, 1, 1),
                    FechaFin = null,
                    Descripcion = "En Jalgi Fundazio Kulturala, desempeño tareas de gestión en una fundación sin ánimo de lucro. Mi trabajo implica gestionar subvenciones, permisos, contratación de personal y coordinación de eventos culturales. Además, participo en proyectos de desarrollo comunitario y colaboro con otros departamentos para garantizar el buen funcionamiento de la organización."
                },
                new ExperienciaProfesionalViewModel
                {
                    Puesto = "Administrativo de RRHH",
                    Empresa = "Residencia Bizkotxalde",
                    FechaInicio = new DateTime(2020,6, 1),
                    FechaFin = new DateTime(2020,9, 1),
                    Descripcion = "En Residencia Bizkotxalde, mi labor como administrativo de RRHH implica gestionar los aspectos administrativos relacionados con el personal. Esto incluye el reclutamiento, la gestión de nóminas y beneficios, el mantenimiento de registros de empleados y la coordinación de actividades de capacitación."
                },
                new ExperienciaProfesionalViewModel
                {
                    Puesto = "Consultor/Seleccionador de RRHH",
                    Empresa = "Grupo Temporing ETT",
                    FechaInicio = new DateTime(2019, 6, 1),
                    FechaFin = new DateTime(2020, 1, 1),
                    Descripcion = "En Grupo Temporing ETT, mi función como consultor y seleccionador de RRHH consistía en reclutar y seleccionar profesionales para el sector industrial y tecnológico. Esto incluía la identificación de perfiles adecuados, la realización de entrevistas y la gestión de procesos de selección."
                },
                new ExperienciaProfesionalViewModel
                {
                    Puesto = "Administrador/Director académico",
                    Empresa = "Escuela de Cine del País Vasco",
                    FechaInicio = new DateTime(2012, 1, 1),
                    FechaFin = new DateTime(2019, 6, 1),
                    Descripcion = "En la Escuela de Cine del País Vasco, tuve el cargo de director académico y administrador. Fui responsable de la gestión académica del centro, incluida la elaboración de planes de estudios, la gestión de recursos humanos y la administración general de la empresa."
                },
                new ExperienciaProfesionalViewModel
                {
                    Puesto = "Agente financiero y de seguros",
                    Empresa = "MAPFRE",
                    FechaInicio = new DateTime(2009, 1, 1),
                    FechaFin = new DateTime(2012, 1, 1),
                    Descripcion = "Como agente financiero y de seguros en MAPFRE, brindé asesoramiento financiero y de seguros a clientes individuales y comerciales. Me encargué de evaluar las necesidades financieras y de seguros de los clientes y recomendar los productos y servicios adecuados."
                },
                new ExperienciaProfesionalViewModel
                {
                    Puesto = "Administrativo de Proceso de datos",
                    Empresa = "TASAI",
                    FechaInicio = new DateTime(2006, 12, 1),
                    FechaFin = new DateTime(2008, 1, 1),
                    Descripcion = "En TASAI, participé en el proceso de datos de la empresa del parque tecnológico Técnicas Avanzadas en Sistemas de Ayuda a la Información. Esto incluyó la entrada y procesamiento de datos, así como tareas administrativas relacionadas con la gestión de la información."
                },
                new ExperienciaProfesionalViewModel
                {
                    Puesto = "Administrativo",
                    Empresa = "Bikar Motor BMW-MINI",
                    FechaInicio = new DateTime(2006, 1, 1),
                    FechaFin = new DateTime(2006, 12, 1),
                    Descripcion = "En Bikar Motor BMW-MINI, mi trabajo como administrativo de taller y concesionario de vehículos de alta gama implicaba llevar a cabo tareas administrativas relacionadas con la gestión del taller y la atención al cliente."
                },
                // Agrega el resto de tu experiencia profesional aquí
            };
        }
    }
}
