namespace moviemall.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovieGenre : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "MovieGenre_GenreId", c => c.Int(nullable: false));
            AddColumn("dbo.Movies", "MovieGenre_Genre", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "MovieGenre_Genre");
            DropColumn("dbo.Movies", "MovieGenre_GenreId");
        }
    }
}
