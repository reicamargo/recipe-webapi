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
    public class ReceitaController : ApiController
    {
        // GET: api/Receita
        public IEnumerable<Receita> Get()
        {
            var repository = new ReceitaRepository();
            return repository.ListarReceitas();
        }

        // GET: api/Receita/5
        public Receita Get(int id)
        {
            var repository = new ReceitaRepository();
            return repository.BuscarReceita(id);
        }

        // POST: api/Receita
        public Receita Post([FromBody]Receita Receita)
        {
            var repository = new ReceitaRepository();
            return repository.InserirReceita(Receita);
        }
        
        // DELETE: api/Receita/5
        public void Delete(int id)
        {
            var repository = new ReceitaRepository();
            repository.ExcluirReceita(id);
        }
    }
}
