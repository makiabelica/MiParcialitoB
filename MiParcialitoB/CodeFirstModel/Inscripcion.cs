﻿namespace MiParcialitoB.CodeFirstModel
{
    public class Inscripcion
    {
        public int EstudianteID { get; set; }
        public Estudiante Estudiante { get; set; }

        public int CursoID { get; set; }
        public Curso Curso { get; set; }
    }
}
