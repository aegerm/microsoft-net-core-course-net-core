using System.Globalization;

//Adicionar namespace de acordo com o tipo de extention method que está criando
namespace System
{
    public static class DateTimeExtensions
    {
        public static string ElapsedTime(this DateTime obj) //Extends Methods
        {
            TimeSpan duration = DateTime.Now.Subtract(obj);

            if (duration.TotalHours < 24)
            {
                return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " Horas";
            }

            else
            {
                return duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " Dias";
            }
        }
    }
}