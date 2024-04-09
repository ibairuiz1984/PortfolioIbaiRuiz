namespace Portfolio.Models
{
    public class HomeIndexViewModel
    {
        public IEnumerable<Proyecto> Proyectos { get; set; }
        public List<ExperienciaProfesionalViewModel> ExperienciasProfesionales { get; set; }

        public List<FormacionViewModel> Formaciones { get; set; }

    }
}




