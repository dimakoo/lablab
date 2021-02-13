using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kropotova_lab
{
    class Program
    {
        static void Main(string[] agrs)
        {



            //Console.Write("Input number1: ");
            //var number1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Input number2: ");
            //var number2 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Input number3: ");
            //var number3 = Convert.ToDouble(Console.ReadLine());
            //if (number1 >= 0)
            //{
            //   number1 = Math.Pow(number1, 2);
            //}
            //else
            //{
            //   number1 = Math.Pow(number1, 4);
            //}

            //if (number3 >= 0) number3 = Math.Pow(number3, 2);
            //else number3 = Math.Pow(number3, 4);



            //number2 = (number2 >= 0) ? Math.Pow(number2, 2) : Math.Pow(number2, 4);
            //Console.WriteLine($"number2 = {number2}\n number1 ={number1}\n number3 = {number3}" );
            //Console.ReadLine();

            //Console.Write("Input: x1:") ;
            // var x1 = Convert.ToDouble(Console.ReadLine());
            // Console.Write("Input: y1:");
            // var y1 = Convert.ToDouble(Console.ReadLine());
            // Console.Write("Input: x2:");
            // var x2 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Input: y2:");
            //var y2 = Convert.ToDouble(Console.ReadLine());
            //var Dlina1 = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
            //var Dlina2 = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));
            //if (Dlina1 < Dlina2)
            //{
            // Console.WriteLine("Первая точка ближе");
            //}
            //else
            //{
            //  Console.WriteLine("Вторая точка ближе");
            //}
            //            Console.ReadLine();


            //Console.Write("Input:Ugol1:");
            //var Ugol1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Input:Ugol2:");
            //var Ugol2 = Convert.ToDouble(Console.ReadLine());

            //if ((Ugol1 + Ugol2) < 180) 
            //{
            //Console.WriteLine("Треугольник существует");

            //if ((Ugol1 == 90 || Ugol2 == 90 || Ugol1 + Ugol2 == 90))
            //{
            //Console.WriteLine("Треугольник прямоугольный");

            //}

            //else Console.WriteLine("Треугольник непрямоугольный");

            //}
            //else Console.WriteLine("Треугольник несуществует");



           







            Console.Write("Number1: ");
            var Number1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Number2: ");
            var Number2 = Convert.ToDouble(Console.ReadLine());
            var Polusumma = (Number1 + Number2) / 2;
            var Proizvedenie = 2 * (Number1 + Number2);

            if (Number1 < Number2) 
            {
                Number1 = Polusumma;
                Number2 = Proizvedenie;

            }else
            {
                Number2 = Polusumma;
                Number1 = Proizvedenie;
            }
            Console.WriteLine($"Number 1 = {Number1}");
            Console.WriteLine($"Number 2 = {Number2}");



            
            
            
            
            
            
            Console.ReadLine();
        }
    } 
}


