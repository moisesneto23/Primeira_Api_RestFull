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
    public class AulaController : ControllerBase
    {
        private SistemaService _sistemaService;

        public AulaController()
        {
            _sistemaService = new SistemaService();
        }

        //pega aula por id
        [HttpGet("{id}")]
        public Aula Get(string id)
        {
            var aula = _sistemaService.GetAula(id);
            return aula;
        }
        //pega aula por id do curso
        [HttpGet("origem/{curso}")]
        public List<Aula> GetPorOrigem(string idCurso)
        {
            var aulas = _sistemaService.GetAulaPorCurso(idCurso);
            return aulas;
        }

        //cadastro de aula
        [HttpPost]
        public async Task<Aula> CadastraChocolate(Aula aula)
        {
            return await _sistemaService.CadastrarAula(aula);
        }


    }
}
