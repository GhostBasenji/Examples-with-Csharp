// Программа организует ввод двух чисел, их сложение и вывод суммы на консоль
Console.Title = "Складываем два числа:";
Console.BackgroundColor = ConsoleColor.Cyan;  // цвет фона
Console.ForegroundColor = ConsoleColor.Black; // цвет текста
Console.Clear();

// Ввод первого слагаемого:
Console.WriteLine("Введите первое слагаемое:");
var Perem = Console.ReadLine();
// Преобразование строковой переменной в число:
var X = Single.Parse(Perem);

// Ввод второго слагаемого:
Console.WriteLine("Введите второе слагаемое:");
Perem = Console.ReadLine();
var Y = Single.Parse(Perem);

var Z = X + Y;

Console.WriteLine("Сумма = {0} + {1} = {2}", X, Y, Z);

// Звуковой сигнал частотой 1000 Гц и длительностью 0,5 секунд:
Console.Beep(1000, 500);

// Приостановить выполнение программы до нажатия какой-нибудь клавиши:
Console.ReadKey();