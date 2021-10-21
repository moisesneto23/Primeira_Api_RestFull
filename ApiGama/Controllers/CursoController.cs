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
        private SistemaService _sistemaService;

        public CursoController()
        {
            _sistemaService = new SistemaService();
        }

        
        [HttpGet("{id}")]
        public Curso Get(string id)
        {
            var curso = _sistemaService.GetCurso(id);
            return curso;
        }
        

        //cadastro de curso
        [HttpPost]
        public async Task<Curso> CadastraCurso(Curso curso)
        {
            return await _sistemaService.CadastrarCurso(curso);
        }


    }
}
