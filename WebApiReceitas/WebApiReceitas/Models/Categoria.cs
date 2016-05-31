using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApiReceitas.Models
{
    [Table("Categorias", Schema = "receita")]
    public class Categoria
    {
        public int Id { get; set; }
        [Required]
        public string Titulo { get; set; }
        public bool Ativo { get; set; }

        public ICollection<Receita> Receitas { get; set; }

        public Categoria()
        {
            this.Receitas = new List<Receita>();
        }
    }
}