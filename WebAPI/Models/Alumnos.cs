using System;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class Alumnos
    {
        [Key]
        public int IdAlumno { get; set; }
        public string Nombre { get; set; }
        public DateTime Nacimiento { get; set; }
        public int IdCurso { get; set; }

        public Cursos curso { get; set; }
    }
}
