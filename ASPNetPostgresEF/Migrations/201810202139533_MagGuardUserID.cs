namespace ASPNetPostgresEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MagGuardUserID : DbMigration
    {
        public override void Up()
        {            
            AddColumn("public.AspNetUsers", "MagGuardUserID", c => c.Int(nullable: false));
            CreateIndex("public.AspNetUsers", "MagGuardUserID");
            AddForeignKey("public.AspNetUsers", "MagGuardUserID", "public.users", "id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("public.AspNetUsers", "MagGuardUserID", "public.users");
            DropIndex("public.AspNetUsers", new[] { "MagGuardUserID" });
            DropColumn("public.AspNetUsers", "MagGuardUserID");
            DropTable("public.users");
        }
    }
}
