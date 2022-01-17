using System;

namespace API_Interface1
{
    public class WeatherForecast    //Обязательно исправить Класс не относится к теме проекта
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }
}
