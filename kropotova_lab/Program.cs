using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kropotova_lab
{
    /*Class Program
     {
         static void Main(string[] args)
         {
             //ExceptionTest();
             //ExceptionTest2();
             //ExceptionTest3();
             //ExceptionTest4();
             //ExceptionTest5();
             //ExceptionTest6();
             //ExceptionTest7();
             //ExceptionTest8();
             //ExceptionTest9();
             //ExceptionTest10();
             //ExceptionTest11();
             //ExceptionTest12();
             //ExceptionTest13();
             //ExceptionTest14();
             //ExceptionTest15();
             //ExceptionTest16();
             //ExceptionTest17(); 


             Console.ReadKey();
         }

         static void ExceptionTest()
         {
             DriveInfo[] drives = DriveInfo.GetDrives();

             foreach (DriveInfo drive in drives)
             {
                 Console.WriteLine($"Название: {drive.Name}");
                 Console.WriteLine($"Тип: {drive.DriveType}");
                 if (drive.IsReady)
                 {
                     Console.WriteLine($"Объем диска: {drive.TotalSize}");
                     Console.WriteLine($"Свободное пространство: {drive.TotalFreeSpace}");
                     Console.WriteLine($"Метка: {drive.VolumeLabel}");
                 }
                 Console.WriteLine();
             }

         }
         static void ExceptionTest2()
         {
             string dirName = "C:\\";

             if (Directory.Exists(dirName))
             {
                 Console.WriteLine("Подкаталоги:");
                 string[] dirs = Directory.GetDirectories(dirName);
                 foreach (string s in dirs)
                 {
                     Console.WriteLine(s);
                 }
                 Console.WriteLine();
                 Console.WriteLine("Файлы:");
                 string[] files = Directory.GetFiles(dirName);
                 foreach (string s in files)
                 {
                     Console.WriteLine(s);
                 }
             }
         }
         static void ExceptionTest3()
         {
             string path = @"C:\SomeDir";
             string subpath = @"program\avalon";
             DirectoryInfo dirInfo = new DirectoryInfo(path);
             if (!dirInfo.Exists)
             {
                 dirInfo.Create();
             }
             dirInfo.CreateSubdirectory(subpath);
         }
         static void ExceptionTest4()
         {
             string dirName = "C:\\Program Files";

             DirectoryInfo dirInfo = new DirectoryInfo(dirName);

             Console.WriteLine($"Название каталога: {dirInfo.Name}");
             Console.WriteLine($"Полное название каталога: {dirInfo.FullName}");
             Console.WriteLine($"Время создания каталога: {dirInfo.CreationTime}");
             Console.WriteLine($"Корневой каталог: {dirInfo.Root}");
         }
         static void ExceptionTest5()
         {
             string dirName = @"C:\SomeFolder";

             try
             {
                 DirectoryInfo dirInfo = new DirectoryInfo(dirName);
                 dirInfo.Delete(true);
                 Console.WriteLine("Каталог удален");
             }
             catch (Exception ex)
             {
                 Console.WriteLine(ex.Message);
             }

         }
         static void ExceptionTest6()
         {
             string oldPath = @"C:\SomeFolder";
             string newPath = @"C:\SomeDir";
             DirectoryInfo dirInfo = new DirectoryInfo(oldPath);
             if (dirInfo.Exists && Directory.Exists(newPath) == false)
             {
                 dirInfo.MoveTo(newPath);
             }
         }
         static void ExceptionTest7()
         {
             string path = @"C:\apache\hta.txt";
             FileInfo fileInf = new FileInfo(path);
             if (fileInf.Exists)
             {
                 Console.WriteLine("Имя файла: {0}", fileInf.Name);
                 Console.WriteLine("Время создания: {0}", fileInf.CreationTime);
                 Console.WriteLine("Размер: {0}", fileInf.Length);
             }
         }
         static void ExceptionTest8()
         {
             string path = @"C:\apache\hta.txt";
             FileInfo fileInf = new FileInfo(path);
             if (fileInf.Exists)
             {
                 fileInf.Delete();
                 // альтернатива с помощью класса File
                 // File.Delete(path);
             }
         }
         static void ExceptionTest9()
         {
             string path = @"C:\apache\hta.txt";
             string newPath = @"C:\SomeDir\hta.txt";
             FileInfo fileInf = new FileInfo(path);
             if (fileInf.Exists)
             {
                 fileInf.MoveTo(newPath);
                 // альтернатива с помощью класса File
                 // File.Move(path, newPath);
             }
         }
         static void ExceptionTest10()
         {
             string path = @"C:\apache\hta.txt";
             string newPath = @"C:\SomeDir\hta.txt";
             FileInfo fileInf = new FileInfo(path);
             if (fileInf.Exists)
             {
                 fileInf.CopyTo(newPath, true);
                 // альтернатива с помощью класса File
                 // File.Copy(path, newPath, true);
             }
         }
         static void ExceptionTest11()
         {






             // создаем каталог для файла
             string path = @"C:\SomeDir2";
             DirectoryInfo dirInfo = new DirectoryInfo(path);
             if (!dirInfo.Exists)
             {
                 dirInfo.Create();
             }
             Console.WriteLine("Введите строку для записи в файл:");
             string text = Console.ReadLine();

             // запись в файл
             using (FileStream fstream = new FileStream($"{path}\note.txt", FileMode.OpenOrCreate))
             {
                 // преобразуем строку в байты
                 byte[] array = System.Text.Encoding.Default.GetBytes(text);
                 // запись массива байтов в файл
                 fstream.Write(array, 0, array.Length);
                 Console.WriteLine("Текст записан в файл");
             }

             // чтение из файла
             using (FileStream fstream = File.OpenRead($"{path}\note.txt"))
             {
                 // преобразуем строку в байты
                 byte[] array = new byte[fstream.Length];
                 // считываем данные
                 fstream.Read(array, 0, array.Length);
                 // декодируем байты в строку
                 string textFromFile = System.Text.Encoding.Default.GetString(array);
                 Console.WriteLine($"Текст из файла: {textFromFile}");
             }

             Console.ReadLine();
         }
         static async void ExceptionTest12()
         {
             // создаем каталог для файла
             string path = @"C:\SomeDir3";
             DirectoryInfo dirInfo = new DirectoryInfo(path);
             if (!dirInfo.Exists)
             {
                 dirInfo.Create();
             }
             Console.WriteLine("Введите строку для записи в файл:");
             string text = Console.ReadLine();

             // запись в файл
             using (FileStream fstream = new FileStream($"{path}\note.txt", FileMode.OpenOrCreate))
             {
                 byte[] array = System.Text.Encoding.Default.GetBytes(text);
                 // асинхронная запись массива байтов в файл
                 await fstream.WriteAsync(array, 0, array.Length);
                 Console.WriteLine("Текст записан в файл");
             }

             // чтение из файла
             using (FileStream fstream = File.OpenRead($"{path}\note.txt"))
             {
                 byte[] array = new byte[fstream.Length];
                 // асинхронное чтение файла
                 await fstream.ReadAsync(array, 0, array.Length);

                 string textFromFile = System.Text.Encoding.Default.GetString(array);
                 Console.WriteLine($"Текст из файла: {textFromFile}");
             }

             Console.ReadLine();

         }
         static void ExceptionTest13()
         {
             FileStream fstream = null;
             try
             {
                 fstream = new FileStream(@"D:\note3.dat", FileMode.OpenOrCreate);
                 // операции с потоком
             }
             catch (Exception ex)
             {

             }
             finally
             {
                 if (fstream != null)
                     fstream.Close();
             }
         }
         static void ExceptionTest14()
         {
             FileStream fstream = null;
             try
             {
                 fstream = new FileStream(@"D:\note3.dat", FileMode.OpenOrCreate);
                 // операции с потоком
             }
             catch (Exception ex)
             {

             }
             finally
             {
                 if (fstream != null)
                     fstream.Close();
             }
         }
         static void ExceptionTest15()
         {
             string writePath = @"C:\SomeDir\hta.txt";

             string text = "Привет мир!\nПока мир...";
             try
             {
                 using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                 {
                     sw.WriteLine(text);
                 }

                 using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                 {
                     sw.WriteLine("Дозапись");
                     sw.Write(4.5);
                 }
                 Console.WriteLine("Запись выполнена");
             }
             catch (Exception e)
             {
                 Console.WriteLine(e.Message);
             }
         }
         static async void ExceptionTest16()
         {

             {
                 string path = @"C:\SomeDir\hta.txt";

                 try
                 {
                     using (StreamReader sr = new StreamReader(path))
                     {
                         Console.WriteLine(sr.ReadToEnd());
                     }
                     // асинхронное чтение
                     using (StreamReader sr = new StreamReader(path))
                     {
                         Console.WriteLine(value: await sr.ReadToEndAsync());
                     }
                 }
                 catch (Exception e)
                 {
                     Console.WriteLine(e.Message);
                 }
             }
         }
         static void ExceptionTest17()
         {

         }





     }*/
    [Serializable]
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // объект для сериализации
            Person person = new Person("Tom", 29);
            Console.WriteLine("Объект создан");

            // создаем объект BinaryFormatter
            BinaryFormatter formatter = new BinaryFormatter();
            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream("people.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, person);

                Console.WriteLine("Объект сериализован");
            }

            // десериализация из файла people.dat
            using (FileStream fs = new FileStream("people.dat", FileMode.OpenOrCreate))
            {
                Person newPerson = (Person)formatter.Deserialize(fs);

                Console.WriteLine("Объект десериализован");
                Console.WriteLine($"Имя: {newPerson.Name} --- Возраст: {newPerson.Age}");
            }

            Console.ReadLine();
        }
    }
}