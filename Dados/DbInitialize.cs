using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoKanban.Dados
{
    public class DbInitialize
    {
        public static void Initialize(Context context)
        {
            context.Database.EnsureCreated();
        }
    }
}
