namespace moviemall.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovieGenreType3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MovieGenres", "GenreName", c => c.String());
            DropColumn("dbo.MovieGenres", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MovieGenres", "Name", c => c.String());
            DropColumn("dbo.MovieGenres", "GenreName");
        }
    }
}
