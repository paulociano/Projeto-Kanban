using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoKanban.Dados;
using ProjetoKanban.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoKanban.Controllers
{
    public class LoginController : Controller
    {
        private Context _context;

        public LoginController(Context context)
        {
            this._context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Logar(Pessoa pessoasModel)
        {
            var LoginValidate = ModelState["Email"];
            var SenhaValidate = ModelState["Senha"];

            if ((LoginValidate != null && !LoginValidate.Errors.Any()) ||
                (SenhaValidate != null && !SenhaValidate.Errors.Any()))
            { //Validações estão OK
                string usuario = pessoasModel.Email;
                string senha = pessoasModel.Senha;
                //Busca objeto no banco de dados

                var usuarioObj = _context.Pessoas.Where(linha =>
                        linha.Email.Equals(usuario) &&
                        linha.Senha.Equals(senha)).FirstOrDefault();

                if (usuarioObj != null)
                {
                    //Usuario existente no banco de dados
                    ViewBag.usuarioLogado = pessoasModel.Nome;

                    HttpContext.Session.
                        SetString("IdUsuarioLogado", usuarioObj.Id.ToString());

                    HttpContext.Session.
                        SetString("NomeUsuarioLogado", usuarioObj.Nome.ToString());

                    HttpContext.Session.
                       SetString("EmailUsuarioLogado", usuarioObj.Email.ToString());

                    if(usuarioObj.Bio is not null)
                    {
                        HttpContext.Session.
                       SetString("BioUsuarioLogado", usuarioObj.Bio.ToString());
                    } else
                    {
                        usuarioObj.Bio = "";
                       HttpContext.Session.
                      SetString("BioUsuarioLogado", usuarioObj.Bio.ToString());
                    }

                    if (usuarioObj.Github is not null)
                    {
                        HttpContext.Session.
                       SetString("GitUsuarioLogado", usuarioObj.Github.ToString());
                    }
                    else
                    {
                        usuarioObj.Github = "";
                        HttpContext.Session.
                       SetString("GitUsuarioLogado", usuarioObj.Github.ToString());
                    }

                    HttpContext.Session.
                       SetString("CargoUsuarioLogado", usuarioObj.Cargo.ToString());

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewBag.ErrorLogin = "Credenciais inválidas";
                    return View("Index");
                }
            }
            else
            {
                return View("Index");
            }
        }
    }
}

