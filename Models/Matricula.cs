using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Systema_Registro_Matricula.Models
{
    [Table("Matricula", Schema = "dbo")]
    public class Matricula
    {
        [Key]
        public int Id_Matricula { get; set; }
        [ForeignKey("Curso")]
        public int Id_Curso { get; set; }
        [ForeignKey("Alumno")]
        public int Id_Alumno { get; set; }

        public virtual Curso Curso { get; set; }
        public virtual Alumno Alumno { get; set; }
            
    }
}