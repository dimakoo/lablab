using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kropotova_lab
{
    class Program 
    { 


         static void Main(string[] args)
         {

            //ExceptionTest(); 
            //ExceptionTest2(); 
            //ExceptionTest3()
            //ExceptionTest4()

            Console.ReadKey();
         }
         static void ExceptionTest()
    {
        int x = 5;
        int y = x / 0;
        Console.WriteLine($"Результат: {y}");
        Console.WriteLine("Конец программы");
        Console.Read();
    }
         static void ExceptionTest2()
         {
            try
            {
                Person p = new Person { Name = "Tom", Age = 17 };
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            Console.Read();
        }
         static void ExceptionTest3() 
        {
            try
            {
                TestClass.Method1();
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Catch в Main : {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Блок finally в Main");
            }
            Console.WriteLine("Конец метода Main");
            Console.Read();
        }
         static void ExceptionTest4()
        {
              class TestClass
        
            public static void Method1()
            {
                try
                {
                    Method2();
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine($"Catch в Method1 : {ex.Message}");
                }
                finally
                {
                    Console.WriteLine("Блок finally в Method1");
                }
                Console.WriteLine("Конец метода Method1");
            }
        static void Method2()
        {
            try
            {
                int x = 8;
                int y = x / 0;
            }
            finally
            {
                Console.WriteLine("Блок finally в Method2");
            }
            Console.WriteLine("Конец метода Method2");
            }
        }
    }  
}
