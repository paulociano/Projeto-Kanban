using ProjetoKanban.Models;
using System.Linq;

namespace ProjetoKanban.Dados
{
    public class DbInitialize
    {
        public static void Initialize(Context context)
        {
            context.Database.EnsureCreated();
            if (!context.Pessoas.Any())
            {
                context.Pessoas.Add(new Pessoa { Nome="Usuário Demo", Email="demo@kanban.local", Senha="demo123", Cargo="Administrador", Bio="Conta local para demonstração do Projeto Kanban.", Github="paulociano" });
                context.SaveChanges();
            }
            if (!context.Projetos.Any())
            {
                context.Projetos.AddRange(
                    new Projeto { Nome="Lançamento do Produto" },
                    new Projeto { Nome="Website Institucional" },
                    new Projeto { Nome="Operação Comercial" }
                );
                context.SaveChanges();
            }
        }
    }
}