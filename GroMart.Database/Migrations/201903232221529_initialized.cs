namespace GroMart.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialized : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        MainCategory_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.MainCategories", t => t.MainCategory_ID)
                .Index(t => t.MainCategory_ID);
            
            CreateTable(
                "dbo.MainCategories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Name = c.String(),
                        Description = c.String(),
                        Category_ID = c.Int(),
                        MainCategory_ID = c.Int(),
                        SubCategoty_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Categories", t => t.Category_ID)
                .ForeignKey("dbo.MainCategories", t => t.MainCategory_ID)
                .ForeignKey("dbo.SubCategories", t => t.SubCategoty_ID)
                .Index(t => t.Category_ID)
                .Index(t => t.MainCategory_ID)
                .Index(t => t.SubCategoty_ID);
            
            CreateTable(
                "dbo.SubCategories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Category_ID = c.Int(),
                        MainCategory_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Categories", t => t.Category_ID)
                .ForeignKey("dbo.MainCategories", t => t.MainCategory_ID)
                .Index(t => t.Category_ID)
                .Index(t => t.MainCategory_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "SubCategoty_ID", "dbo.SubCategories");
            DropForeignKey("dbo.SubCategories", "MainCategory_ID", "dbo.MainCategories");
            DropForeignKey("dbo.SubCategories", "Category_ID", "dbo.Categories");
            DropForeignKey("dbo.Products", "MainCategory_ID", "dbo.MainCategories");
            DropForeignKey("dbo.Products", "Category_ID", "dbo.Categories");
            DropForeignKey("dbo.Categories", "MainCategory_ID", "dbo.MainCategories");
            DropIndex("dbo.SubCategories", new[] { "MainCategory_ID" });
            DropIndex("dbo.SubCategories", new[] { "Category_ID" });
            DropIndex("dbo.Products", new[] { "SubCategoty_ID" });
            DropIndex("dbo.Products", new[] { "MainCategory_ID" });
            DropIndex("dbo.Products", new[] { "Category_ID" });
            DropIndex("dbo.Categories", new[] { "MainCategory_ID" });
            DropTable("dbo.SubCategories");
            DropTable("dbo.Products");
            DropTable("dbo.MainCategories");
            DropTable("dbo.Categories");
        }
    }
}
