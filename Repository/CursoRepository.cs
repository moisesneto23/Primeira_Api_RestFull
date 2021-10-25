using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository
{
    public class CursoRepository
    {
        private SistemaContext _dbContext;

        public CursoRepository()
        {
            _dbContext = new SistemaContext();
        }

        //usado para o delete
        public List<Curso> GetCursos()
        {
            return _dbContext.Cursos.ToList();
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
        

        public Curso GetCursoById(int id)
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
        

        
        //cadastra curso 
        public  Curso CadastrarCurso(Curso curso)
        {
            try
            {

                var result = _dbContext.Add(curso);
                 _dbContext.SaveChanges();

                return result.Entity;

            }
            catch (Exception e)
            {
                return null;
            }

        }
      


       


        // deleta curso precisaria deletar toadas as aulas do curso tambem
        public Curso DeleteCurso(int id)
        {
            try
            {
                var result1 = _dbContext.Cursos.FirstOrDefault(a => a.Id == id);
                
                _dbContext.Remove(result1);
               
                //_dbContext.Remove(result2);
                _dbContext.SaveChangesAsync();
                return result1;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
        public Curso UpdateCourse(Curso course)
        {
            try
            {
                var result = _dbContext.Update(course);
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
