using System;
using Core;


namespace ConsoleInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            var fil = Data.GetFilms();
            Console.WriteLine("Фильмы");
            foreach (var f in fil)
            {
                Console.WriteLine(f.ID_Film + " " + f.Title + " " + f.Country + " " + f.Duration);
            }

            var col = Data.GetCollections();
            Console.WriteLine("Коллекции");
            foreach (var c in col)
            {
                Console.WriteLine(c.ID_Collection + " " + c.Name);
            }

            for (int s = 1; s == 1;)
            {
                Console.WriteLine("Если хотите открыть колллекции введите - 0, если добавить коллекцию - 1, если добавить фильм - 2, если хотите закончить - 3");
                int decision = Convert.ToInt32(Console.ReadLine());
                if (decision == 0)
                {
                    Console.WriteLine("Выберите номер коллекции");
                    int id = Convert.ToInt32(Console.ReadLine());

                    var i = Data.GetFilm_Collections(id);
                    foreach (var a in i)
                    {
                        Console.WriteLine(a.ID_Film + " " + a.Title + " " + a.Country + " " + a.Duration);
                    }

                    Console.WriteLine("Если хотите добавить новый фильм в коллекцию - 0, если удалить фильм из коллекции - 1, а если хотите закончить - 2");
                    decision = Convert.ToInt32(Console.ReadLine());
                    if (decision == 0)
                    {
                        Film_Collection fi_c = new Film_Collection();
                        Console.WriteLine("Введите номер фильма, который хотите добавить в эту коллекцию");
                        fi_c.ID_Film = Convert.ToInt32(Console.ReadLine());
                        fi_c.ID_Collection = id;
                        Data.AddFilm_Collection(fi_c);
                    }
                    else if (decision == 1)
                    {
                        Console.WriteLine("Введите номер фильма, который хотите удалить из этой коллекции");
                        int id_F = Convert.ToInt32(Console.ReadLine());
                        Data.DeleteFilm(id_F, id);
                    }
                    else if (decision == 2)
                    {
                        s++;
                    }
                }
                else if (decision == 1)
                {
                    Console.WriteLine("Введите имя коллекции");
                    Collection collection = new Collection();
                    collection.Name = Console.ReadLine();
                    Data.AddCollection(collection);
                }
                else if (decision == 2)
                {
                    Film f = new Film();
                    Console.WriteLine("Введите имя фильма");
                    f.Title = Console.ReadLine();
                    Console.WriteLine("Введите страну фильма");
                    f.Country = Console.ReadLine();
                    Console.WriteLine("Введите продолжительность фильма в минутах");
                    f.Duration = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите режессера фильма");
                    f.Director = Console.ReadLine();
                    Data.AddFilm(f);
                }
                else if (decision == 3)
                {
                    s++;
                }

            }
        }
    }
}
