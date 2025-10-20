using System.Collections.Generic;

namespace MDIEstudiante
{
    public class Estudiante
    {
        public string Nombre { get; set; }
        public double Promedio { get; set; }
        public string Carnet { get; set; }
        public List<Asignatura> Asignaturas { get; set; } = new List<Asignatura>();
    }

    public class Asignatura
    {
        public string Nombre { get; set; }
        public double Nota { get; set; }
    }

    public static class DatosCompartidos
    {
        public static Estudiante EstudianteActual { get; set; }
    }
}