using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Угадай_число
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите масксимальное целое число диапозона");

            int range = int.Parse(Console.ReadLine());

            Random random = new Random();

            int randNaumber = random.Next(0,range);

            while (true) {

                Console.WriteLine("\nВедите целое число");
                int number = int.Parse(Console.ReadLine());
                if(number<randNaumber)
                {
                    Console.WriteLine("Число меньше загаданного");

                }
                else if (number > randNaumber)
                {
                    Console.WriteLine("Число больше загаданного");

                }
                else if (number == randNaumber)
                {
                    Console.WriteLine("Вы угадали загаданное число");
                    Console.WriteLine("Для выхода из игры нажмите Enter");
                    Console.WriteLine("Было загадано: " + randNaumber);
                    Console.ReadLine();
                    break;
                
                
                }
            }


        }
    }
}
