using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoKanban.Models
{
    [Table(name: "Listas")]
    public class Lista
    {
        public int Id { get; set; }

        [MaxLength(30)]
        public string Nome { get; set; }

        [MaxLength(7)]
        public string Cor { get; set; }

        public virtual ICollection<Tarefa> Tarefas { get; set; }
    }
}
