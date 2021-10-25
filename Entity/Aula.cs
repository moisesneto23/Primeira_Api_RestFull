using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Aula
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Curso")]
        public int CursoId { get; set; }
        public virtual Curso? Curso { get; set; }
        public string TituloAula { get; set; }
        public string LinkAula { get; set; }
        public string DescricaoAula { get; set; }
    }
}
