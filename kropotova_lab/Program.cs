// подключены какие-то библиотеки
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// namespace такой же как и название проекта
namespace oapLabaDimakoo
{
    // про классы мы пока не говорили...
    class Program
    {
        // точка входа в программу
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Input Nomer: ");
                string InptNomer = Console.ReadLine();
                if (InptNomer.Length == 0)
                    break;
                char[] GosNomerSimb = { 'A', 'B', 'C', 'E', 'H', 'K', 'M', 'O', 'P', 'T', 'X', 'Y' };
                if (InptNomer.Length == 6)
                {
                    var ValidNumber = true;
                    for (int i = 0; i < 6 & ValidNumber; i++)
                    {
                        if (i == 1 | i == 2 | i == 3)
                            ValidNumber &= Char.IsDigit(InptNomer[i]);
                        else
                            ValidNumber &= (InptNomer[i].ToString().IndexOfAny(GosNomerSimb) >= 0);
                    }
                    Console.Write(ValidNumber ? "номер верный\n" : "номер не верный\n");
                }
                else
                {
                    Console.Write("такой номер не существует");

                }
            }
            Console.ReadLine();
        }
    } 
}


