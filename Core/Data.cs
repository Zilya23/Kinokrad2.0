using System;
using System.Collections.Generic;
using System.Text;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Core
{
    public static class Data
    {
        private static string coonstr = ConfigurationManager.ConnectionStrings["KinoCollection"].ConnectionString;
        private static IDbConnection connection = new SqlConnection(coonstr);
        public static List<Film> GetFilms()
        {
            return connection.Query<Film>("select * from Film").AsList();
        }
        public static List<Collection> GetCollections()
        {
            return connection.Query<Collection>("select * from Collection").AsList();
        }

        public static List<Film> GetFilm_Collections(int id)
        {
            return connection.Query<Film>("select f.Title, f.ID_Film, f.Duration, f.Director, f.Country from [dbo].[Film_Collection] fc" +
                                                        " join [dbo].[Film] f " +
                                                        "on fc.ID_Film = f.ID_Film " +
                                                        " join [dbo].[Collection] c " +
                                                        " on fc.ID_Collection = c.ID_Collection " +
                                                        $"where c.ID_Collection = {id}").AsList();
        }

        public static void AddCollection(Collection collection)
        {
            connection.Query("insert into [dbo].[Collection] ([Name]) " +
                            $"values ('{collection.Name}')");
        }

        public static void UpdateCollection(int id, Collection collection)
        {
            connection.Query($"update [dbo].[Collection] set [Name] = '{collection.Name}' where [ID_Collection] = {id}");
        }

        public static void DeleteCollection(int id)
        {
            connection.Query($"delete [dbo].[Collection] where [ID_Collection] = {id}");
        }

        public static void AddFilm(Film film)
        {
            connection.Query("insert into[dbo].[Film] " +
                            " ([Title], [Country], [Duration], [Director]) " +
                            $"values ('{film.Title}', '{film.Country}', '{film.Duration}', '{film.Director}')");
        }

        public static void UpdateFilm(int id, Film film)
        {
            connection.Query($"update [dbo].[Film] set [Title] = '{film.Title}', [Country] = '{film.Country}', [Duration] = '{film.Duration}', [Director] = '{film.Director}' where [ID_Film] = {id}");
        }

        public static void DeleteFilm(int id_F, int id)
        {
            connection.Query($"delete [dbo].[Film_Collection] where [ID_Film] = {id_F} and [ID_Collection] = {id}");
        }

        public static void AddFilm_Collection(Film_Collection film_Collection)
        {
            connection.Query("insert into[dbo].[Film_Collection] " +
                            " ([ID_Film], [ID_Collection], [Date])" +
                            $"values ('{film_Collection.ID_Film}', '{film_Collection.ID_Collection}', '{DateTime.Now}')");
        }

        public static void DeleteFilm_Collection(int id)
        {
            connection.Query($"delete [dbo].[Film_Collection] where [ID_FC] = {id}");
        }
    }
}
