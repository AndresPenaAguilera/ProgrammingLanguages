using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    
    public partial class AppCursosContext
    {
        public void AdicionarCurso(Curso curso) 
        {
            Curso.Add(curso);
        }

        public void AdicionarCurso(List<Curso> cursos)
        {
            Curso.AddRange(cursos);
        }


        public void EliminarCurso(int Id)
        {
            Curso cursoEliminar = ConsultarCurso(Id);
            Curso.Remove(cursoEliminar);
        }

        private Curso ConsultarCurso(int Id)
        {
            return Curso.Where(x => x.CursoId == Id).FirstOrDefault();
        }

    }
}
