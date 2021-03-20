
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace oap_labs
{
    public class Worker
    {
        public string Surname { get; set; }



        public string Role { get; set; }

        public int Year { get; set; }

        public double Salary { get; set; }

        //public override string ToString() => $"{Initial}, {Surname}, {Role}, {Salary}, {Year}";
    }


    class Program
    {
        static void Main(string[] args, object CarentWorker)
        {
            var WorkerList = new List<Worker>();
            using (TextFieldParser parser = new TextFieldParser(@"data.csv"))
            {
                // свойство TextFieldType определяет тип полей: с разделителями или фиксированной ширины
                parser.TextFieldType = FieldType.Delimited;

                // можно указать произвольный разделитель
                parser.SetDelimiters(",");

                // считываем пока не дойдем до конца файла
                while (!parser.EndOfData)
                {
                    //метод ReadFields разбивает исходную строку на массив строк
                    string[] fields = parser.ReadFields();

                    var newWorker = new Worker();
                    newWorker.Surname = fields[0];
                    newWorker.Role = fields[1];
                    newWorker.Year = Convert.ToInt32( fields[2]);
                    newWorker.Salary = Convert.ToDouble(fields[3]);
                    WorkerList.Add(newWorker);
                }
            }

            Console.WriteLine("стаж работников более 12 лет");
            var FilteredWorkers = WorkerList.Where(W => (DateTime.Now.Year - W.Year) > 12);
            foreach (var CarentWorker in FilteredWorkers)
            {
                Console.WriteLine($"{CarentWorker.Surname}");
            }

            Console.WriteLine("\n\nстаж работников более 12 лет");
            Console.ReadLine();



            Console.WriteLine("зарплата больше 35000");
            var Filteredworkers = WorkerList.Where(W => (W.Salary > 35000));
            foreach (var Carentworker2 in FilteredWorkers)
                Console.WriteLine($"{Carentworker2.Surname}");
            Console.WriteLine("\n\nзарплата больше 35000");
            Console.ReadLine();

        }


    }
}
               



