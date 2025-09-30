using Tyuiu.KadralinovaAT.Sprint1.Task6.V11.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #1 | Выполнила: Кадралинова А. Т. | ПИНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Работа со строками класс String                                   *");
Console.WriteLine("* Задание #6                                                              *");
Console.WriteLine("* Вариант #11                                                             *");
Console.WriteLine("* Выполнила: Кадралинова Амина Тастемировна | ПИНб-25-1                   *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, пользователь вводит текст.                          *");
Console.WriteLine("* Проверить, что первая буква строки входит в нее еще раз.                *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Введите строку:");
string str = Console.ReadLine();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine(ds.CheckeFirstLetterRepetition(str));

Console.ReadKey();