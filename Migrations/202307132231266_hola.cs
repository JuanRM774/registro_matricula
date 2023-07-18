namespace Systema_Registro_Matricula.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hola : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alumno",
                c => new
                    {
                        Id_Alumno = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Telefono = c.String(),
                        Correo = c.String(),
                        Direccion = c.String(),
                    })
                .PrimaryKey(t => t.Id_Alumno);
            
            CreateTable(
                "dbo.Matricula",
                c => new
                    {
                        Id_Matricula = c.Int(nullable: false, identity: true),
                        Id_Curso = c.Int(nullable: false),
                        Id_Alumno = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id_Matricula)
                .ForeignKey("dbo.Alumno", t => t.Id_Alumno, cascadeDelete: true)
                .ForeignKey("dbo.Curso", t => t.Id_Curso, cascadeDelete: true)
                .Index(t => t.Id_Curso)
                .Index(t => t.Id_Alumno);
            
            CreateTable(
                "dbo.Curso",
                c => new
                    {
                        Id_Curso = c.Int(nullable: false, identity: true),
                        Id_Profesor = c.Int(nullable: false),
                        Nombre_Curso = c.String(),
                    })
                .PrimaryKey(t => t.Id_Curso)
                .ForeignKey("dbo.Profesor", t => t.Id_Profesor, cascadeDelete: true)
                .Index(t => t.Id_Profesor);
            
            CreateTable(
                "dbo.Profesor",
                c => new
                    {
                        Id_Profesor = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Telefono = c.String(),
                        Correo = c.String(),
                        Direccion = c.String(),
                    })
                .PrimaryKey(t => t.Id_Profesor);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Matricula", "Id_Curso", "dbo.Curso");
            DropForeignKey("dbo.Curso", "Id_Profesor", "dbo.Profesor");
            DropForeignKey("dbo.Matricula", "Id_Alumno", "dbo.Alumno");
            DropIndex("dbo.Curso", new[] { "Id_Profesor" });
            DropIndex("dbo.Matricula", new[] { "Id_Alumno" });
            DropIndex("dbo.Matricula", new[] { "Id_Curso" });
            DropTable("dbo.Profesor");
            DropTable("dbo.Curso");
            DropTable("dbo.Matricula");
            DropTable("dbo.Alumno");
        }
    }
}
