<table style="width: 100%;">
  <tr>
    <td style="text-align: center; border: none;">
    Министерство образования и науки РФ<br>
Государственное бюджетное профессиональное образовательное учреждение Республики Марий Эл<br>
Йошкар-Олинский технологический колледж
</td>
  </tr>
  <tr>
    <td style="text-align: center; border: none; height: 15em;">
    <h2 style="font-size:3em;">Отчет</h2>
      <h3>по лабораторной работе<br><br> по дисциплине "Основы алгоритмизации и программирования"<br><br> Тема:<b>"Работа с потоками и файловой системой."<b> </h3></td>
  </tr>
  <tr>
    <br><br><td style="text-align: right; border: none; height: 20em;">
      Разработала:<br/>
      Кропотова Юлия<br>
      Группа: И-21<br>
      Преподаватель:<br>
      Колесников Евгений Иванович
    </td>
  </tr>
  <tr>
    <td style="text-align: center; border: none; height: 5em;">
    г.Йошкар-Ола, 2021</td>
  </tr>
</table>

<div style="page-break-after: always;"></div>

# Цели и задачи:
 1. Научится работать с дисками
 2. Научится работать с каталогами
 3. Работать с файлами. Классы File и FileInfo
 4. Находим произвольный доступ к файлам
 5. Закрытие потока
 6. Бинарные файлы. BinaryWriter и BinaryReader



# Краткий материал.

1. Работу с файловой системой начнем с самого верхнего уровня - дисков. Для представления диска в пространстве имен ```System.IO``` имеется класс ``DriveInfo``
Этот класс имеет статический метод GetDrives, который возвращает имена всех логических дисков компьютера.
```Название: C:\
Тип: Fixed
Объем диска: 63757606912
Свободное пространство: 13795221504
Метка:

Название: D:\
Тип: CDRom```</b>
```

2. Класс Directory предоставляет ряд статических методов для управления каталогами. DirectoryInfo предоставляет функциональность для создания, удаления, перемещения и других операций с каталогами.

```string path = @"C:\SomeDir";
string subpath = @"program\avalon";
DirectoryInfo dirInfo = new DirectoryInfo(path);
if (!dirInfo.Exists)
{
    dirInfo.Create();
}
dirInfo.CreateSubdirectory(subpath);
```

3. Работа с файлами. Классы File и FileInfo
```Получение информации о файле
string path = @"C:\apache\hta.txt";
FileInfo fileInf = new FileInfo(path);
if (fileInf.Exists)
{
    Console.WriteLine("Имя файла: {0}", fileInf.Name);
    Console.WriteLine("Время создания: {0}", fileInf.CreationTime);
    Console.WriteLine("Размер: {0}", fileInf.Length);
}
```
4. Произвольный доступ к файлам
```
С помощью метода Seek() мы можем управлять положением курсора потока, начиная с которого производится считывание или запись в файл. Этот метод принимает два параметра: offset (смещение) и позиция в файле. 

Консольный вывод:
Текст записан в файл
Текст из файла: worl
Текст из файла: hello house
```
5. Закрытие потока

Для закрытия потока применяется конструкция using. После того как все операторы и выражения в блоке using отработают, объект FileStream уничтожается.
```
FileStream fstream = null;
try
{
    fstream = new FileStream(@"D:\note3.dat", FileMode.OpenOrCreate);
    // операции с потоком
}
catch(Exception ex)
{
 
}
finally
{
    if (fstream != null)
        fstream.Close();
}
Если мы не используем конструкцию using, то нам надо явным образом вызвать метод Close(): fstream.Close()
```
6. Бинарные файлы. BinaryWriter и BinaryReader
```
Для работы с бинарными файлами предназначена пара классов BinaryWriter и BinaryReader. Эти классы позволяют читать и записывать данные в двоичном формате.
Чтобы объект определенного класса можно было сериализовать, надо этот класс пометить атрибутом Serializable:

[Serializable]
class Person
{
    public string Name { get; set; }
    public int Year { get; set; }
 
    public Person(string name, int year)
    {
        Name = name;
        Year = year;
    }
```

```
Для бинарной сериализации применяется класс BinaryFormatter:

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
```

# Вывод
В данной лабораторной работе мы научились работать с дисками, каталогами, с классами File и FileInfo, находить произвольный доступ к файлам, закрывать потоки и бинарные файлы BinaryWriter и BinaryReader.