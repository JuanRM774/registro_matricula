using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Systema_Registro_Matricula.Models
{
    [Table("Alumno", Schema = "dbo")]
    public class Alumno
    {
        [Key]
        public int Id_Alumno { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }

        public virtual ICollection<Matricula> Matriculas { get; set; }
    }
}