namespace MiParcialitoB.CodeFirstModel
{
    public class Curso
    {
        public int CursoID { get; set; }
        public string NombreCurso { get; set; }

        // Relación con Inscripciones
        public ICollection<Inscripcion> Inscripciones { get; set; }
    }
}
