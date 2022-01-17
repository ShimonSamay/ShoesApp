namespace SneakersShops.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateExitShoesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ExistShoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Company = c.String(),
                        Gender = c.String(),
                        HasHeels = c.Boolean(nullable: false),
                        AtStock = c.Boolean(nullable: false),
                        Size = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ExistShoes");
        }
    }
}
