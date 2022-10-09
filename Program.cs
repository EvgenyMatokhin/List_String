using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_String
{
    class Program
    {
        public static void Print(List<string> Automobile)
        {
            foreach (var item in Automobile) //вывод массива
            {
                Console.WriteLine(item);
            }
        }

        static void Main(string[] args)
        {
            List<string> Automobile = new List<string>() //создал массив
            {
                "AUDI",
                "BMW",
                "Porsche",
                "Toyota",
                "Nissan"
            };
                       
            Print(Automobile);

            Automobile.Add("Lada");      // добавили строку
            Console.WriteLine("############");

            Print(Automobile);
            Console.WriteLine("############");

            Console.WriteLine(Automobile.Count); // длинна массива

            Console.WriteLine(Automobile.BinarySearch("BMW")); //индекс элемента в массиве
            Console.WriteLine("############");

            Automobile.Insert(3, "Volvo"); // добавил по индеку строку
            Print(Automobile); 

        }
    }
}
