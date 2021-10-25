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
        private AulaService _aulaService;

        public AulaController()
        {
            _aulaService = new AulaService();
        }

        //pega aula por id
        [HttpGet("{id}")]
        public Aula Get(int id)
        {
            var aula = _aulaService.GetAula(id);
            return aula;
        }
        //pega aula por id do curso
        [HttpGet("origem/{curso}")]
       /* public List<Aula> GetPorOrigem(string idCurso)
        {
            var aulas = _aulaService.GetAulaPorCurso(idCurso);
            return aulas;
        }*/

        //cadastro de aula
        [HttpPost]
        public async Task<Aula> CadastraAula(Aula aula)
        {
            return await _aulaService.CadastrarAula(aula);
        }

        //deleta aula por id
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAula(int id)
        {
            
            if (AulaExists(id))
            {
                _aulaService.DeleteAula(id);
                return NoContent();
            }
            else
            {
                return NoContent();
            }
        }

        [HttpPut]
        public Aula Update(Aula aula)
        {
            return _aulaService.UpdateCourse(aula);
        }

        private bool AulaExists(int id)
        {
            return _aulaService.GetAula().Any(e => e.Id == id);
        }

    }
}
