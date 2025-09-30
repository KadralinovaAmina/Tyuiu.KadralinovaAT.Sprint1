using Tyuiu.KadralinovaAT.Sprint1.Task7.V12.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #1 | Выполнила: Кадралинова А. Т. | ПИНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Итоговая работа                                                   *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #12                                                             *");
Console.WriteLine("* Выполнила: Кадралинова Амина Тастемировна | ПИНб-25-1                   *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по       *");
Console.WriteLine("* исходным значениям данных, вводимых пользователем.                      *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("*            x                                                            *");
Console.WriteLine("*      x + 1        2                                                     *");
Console.WriteLine("* z = (-----) + 18xy                                                      *");
Console.WriteLine("*      x - 1                                                              *");

double x, y;

Console.WriteLine("Введите значение X:");
x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение Y:");
y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine(ds.Calculate(x, y));

Console.ReadKey();