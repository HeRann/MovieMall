namespace moviemall.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovieGenreToDataset : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MovieGenres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Genre = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Movies", "MovieGenre_Id", c => c.Int());
            CreateIndex("dbo.Movies", "MovieGenre_Id");
            AddForeignKey("dbo.Movies", "MovieGenre_Id", "dbo.MovieGenres", "Id");
            DropColumn("dbo.Movies", "MovieGenre_GenreId");
            DropColumn("dbo.Movies", "MovieGenre_Genre");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "MovieGenre_Genre", c => c.String());
            AddColumn("dbo.Movies", "MovieGenre_GenreId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Movies", "MovieGenre_Id", "dbo.MovieGenres");
            DropIndex("dbo.Movies", new[] { "MovieGenre_Id" });
            DropColumn("dbo.Movies", "MovieGenre_Id");
            DropTable("dbo.MovieGenres");
        }
    }
}
