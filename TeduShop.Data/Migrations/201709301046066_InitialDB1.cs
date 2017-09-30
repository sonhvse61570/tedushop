namespace TeduShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDB1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "CreatedDate", c => c.DateTime());
            AddColumn("dbo.Products", "MetaDescription", c => c.String(maxLength: 256));
            AddColumn("dbo.ProductCategories", "CreatedDate", c => c.DateTime());
            AddColumn("dbo.ProductCategories", "MetaDescription", c => c.String(maxLength: 256));
            AddColumn("dbo.Pages", "CreatedDate", c => c.DateTime());
            AddColumn("dbo.Pages", "MetaDescription", c => c.String(maxLength: 256));
            AddColumn("dbo.PostCategories", "CreatedDate", c => c.DateTime());
            AddColumn("dbo.PostCategories", "MetaDescription", c => c.String(maxLength: 256));
            AddColumn("dbo.Posts", "CreatedDate", c => c.DateTime());
            AddColumn("dbo.Posts", "MetaDescription", c => c.String(maxLength: 256));
            DropColumn("dbo.Products", "CreateDate");
            DropColumn("dbo.Products", "MeteDescription");
            DropColumn("dbo.ProductCategories", "CreateDate");
            DropColumn("dbo.ProductCategories", "MeteDescription");
            DropColumn("dbo.Pages", "CreateDate");
            DropColumn("dbo.Pages", "MeteDescription");
            DropColumn("dbo.PostCategories", "CreateDate");
            DropColumn("dbo.PostCategories", "MeteDescription");
            DropColumn("dbo.Posts", "CreateDate");
            DropColumn("dbo.Posts", "MeteDescription");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Posts", "MeteDescription", c => c.String(maxLength: 256));
            AddColumn("dbo.Posts", "CreateDate", c => c.DateTime());
            AddColumn("dbo.PostCategories", "MeteDescription", c => c.String(maxLength: 256));
            AddColumn("dbo.PostCategories", "CreateDate", c => c.DateTime());
            AddColumn("dbo.Pages", "MeteDescription", c => c.String(maxLength: 256));
            AddColumn("dbo.Pages", "CreateDate", c => c.DateTime());
            AddColumn("dbo.ProductCategories", "MeteDescription", c => c.String(maxLength: 256));
            AddColumn("dbo.ProductCategories", "CreateDate", c => c.DateTime());
            AddColumn("dbo.Products", "MeteDescription", c => c.String(maxLength: 256));
            AddColumn("dbo.Products", "CreateDate", c => c.DateTime());
            DropColumn("dbo.Posts", "MetaDescription");
            DropColumn("dbo.Posts", "CreatedDate");
            DropColumn("dbo.PostCategories", "MetaDescription");
            DropColumn("dbo.PostCategories", "CreatedDate");
            DropColumn("dbo.Pages", "MetaDescription");
            DropColumn("dbo.Pages", "CreatedDate");
            DropColumn("dbo.ProductCategories", "MetaDescription");
            DropColumn("dbo.ProductCategories", "CreatedDate");
            DropColumn("dbo.Products", "MetaDescription");
            DropColumn("dbo.Products", "CreatedDate");
        }
    }
}
