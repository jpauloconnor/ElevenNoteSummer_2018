namespace ElevenNote.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedfoo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Foo",
                c => new
                    {
                        FooID = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.FooID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Foo");
        }
    }
}
