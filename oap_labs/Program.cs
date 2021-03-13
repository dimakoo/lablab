// подключены какие-то библиотеки
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace oap_labs
{
    class Program
    {
        static void Main(string[] args)
        {
            var MassivDate = new
                List<DateTime>()
        {
            new DateTime (2021, 1, 15),
            new DateTime (2021, 2, 20),
            new DateTime (2011, 8, 2),
            new DateTime (2015, 6, 1),
            new DateTime (2013, 4, 3),
            new DateTime (2020, 8, 17) };
            var result = new Dictionary<int, int>();
            foreach (DateTime TekushayaData in MassivDate)
            {
                if (result.ContainsKey(TekushayaData.Month))
                {
                    result[TekushayaData.Month] = result[TekushayaData.Month] + 1;
                }
                else result[TekushayaData.Month] = 1;
            }
            var PopularMonth = -1;
            var MaxCount = 0;
            foreach (KeyValuePair<int, int> keyValue in result)
            {
                if (keyValue.Value > MaxCount)
                {
                    MaxCount = keyValue.Value;
                    PopularMonth = keyValue.Key;
                }
            }
        
        Console.WriteLine($"популярный месяц {PopularMonth}");
            Console.Write("Press ENTER to countinue...");
            Console.ReadLine();
        }
    }
}
//первая задача выполнена
