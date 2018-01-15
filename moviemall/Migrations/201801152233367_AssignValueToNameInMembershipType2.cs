namespace moviemall.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AssignValueToNameInMembershipType2 : DbMigration
    {
        public override void Up()
        {
            Sql("Update MembershipTypes Set Name = 'Pay as You Go' where Id =1");
        }
        
        public override void Down()
        {
        }
    }
}
