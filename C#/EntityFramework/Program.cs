using Microsoft.EntityFrameworkCore;
using System;

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


            }


        }
    }
}
