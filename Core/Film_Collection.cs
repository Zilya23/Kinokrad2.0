using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class Film_Collection    //Можно улучшить: Не соответствует стандарту наименования классов :: Шакиров
    {
        public int ID_FC { get; set; }
        public int ID_Film { get; set; }
        public int ID_Collection { get; set; }
        public DateTime Date { get; set; }

    }
}
