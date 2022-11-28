using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoKanban.Models
{
    [Table(name: "Projetos")]
    public class Projeto
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string Nome { get; set; }

        public virtual Pessoa Lider { get; set; }

        public virtual ICollection<Lista> Listas { get; set; }

        public virtual ICollection<Tarefa> Tarefas { get; set; }

        public string StateConteudo { get; set; }

    }
}
