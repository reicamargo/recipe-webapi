namespace WebApiReceitas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomizacaoFK : DbMigration
    {
        public override void Up()
        {
            DropIndex("receita.Receitas", new[] { "CategoriaId" });
            CreateIndex("receita.Receitas", "CategoriaID");
        }
        
        public override void Down()
        {
            DropIndex("receita.Receitas", new[] { "CategoriaID" });
            CreateIndex("receita.Receitas", "CategoriaId");
        }
    }
}
