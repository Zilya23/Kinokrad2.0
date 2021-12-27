using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class Film
    {
        public int ID_Film { get; set; }
        public string Title { get; set; }
        public string Country { get; set; }
        public string Director { get; set; }
        public int Duration { get; set; }
        public string Poster { get; set; }
        public int ID_Collection { get; set; }
    }
    
}
