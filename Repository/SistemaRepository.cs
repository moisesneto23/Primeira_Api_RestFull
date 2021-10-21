using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository
{
    public class SistemaRepository
    {
        private SistemaContext _dbContext;

        public SistemaRepository()
        {
            _dbContext = new SistemaContext();
        }


        public List<Curso> GetAllCursos()
        {
            try
            {
                return _dbContext.Cursos.ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
        public List<Aula> GetAllAula()
        {
            try
            {
                return _dbContext.Aulas.ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        public Curso GetCursoById(string id)
        {
            try
            {
                return _dbContext.Cursos.FirstOrDefault(c => c.Id == id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
        public Aula GetAulaById(string id)
        {
            try
            {
                return _dbContext.Aulas.FirstOrDefault(c => c.Id == id);
            }
            catch (Exception e)
            {

                throw e;
            }
            
        }

        public List<Aula> GetAulaPorCurso(string idCurso)
        {
            try
            {

                return _dbContext.Aulas.Where(aula => aula.Curso.Id == idCurso).ToList();
                
            }
            catch (Exception e)
            {

                throw e;
            }
           
        }

        public async Task<Curso> CadastrarCurso(Curso curso)
        {
            try
            {
                var result = await _dbContext.AddAsync(curso);
                await _dbContext.SaveChangesAsync();

                return result.Entity;

            }
            catch (Exception e)
            {
                return null;
            }

        }
        public async Task<Aula> CadastrarAula(Aula aula)
        {
            try
            {
                var result = await _dbContext.AddAsync(aula);
                await _dbContext.SaveChangesAsync();

                return result.Entity;

            }
            catch (Exception e)
            {
                return null;
            }
        }


       
    }
}
