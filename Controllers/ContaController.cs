using Microsoft.AspNetCore.Mvc;
using ProjetoKanban.Dados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoKanban.Controllers
{
    public class ContaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        private Context _context;
        public ContaController(Context context)
        {
            _context = context;
        }
    }
}
