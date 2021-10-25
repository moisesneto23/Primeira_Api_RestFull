using Entity;
using Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Service
{
    public class CursoService
    {
        private CursoRepository _cursoRepository;

        public CursoService()
        {
            _cursoRepository = new();
        }

        //chama todos os cursos
        public List<Curso> GetCursos()
        {
            try
            {
                var lista = _cursoRepository.GetAllCursos();
                return lista;

            }
            catch (Exception e)
            {
                return new();
            }

        }

       

        // chama curso por id
        public Curso GetCurso(int id)
        {
            return _cursoRepository.GetCursoById(id);
        }


        

        // cadastramento de curso
        public  Curso CadastrarCurso(Curso curso)
        {
            var cursoResult =  _cursoRepository.CadastrarCurso(curso);
            return cursoResult;
        }

      
        

        //deleta o curso
        public Curso DeleteCurso(int id)
        {
            return _cursoRepository.DeleteCurso(id);
        }

        //serve para deletar curso
        public List<Curso> GetCurso()
        {
            try
            {
                var lista = _cursoRepository.GetCursos();
                return lista;

            }
            catch (Exception)
            {
                return new();
            }

        }

        public Curso UpdateCourse(Curso course)
        {
            return _cursoRepository.UpdateCourse(course);
        }


    }
}
