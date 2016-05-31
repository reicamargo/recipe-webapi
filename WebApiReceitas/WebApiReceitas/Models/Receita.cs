using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApiReceitas.Models
{
    [Table("Receitas", Schema = "receita")]
    public class Receita
    {
        public int Id { get; set; }
        public int CategoriaID { get; set; }
        public Categoria Categoria { get; set; }
        [Required]
        public string Titulo { get; set; }
        [Required]
        public string Ingredientes { get; set; }
        [Required]
        public string ModoPreparo { get; set; }
        public bool Ativo { get; set; }

    }
}