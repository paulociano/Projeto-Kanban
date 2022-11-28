using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoKanban.Models
{
    [Table(name: "Pessoas")]
    public class Pessoa
    {
        public int Id { set; get; }

        [MaxLength(50)]
        [Required(ErrorMessage = "Campo Nome é obrigatório")]
        public string Nome { set; get; }

        [MaxLength(30)]
        [Required(ErrorMessage = "Campo Email é obrigatório")]
        public string Email { set; get; }

        [MaxLength(8)]
        [Required(ErrorMessage = "Campo Senha é obrigatório")]
        public string Senha { set; get; }
        
        [MaxLength(30)]
        public string Cargo { set; get; }


        public string Bio { get; set; }


        public string Foto { get; set; }


        public string Github { get; set; }

    }
}
