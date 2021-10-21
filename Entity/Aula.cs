using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Aula
    {
        public string Id { get; set; }
        public string TituloAula { get; set; }
        public string LinkAula { get; set; }
        public Curso Curso { get; set; }
        public string DescricaoAula { get; set; }
    }
}
