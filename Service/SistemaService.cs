using Entity;
using Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Service
{
    public class SistemaService
    {
        private SistemaRepository _sistemaRepository;

        public SistemaService()
        {
            _sistemaRepository = new();
        }
        //chama todos os cursos
        public List<Curso> GetCursos()
        {
            try
            {
                var lista = _sistemaRepository.GetAllCurso();
                return lista;

            }
            catch (Exception e)
            {
                return new();
            }

        }

        //chama todas as aulas
        public List<Aula> GetAulas()
        {
            try
            {
                var lista = _sistemaRepository.GetAllAula();
                return lista;

            }
            catch (Exception e)
            {
                return new();
            }

        }

        // chama curso por id
        public Curso GetCurso(string id)
        {
            return _sistemaRepository.GetCursoById(id);
        }


        // chama aula por id
        public Aula GetAula(string id)
        {
            return _sistemaRepository.GetAulaById(id);
        }

        // recebe todas as aula de origem de curso passado por id do curso
        public List<Aula> GetAulaPorCurso(string idCurso)
        {
            return _sistemaRepository.GetAulaPorCurso(idCurso);
        }

        // cadastramento de curso
        public async Task<Curso> CadastrarCurso(Curso curso)
        {
            var cursoResult = await _sistemaRepository.CadastrarCurso(curso);
            return cursoResult;
        }

        //cadastramento de aula
        public async Task<Aula> CadastrarAula(Aula aula)
        {
            var aulaResult = await _sistemaRepository.CadastrarAula(aula);
            return aulaResult;
        }
    }
}
