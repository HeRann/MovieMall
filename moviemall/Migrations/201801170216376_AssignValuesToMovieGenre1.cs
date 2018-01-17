namespace moviemall.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AssignValuesToMovieGenre1 : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT MovieGenres ON");
            Sql("Insert into MovieGenres (Id,GenreName) values (1,'Action')");
            Sql("Insert into MovieGenres (Id,GenreName) values (2,'Adventure')");
            Sql("Insert into MovieGenres (Id,GenreName) values (3,'Animation')");
            Sql("Insert into MovieGenres (Id,GenreName) values (4,'Biography')");
            Sql("Insert into MovieGenres (Id,GenreName) values (5,'Comedy')");
            Sql("Insert into MovieGenres (Id,GenreName) values (6,'Crime')");
            Sql("Insert into MovieGenres (Id,GenreName) values (7,'Documentary')");
            Sql("Insert into MovieGenres (Id,GenreName) values (8,'Drama')");
            Sql("Insert into MovieGenres (Id,GenreName) values (9,'Family')");
            Sql("Insert into MovieGenres (Id,GenreName) values (10,'Fantasy')");
            Sql("Insert into MovieGenres (Id,GenreName) values (11,'Film Noir')");
            Sql("Insert into MovieGenres (Id,GenreName) values (12,'History')");
            Sql("Insert into MovieGenres (Id,GenreName) values (13,'Horror')");
            Sql("Insert into MovieGenres (Id,GenreName) values (14,'Music')");
            Sql("Insert into MovieGenres (Id,GenreName) values (15,'Musical')");
            Sql("Insert into MovieGenres (Id,GenreName) values (16,'Mystery')");
            Sql("Insert into MovieGenres (Id,GenreName) values (17,'Romance')");
            Sql("Insert into MovieGenres (Id,GenreName) values (18,'Sci-Fi')");
            Sql("Insert into MovieGenres (Id,GenreName) values (19,'Short')");
            Sql("Insert into MovieGenres (Id,GenreName) values (20,'Sport')");
            Sql("Insert into MovieGenres (Id,GenreName) values (21,'Superhero')");
            Sql("Insert into MovieGenres (Id,GenreName) values (22,'Thriller')");
            Sql("Insert into MovieGenres (Id,GenreName) values (23,'War')");
            Sql("Insert into MovieGenres (Id,GenreName) values (24,'Western')");
        }
        
        public override void Down()
        {
        }
    }
}
