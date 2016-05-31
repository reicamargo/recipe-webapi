using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiReceitas.Models;
using WebApiReceitas.Models.Repositories;

namespace WebApiReceitas.Controllers
{
    public class CategoriasController : ApiController
    {
        // GET: api/Categorias
        public IEnumerable<Categoria> Get()
        {
            var repository = new CategoriaRepository();
            return repository.ListarCategorias();
        }

        // GET: api/Categorias/5
        public Categoria Get(int id)
        {
            var repository = new CategoriaRepository();
            return repository.BuscarCategoria(id);
        }

        // POST: api/Categorias
        public Categoria Post([FromBody]Categoria categoria)
        {
            var repository = new CategoriaRepository();
            return repository.InserirCategoria(categoria);
        }
        
        // DELETE: api/Categorias/5
        public void Delete(int id)
        {
            var repository = new CategoriaRepository();
            repository.ExcluirCategoria(id);
        }
    }
}
