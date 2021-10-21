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
            return _dbContext.Cursos.ToList();
        }
        public List<Aula> GetAllAula()
        {
            return _dbContext.Aulas.ToList();
        }

        public Curso GetCursoById(string id)
        {
            return _dbContext.Cursos.FirstOrDefault(c => c.Id == id);
        }
        public Aula GetAulaById(string id)
        {
            return _dbContext.Aulas.FirstOrDefault(c => c.Id == id);
        }

        public List<Aula> GetAulaPorCurso(string idCurso)
        {
            return _dbContext.Aulas.Where(aula => aula.Curso.Id == idCurso).ToList();
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
