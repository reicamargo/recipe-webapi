using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApiReceitas.Models
{
    public class Context : DbContext
    {
        public DbSet<Receita> Receitas { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        public Context() : base("Receitas") { }
    }
}