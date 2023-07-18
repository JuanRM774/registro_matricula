using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Systema_Registro_Matricula.Models
{
    [Table("Curso", Schema = "dbo")]
    public class Curso
    {
        [Key]
        public int Id_Curso { get; set; }
        [ForeignKey ("Profesor")]
        public int Id_Profesor { get; set; }
        public string Nombre_Curso { get; set; }

        public virtual ICollection<Matricula> Matriculas { get; set; }
        public virtual Profesor Profesor { get; set; }
    }
}