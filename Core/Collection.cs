using System;
using System.Collections.Generic;
using System.Text;
using Dapper;
using System.Configuration;


namespace Core
{
    public class Collection     //Можно улучшить: Использовать конструктор экземпляра класса (Мясников, Шакиров)
    {
        public int ID_Collection { get; set; }
        public string Name { get; set; }
    }
}
