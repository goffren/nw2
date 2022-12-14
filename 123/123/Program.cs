using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _123
{
    class Program
    {
        static void Main(string[] args)
        {
            Repeat:
            Console.WriteLine("Цвет - 1; Название ветки - 2");
            int a = Convert.ToInt32(Console.ReadLine());
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("Замоскворецкая", "зеленая");
            dic.Add("зеленая","Замоскворецкая" );
            dic.Add("Сокольническая", "красная");
            dic.Add("красная", "Сокольническая");
            switch(a)
            {
                case 1:
                Console.WriteLine("Введите цвет ветки: ");
                Console.WriteLine(dic[Console.ReadLine()]);
                    break;
                case 2:
                Console.WriteLine("Введите название ветки: ");
                Console.WriteLine(dic[Console.ReadLine()]);
                    break;
                default:
                    Console.WriteLine("Ошибка.");
                    goto Repeat;
            }
        }
    }
}
/* Console.WriteLine("Введите желаемое кол-во элементов: ");
           List<string> ls = new List<string>();
           int c = int.Parse(Console.ReadLine());
           for (int i = 0; i < c; i++)
           {
               string a = Console.ReadLine();
               ls.Add(a);
               string b = Console.ReadLine();
               ls.Add(b);
           }
           foreach (string aPart in ls)
           {
               Console.WriteLine(aPart);
           }*/
