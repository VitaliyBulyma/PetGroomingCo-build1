namespace PetGrooming.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class owners_new : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Owners",
                c => new
                    {
                        OwnerID = c.String(nullable: false, maxLength: 128),
                        OwnerFName = c.String(),
                        OwnerLName = c.String(),
                        OwnerAddress = c.String(),
                        OwnerPhoneWork = c.String(),
                        OwnerPhoneHome = c.String(),
                    })
                .PrimaryKey(t => t.OwnerID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Owners");
        }
    }
}
