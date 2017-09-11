namespace SanaWebShop.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModelCreation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        ProductNumber = c.String(),
                        Title = c.String(),
                        Price = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.ProductId);
            
            CreateTable(
                "dbo.ProductsPerCategories",
                c => new
                    {
                        ProductId = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ProductId, t.CategoryId })
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.CategoryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductsPerCategories", "ProductId", "dbo.Products");
            DropForeignKey("dbo.ProductsPerCategories", "CategoryId", "dbo.Categories");
            DropIndex("dbo.ProductsPerCategories", new[] { "CategoryId" });
            DropIndex("dbo.ProductsPerCategories", new[] { "ProductId" });
            DropTable("dbo.ProductsPerCategories");
            DropTable("dbo.Products");
            DropTable("dbo.Categories");
        }
    }
}
