using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class Cursos
    {
        public Cursos()
        {
            Alumnos = new HashSet<Alumnos>();
        }

        [Key]
        public int IdCurso { get; set; }
        public string Nombre { get; set; }
        public string Ciudad { get; set; }
        public int IdProfesor { get; set; }

        public Profesores Profesor { get; set; }
        public ICollection<Alumnos> Alumnos { get; set; }
    }
}
