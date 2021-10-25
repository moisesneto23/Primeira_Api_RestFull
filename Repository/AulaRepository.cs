using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository
{
    public class AulaRepository
    {
        private SistemaContext _dbContext;

        public AulaRepository()
        {
            _dbContext = new SistemaContext();
        }

        public List<Aula> GetAulas()
        {
            return _dbContext.Aulas.ToList();
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

       
        
        public Aula GetAulaById(int id)
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

        public List<Aula> GetAulaPorCurso(int idCurso)
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
       

        // tem que ajeitar cadastrar aula procurar um metodo que passe só o id do curso
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


        //deleta aula por id
        public Aula DeleteAula(int id)
        {
            try
            {
                var aulaDel = _dbContext.Aulas.FirstOrDefault(a => a.Id == id);
                _dbContext.Remove(aulaDel);
                _dbContext.SaveChangesAsync();
                return aulaDel;
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }

        public Aula UpdateAula(Aula  aula)
        {
            try
            {
                var result = _dbContext.Update(aula);
                _dbContext.SaveChanges();
                return result.Entity;

            }
            catch (Exception e)
            {
                return null;
            }

        }



    }
}
