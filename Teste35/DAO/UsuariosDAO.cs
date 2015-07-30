using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        public Usuario Busca(int id)
        {
            return db.Usuarios.Where(p => p.Id == id).FirstOrDefault();
        }

        public void Edita(Usuario usuario)
        {
            db.Entry(usuario).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Deleta(Usuario usuario)
        {
            db.Usuarios.Remove(usuario);
            db.SaveChanges();
        }
    }
}