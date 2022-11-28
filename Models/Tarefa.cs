using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProjetoKanban.Models
{
    [Table(name: "Tarefas")]
    public class Tarefa
    {   
        public int Id { get; set; }


        public string Nome { get; set; }

        public string Descricao { get; set; }

        [MaxLength(50)]
        public string Status { get; set; }
        

        public virtual Lista Lista { get; set; }

        public virtual ICollection<Pessoa> Pessoas { get; set; }
    }
}
