using Microsoft.EntityFrameworkCore;
using ProjetoKanban.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoKanban.Dados
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options):base(options) { }

        public DbSet<Pessoa> Pessoas { get; set; }

        public DbSet<Lista> Listas { get; set; }

        public DbSet<Projeto> Projetos { get; set; }

        public DbSet<Tarefa> Tarefas { get; set; }

        public static implicit operator ContextBoundObject(Context v)
        {
            throw new NotImplementedException();
        }
    }
}
