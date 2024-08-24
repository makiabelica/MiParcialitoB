namespace MiParcialitoB.CodeFirstModel
{
    public class Estudiante
    {
        public int EstudianteId { get; set; }
        public string Nombre { get; set; }

        // Relación con Inscripciones
        public ICollection<Inscripcion> Inscripciones { get; set; }
    }
}
