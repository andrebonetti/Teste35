using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Teste35.DAO;
using Teste35.Models;

namespace Teste35.Controllers
{
    public class UsuariosController : Controller
    {
        UsuariosDAO dao = new UsuariosDAO();

        // GET: Usuarios
        public ActionResult Index()
        {
            IList<Usuario> usuarios = dao.Lista();
            return View(usuarios);
        }

        [HttpPost]
        public ActionResult Adiciona(Usuario usuario)
        {
            dao.Adiciona(usuario);
            return RedirectToAction("index");
        }

        public ActionResult FormularioEdita(int id)
        {
            Usuario usuario = dao.Busca(id);
            return View(usuario);
        }

        [HttpPost]
        public ActionResult Edita(Usuario usuario)
        {
            dao.Edita(usuario);
            return RedirectToAction("index");
        }

        public ActionResult Deleta(int id)
        {
            Usuario usuario = dao.Busca(id);
            dao.Deleta(usuario);
            return RedirectToAction("index");
        }
    }
}