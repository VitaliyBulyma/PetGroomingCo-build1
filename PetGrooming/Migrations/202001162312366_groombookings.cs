namespace PetGrooming.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class groombookings : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GroomBookings",
                c => new
                    {
                        BookingID = c.Int(nullable: false, identity: true),
                        BookingDate = c.DateTime(nullable: false),
                        BookingPrice = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BookingID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.GroomBookings");
        }
    }
}
