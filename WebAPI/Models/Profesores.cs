using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class Profesores
    {
        public Profesores()
        {
            Cursos = new HashSet<Cursos>();
        }

        [Key]
        public int IdProfesor { get; set; }
        public string Nombre { get; set; }

        public ICollection<Cursos> Cursos { get; set; }
    }
}
