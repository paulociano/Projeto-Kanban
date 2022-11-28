using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoKanban.Models
{
    [Table("Comentarios")]
    public class Comentario
    {
        public int Id { get; set; }

        public string Conteudo { get; set; }

        public Pessoa Pessoa { get; set; }
    }
}
