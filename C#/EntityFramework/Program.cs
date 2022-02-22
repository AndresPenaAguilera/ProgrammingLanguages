using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var db = new AppCursosContext()) 
            {

                // Uno a uno
                //var cursos = db.Curso.AsNoTracking();

                //foreach (var curso in cursos) 
                //{
                //    Console.WriteLine(curso.Titulo);
                //}

                // Uno a muchos
                /*
                var cursos = db.Curso.Include(p => p.ComentarioLista).AsNoTracking();

                foreach (var curso in cursos) 
                {
                    Console.WriteLine(curso.Titulo);
                    foreach (var comentario in curso.ComentarioLista)
                    {
                        Console.WriteLine(" -" + comentario.ComentarioTexto);
                    }
                    
                }
                */

                // Uno a muchos
                var cursos = db.Curso.Include(ci => ci.InstructorLink).ThenInclude(ci => ci.Instructor);

                foreach (var curso in cursos)
                {
                    Console.WriteLine(curso.Titulo);
                    foreach (var inst in curso.InstructorLink)
                    {
                        Console.WriteLine(" -" + inst.Instructor.Nombre);
                    }

                }

                Curso curso1 = new Curso() {
                    Titulo = "Curso SQL avanzado",
                    Descripcion = "Nuevo curso para alumnos expertos en SQL",
                    FechaPublicacion = DateTime.Now
                };

                List<Curso> cursos2 = new List<Curso>()
                {
                    new Curso() {
                    Titulo = "Curso SQL avanzado 3",
                    Descripcion = "Nuevo curso para alumnos expertos en SQL",
                    FechaPublicacion = DateTime.Now
                    },
                    new Curso() {
                    Titulo = "Curso SQL avanzado 4 ",
                    Descripcion = "Nuevo curso para alumnos expertos en SQL",
                    FechaPublicacion = DateTime.Now
                    }

                };

                db.AdicionarCurso(cursos2);
                db.GuardarCambios();
                


            }


        }
    }
}
