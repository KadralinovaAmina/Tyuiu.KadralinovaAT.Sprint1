using Tyuiu.KadralinovaAT.Sprint1.Task4.V20.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #1 | Выполнила: Кадралинова А. Т. | ПИНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Class Math                                                        *");
Console.WriteLine("* Задание #4                                                              *");
Console.WriteLine("* Вариант #20                                                             *");
Console.WriteLine("* Выполнила: Кадралинова Амина Тастемировна | ПИНб-25-1                   *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
Console.WriteLine("* вычисляет результат по формуле и печатает его на экране.                *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int x, y;

Console.WriteLine("Введите значение X:");
x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение Y:");
y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("(1 + x) / abs(x - sqrt(2) + y) = " + ds.Calculate(x, y));

Console.ReadKey();