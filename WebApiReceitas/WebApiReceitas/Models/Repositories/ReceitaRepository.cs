using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiReceitas.Models.Repositories
{
    public class ReceitaRepository
    {
        private Context context;

        public ReceitaRepository()
        {
            context = new Context();
        }

        public Receita InserirReceita(Receita item)
        {
            context.Receitas.Add(item);
            item.Id = context.SaveChanges();
            return item;
        }

        public List<Receita> ListarReceitas()
        {
            var receitas = context.Receitas.OrderBy(r => r.Titulo).ToList();
            return receitas;
        }

        public Receita BuscarReceita(int id)
        {
            return context.Receitas.Where(r => r.Id == id).FirstOrDefault();
        }

        public void ExcluirReceita(int id)
        {
            var item = this.BuscarReceita(id);
            if (item != null)
            {
                item.Ativo = false;
                context.Receitas.Attach(item);
                context.SaveChanges();
            }
        }
    }
}