namespace SanaWebShop.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomersAndOrdersTablesAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Address = c.String(),
                        PersonalId = c.String(),
                    })
                .PrimaryKey(t => t.CustomerId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        OrderNumber = c.String(),
                        OrderDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.OrderId)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.ProductsPerOrders",
                c => new
                    {
                        ProductId = c.Int(nullable: false),
                        OrderId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ProductId, t.OrderId })
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.OrderId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductsPerOrders", "ProductId", "dbo.Products");
            DropForeignKey("dbo.ProductsPerOrders", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.Orders", "CustomerId", "dbo.Customers");
            DropIndex("dbo.ProductsPerOrders", new[] { "OrderId" });
            DropIndex("dbo.ProductsPerOrders", new[] { "ProductId" });
            DropIndex("dbo.Orders", new[] { "CustomerId" });
            DropTable("dbo.ProductsPerOrders");
            DropTable("dbo.Orders");
            DropTable("dbo.Customers");
        }
    }
}
