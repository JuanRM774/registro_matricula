using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Systema_Registro_Matricula.Data
{
    public class Systema_Registro_MatriculaContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Systema_Registro_MatriculaContext() : base("name=Systema_Registro_MatriculaContext")
        {
        }

        public System.Data.Entity.DbSet<Systema_Registro_Matricula.Models.Alumno> Alumnoes { get; set; }

        public System.Data.Entity.DbSet<Systema_Registro_Matricula.Models.Profesor> Profesors { get; set; }

        public System.Data.Entity.DbSet<Systema_Registro_Matricula.Models.Matricula> Matriculas { get; set; }

        public System.Data.Entity.DbSet<Systema_Registro_Matricula.Models.Curso> Cursoes { get; set; }
    }
}
