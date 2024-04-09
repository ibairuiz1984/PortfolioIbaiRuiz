using System;

namespace Portfolio.Models
{
    public class FormacionViewModel
    {
        public string Titulo { get; set; }
        public string Institucion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public string Descripcion { get; set; }
    }
}
