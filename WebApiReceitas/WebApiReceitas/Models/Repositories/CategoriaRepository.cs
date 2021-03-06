﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApiReceitas.Models.Repositories
{
    public class CategoriaRepository
    {
        private Context context;

        public CategoriaRepository()
        {
            context = new Context();
        }

        public Categoria InserirCategoria(Categoria item)
        {
            context.Categorias.Add(item);
            item.Id = context.SaveChanges();
            return item;
        }

        public ICollection<Categoria> ListarCategorias()
        {
            var categorias = context
                            .Categorias
                            .OrderBy(c => c.Titulo)
                            .ToList();
            return categorias;
        }

        public Categoria BuscarCategoria(int id)
        {
            return context
                .Categorias
                .Where(c => c.Id == id)
                .FirstOrDefault();
        }

        public void ExcluirCategoria(int id)
        {
            var item = this.BuscarCategoria(id);
            if (item != null)
            {
                item.Ativo = false;
                context.Categorias.Attach(item);
                context.SaveChanges();
            }
        }
    }
}