using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Systema_Registro_Matricula.Models
{
    [Table("Profesor", Schema = "dbo")]
    public class Profesor
    {
        [Key]
        public int Id_Profesor { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }

        public virtual ICollection<Curso> Cursos { get; set; }
    }
}