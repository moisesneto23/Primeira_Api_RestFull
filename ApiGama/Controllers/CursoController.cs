using Entity;
using Microsoft.AspNetCore.Mvc;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiGama.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CursoController : ControllerBase
    {
        private CursoService _cursoService;

        public CursoController()
        {
            _cursoService = new CursoService();
        }

        // pega todos os cursos
        [HttpGet]
        public List<Curso> GetAll()
        {
             var cursos= _cursoService.GetCursos();
            return cursos;
        }
        
        
        //pega curso por id
        [HttpGet("{id}")]
        public Curso Get(string id)
        {
            var curso = _cursoService.GetCurso(id);
            return curso;
        }
        

        //cadastro de curso
        [HttpPost]
        public async Task<Curso> CadastraCurso(Curso curso)
        {
            return await _cursoService.CadastrarCurso(curso);
        }

        //deta curso com todas as aulas que ele possui
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCurso(string id)
        {
           
            if (AulaExists(id))
            {
                _cursoService.DeleteCurso(id);
                return NoContent();
            }
            else
            {
                return NoContent();
            }
        }


        private bool AulaExists(string id)
        {
            return _cursoService.GetCurso().Any(e => e.Id == id);
        }

    }
}
