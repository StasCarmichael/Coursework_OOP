using System.Text.RegularExpressions;

namespace BLL.RegEx
{
   public static class RegExpressions
    {
        public static readonly Regex Name = new Regex("[a-zA-Zа-яА-ЯіїІЇйЙ]{1,100}");
        public static readonly Regex Surname = new Regex("[a-zA-Zа-яА-ЯіїІЇйЙ]{1,100}");

        public static bool Age(int age) { if (age >= 0 && age < 140) { return true; } else { return false; } }
      

        public static readonly Regex NumberOfPassport = new Regex("[0-9]{9}");
        public static readonly Regex NumberOfRoute = new Regex("[A-Z]{2}[0-9]{4}");
    }
}
