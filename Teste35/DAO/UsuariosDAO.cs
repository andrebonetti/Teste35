using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Teste35.Models;

namespace Teste35.DAO
{
    public class UsuariosDAO
    {
        EntidadesContext db = new EntidadesContext();

        public IList<Usuario> Lista()
        {
            return db.Usuarios.ToList();
        }

        public void Adiciona(Usuario usuario)
        {
            db.Usuarios.Add(usuario);
            db.SaveChanges();
        }
    }
}