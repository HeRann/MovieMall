namespace moviemall.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AssignValuesMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into MembershipTypes(Id,SignUpFee,DurationInMonths,DiscountRate) values(1,0,0,0)"); // Free
            Sql("Insert into MembershipTypes(Id,SignUpFee,DurationInMonths,DiscountRate) values(2,30,1,10)"); // Monthly
            Sql("Insert into MembershipTypes(Id,SignUpFee,DurationInMonths,DiscountRate) values(3,90,3,15)"); // Quartrly 
            Sql("Insert into MembershipTypes(Id,SignUpFee,DurationInMonths,DiscountRate) values(4,300,12,20)");//Yearly
        }
        
        public override void Down()
        {
        }
    }
}
