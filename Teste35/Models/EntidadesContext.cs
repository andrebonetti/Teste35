using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Teste35.Models
{
    public class EntidadesContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
    }
}