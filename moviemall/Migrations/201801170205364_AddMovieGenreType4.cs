namespace moviemall.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovieGenreType4 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.MovieGenres");
            AlterColumn("dbo.MovieGenres", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.MovieGenres", "Id");
            DropColumn("dbo.Movies", "MovieGenreId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "MovieGenreId", c => c.Byte(nullable: false));
            DropPrimaryKey("dbo.MovieGenres");
            AlterColumn("dbo.MovieGenres", "Id", c => c.Byte(nullable: false));
            AddPrimaryKey("dbo.MovieGenres", "Id");
        }
    }
}
