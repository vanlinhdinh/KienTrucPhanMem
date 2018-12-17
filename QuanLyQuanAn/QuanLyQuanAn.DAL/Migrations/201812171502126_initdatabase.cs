namespace QuanLyQuanAn.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initdatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Account",
                c => new
                    {
                        userName = c.String(nullable: false, maxLength: 50, unicode: false),
                        passWordUser = c.String(nullable: false, maxLength: 50, unicode: false),
                        style = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.userName);
            
            CreateTable(
                "dbo.BillInfo",
                c => new
                    {
                        idBillInfo = c.Int(nullable: false, identity: true),
                        idBill = c.Int(),
                        idFood = c.Int(),
                    })
                .PrimaryKey(t => t.idBillInfo)
                .ForeignKey("dbo.Bill", t => t.idBill)
                .ForeignKey("dbo.Food", t => t.idFood)
                .Index(t => t.idBill)
                .Index(t => t.idFood);
            
            CreateTable(
                "dbo.Bill",
                c => new
                    {
                        idBill = c.Int(nullable: false, identity: true),
                        dateCheckIn = c.DateTime(storeType: "date"),
                        dateCheckOUt = c.DateTime(storeType: "date"),
                        discount = c.Int(),
                        idTable = c.Int(),
                        totalPrice = c.Int(),
                        statusBill = c.Boolean(),
                    })
                .PrimaryKey(t => t.idBill)
                .ForeignKey("dbo.TableFood", t => t.idTable)
                .Index(t => t.idTable);
            
            CreateTable(
                "dbo.TableFood",
                c => new
                    {
                        idTable = c.Int(nullable: false, identity: true),
                        nameTable = c.String(nullable: false, maxLength: 50),
                        statusTable = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.idTable);
            
            CreateTable(
                "dbo.Food",
                c => new
                    {
                        idFood = c.Int(nullable: false, identity: true),
                        nameFood = c.String(nullable: false, maxLength: 50),
                        price = c.Decimal(nullable: false, storeType: "money"),
                        idFoodCategory = c.Int(),
                    })
                .PrimaryKey(t => t.idFood)
                .ForeignKey("dbo.FoodCategory", t => t.idFoodCategory)
                .Index(t => t.idFoodCategory);
            
            CreateTable(
                "dbo.FoodCategory",
                c => new
                    {
                        idFoodCategory = c.Int(nullable: false, identity: true),
                        nameFoodCategory = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.idFoodCategory);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Food", "idFoodCategory", "dbo.FoodCategory");
            DropForeignKey("dbo.BillInfo", "idFood", "dbo.Food");
            DropForeignKey("dbo.Bill", "idTable", "dbo.TableFood");
            DropForeignKey("dbo.BillInfo", "idBill", "dbo.Bill");
            DropIndex("dbo.Food", new[] { "idFoodCategory" });
            DropIndex("dbo.Bill", new[] { "idTable" });
            DropIndex("dbo.BillInfo", new[] { "idFood" });
            DropIndex("dbo.BillInfo", new[] { "idBill" });
            DropTable("dbo.FoodCategory");
            DropTable("dbo.Food");
            DropTable("dbo.TableFood");
            DropTable("dbo.Bill");
            DropTable("dbo.BillInfo");
            DropTable("dbo.Account");
        }
    }
}
