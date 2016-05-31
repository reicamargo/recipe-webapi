namespace WebApiReceitas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SegundaMigracao : DbMigration
    {
        public override void Up()
        {
            MoveTable(name: "dbo.Categorias", newSchema: "receita");
            MoveTable(name: "dbo.Receitas", newSchema: "receita");
            AlterColumn("receita.Categorias", "Titulo", c => c.String(nullable: false));
            AlterColumn("receita.Receitas", "Titulo", c => c.String(nullable: false));
            AlterColumn("receita.Receitas", "Ingredientes", c => c.String(nullable: false));
            AlterColumn("receita.Receitas", "ModoPreparo", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("receita.Receitas", "ModoPreparo", c => c.String());
            AlterColumn("receita.Receitas", "Ingredientes", c => c.String());
            AlterColumn("receita.Receitas", "Titulo", c => c.String());
            AlterColumn("receita.Categorias", "Titulo", c => c.String());
            MoveTable(name: "receita.Receitas", newSchema: "dbo");
            MoveTable(name: "receita.Categorias", newSchema: "dbo");
        }
    }
}
