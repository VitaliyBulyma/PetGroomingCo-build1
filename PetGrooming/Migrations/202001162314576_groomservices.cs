namespace PetGrooming.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class groomservices : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GroomServices",
                c => new
                    {
                        ServiceID = c.Int(nullable: false, identity: true),
                        ServiceName = c.String(),
                        ServiceCost = c.Int(nullable: false),
                        ServiceDuration = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ServiceID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.GroomServices");
        }
    }
}
