namespace CRUDSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using System.Data.Entity;
    using Models;

    public partial class initalizeDB : DbMigration
    {
        public override void Up()
        {
        }
        
        public DbSet<Detail> details
        {
            get; set;
        }

        public override void Down()
        {
        }
    }
}
