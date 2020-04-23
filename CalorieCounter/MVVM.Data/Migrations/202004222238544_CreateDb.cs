namespace MVVM.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Exercise",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Time = c.String(),
                        CalorieBurnt = c.Double(nullable: false),
                        ExerciseType = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.FoodCalorie",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Food = c.String(nullable: false, maxLength: 50),
                        Calorie = c.Double(nullable: false),
                        Time = c.String(),
                        Breakfast = c.Boolean(nullable: false),
                        Lunch = c.Boolean(nullable: false),
                        Dinner = c.Boolean(nullable: false),
                        Snacks = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Water",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        WaterAdded = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Water");
            DropTable("dbo.FoodCalorie");
            DropTable("dbo.Exercise");
        }
    }
}
