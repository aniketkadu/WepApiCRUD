namespace webapicrud.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class webapiFirst : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.rests",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.rests");
        }
    }
}
