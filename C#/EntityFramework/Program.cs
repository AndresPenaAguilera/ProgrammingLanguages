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
                var cursos = db.Curso.AsNoTracking();

                foreach (var curso in cursos) 
                {
                    Console.WriteLine(curso.Titulo);
                }
            }


        }
    }
}
