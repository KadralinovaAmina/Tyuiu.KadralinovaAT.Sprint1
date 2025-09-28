using Tyuiu.KadralinovaAT.Sprint1.Task3.V4.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #1 | Выполнила: Кадралинова А. Т. | ПИНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
Console.WriteLine("* Задание #3                                                              *");
Console.WriteLine("* Вариант #4                                                              *");
Console.WriteLine("* Выполнила: Кадралинова Амина Тастемировна | ПИНб-25-1                   *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
Console.WriteLine("* выполняет указанные расчеты и печатает результат на экране.             *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

double x = 2.75;
double y = 0.5;
int z = 7;

Console.WriteLine("Цена тетради = " + x);
Console.WriteLine("Цена обложки = " + y);
Console.WriteLine("Количество комплектов(шт.) = " + z);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Стоимость покупки = " + ds.PurchaseAmount(x, y, z));

Console.ReadKey();