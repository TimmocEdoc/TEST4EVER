namespace Asignment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StudentDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StudentId = c.String(),
                        Punishment = c.Int(nullable: false),
                        PunishmentDate = c.DateTime(nullable: false),
                        PunishmentType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
        }
    }
}
