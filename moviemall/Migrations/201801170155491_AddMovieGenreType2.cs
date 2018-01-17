namespace moviemall.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovieGenreType2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Movies", "MovieGenre_Id", "dbo.MovieGenres");
            DropIndex("dbo.Movies", new[] { "MovieGenre_Id" });
            AddColumn("dbo.MovieGenres", "Name", c => c.String());
            AddColumn("dbo.Movies", "MovieGenreId", c => c.Byte(nullable: false));
            DropColumn("dbo.MovieGenres", "Genre");
            DropColumn("dbo.Movies", "GenreId");
            DropColumn("dbo.Movies", "MovieGenre_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "MovieGenre_Id", c => c.Byte());
            AddColumn("dbo.Movies", "GenreId", c => c.Byte(nullable: false));
            AddColumn("dbo.MovieGenres", "Genre", c => c.String());
            DropColumn("dbo.Movies", "MovieGenreId");
            DropColumn("dbo.MovieGenres", "Name");
            CreateIndex("dbo.Movies", "MovieGenre_Id");
            AddForeignKey("dbo.Movies", "MovieGenre_Id", "dbo.MovieGenres", "Id");
        }
    }
}
