using Entity;
using Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Service
{
    public class AulaService
    {
        private AulaRepository _aulaRepository;

        public AulaService()
        {
            _aulaRepository = new();
        }
        

        //chama todas as aulas
        public List<Aula> GetAulas()
        {
            try
            {
                var lista = _aulaRepository.GetAllAula();
                return lista;

            }
            catch (Exception e)
            {
                return new();
            }

        }



        // chama aula por id
        public Aula GetAula(int id)
        {
            return _aulaRepository.GetAulaById(id);
        }

        // recebe todas as aula de origem de curso passado por id do curso
        public List<Aula> GetAulaPorCurso(int idCurso)
        {
            return _aulaRepository.GetAulaPorCurso(idCurso);
        }

        

        //cadastramento de aula
        public async Task<Aula> CadastrarAula(Aula aula)
        {
            var aulaResult = await _aulaRepository.CadastrarAula(aula);
            return aulaResult;
        }
        //deletar aula
        public Aula DeleteAula(int id)
        {
            return _aulaRepository.DeleteAula(id);
        }

       
        //serve para usar no delete aula
        public List<Aula> GetAula()
        {
            try
            {
                var lista = _aulaRepository.GetAulas();
                return lista;

            }
            catch (Exception)
            {
                return new();
            }


        }

        public Aula UpdateCourse(Aula aula)
        {
            return _aulaRepository.UpdateAula(aula);
        }
    }
}
