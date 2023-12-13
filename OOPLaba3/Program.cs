using System;
using System.Text;

namespace OOPLaba3_1
{
    internal class Program
    {
        public static int Key = 102;
        static void Main(string[] args)
        {
            // кодіровка
            Console.OutputEncoding = Encoding.UTF8;
            string firstName, lastName, poName;

            Console.Write("Введіть прізвище = ");
            lastName = Console.ReadLine();

            Console.Write("Введіть ім'я = ");
            firstName = Console.ReadLine();

            Console.Write("Введіть по батькові = ");
            poName = Console.ReadLine();

            // довжина рядків  і вивід їх даних
            LenghtString(ref firstName, ref lastName, ref poName);

            // ім'я та кількість літер прізвища
            NameAndLenght(ref firstName, ref lastName);

        }

        static void LenghtString(ref string firstName, ref string lastName, ref string poName)
        {
            Console.WriteLine("Довжина рядків");
            Console.WriteLine($"{firstName} = {firstName.Length}");
            Console.WriteLine($"{lastName} = {lastName.Length}");
            Console.WriteLine($"{poName} = {poName.Length}");
            
            Console.WriteLine($"{lastName} {firstName} {poName}");
            Console.WriteLine("*Студент спеціальності Комп'ютерні науки, другої группи.*\n");
        }

        static void NameAndLenght(ref string fistName, ref string lastName)
        {
            Console.WriteLine($"Ім'я {fistName}\nДовжина прізвища = {lastName.Length}");
            Console.ReadLine();
        }
    }
}
