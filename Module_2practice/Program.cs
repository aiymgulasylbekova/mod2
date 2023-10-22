using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1

namespace Module_2practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n1 = ");
            int n1 =Convert.ToInt32(Console.ReadLine());
            Console.Write("n2 = ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("n3 =");
            int n3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{n1}  {n2}  {n3}");
            Console.ReadKey();
        }
    }
}



//2
/*
namespace Module_2practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n1=");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("n2=");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("n3=");
            int n3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.ReadKey();
        }
    }
}
*/

//3
/*
namespace Module_2practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("В сантиметрах:");
            int cm = Convert.ToInt32(Console.ReadLine());
            double m = cm / 100;
            Console.WriteLine($"В метрах: {m}");
            Console.ReadKey();
        }
    }
}
*/

//4
/*
namespace Module_2practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сколько дней прошло:");
            int n = Convert.ToInt32(Console.ReadLine());
            int w = n / 7;
            Console.WriteLine($"В неделях: {w}");
            Console.ReadKey();

        }
    }
}
*/

//5
/*
namespace Module_2practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n=");
            int n=Convert.ToInt32(Console.ReadLine());
            int a = n / 10;// число десятков
            int b = n % 10;// число единиц
            int c = a + b;
            int d = a * b;

            Console.WriteLine($"Число десятков: {a}");
            Console.WriteLine($"Число единиц: {b}");
            Console.WriteLine($"Сумма: {c}");
            Console.WriteLine($"Произведение: {d}");
            Console.ReadKey();

        }
    }
}
*/
/*

//6
namespace Module_2practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool A = true;
            bool B = false;
            bool C = false;

            // a. A или B
            bool resultA = A || B;
            Console.WriteLine("a. A или B: " + resultA);

            // b. A и B
            bool resultB = A && B;
            Console.WriteLine("b. A и B: " + resultB);

            // c. B или C
            bool resultC = B || C;
            Console.WriteLine("c. B или C: " + resultC);

            Console.ReadKey();
        }
    }
}

//7
namespace Module_2practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус круга:");
            double radius = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите длину стороны квадрата:");
            double length = double.Parse(Console.ReadLine());

            // Вычисление площадей
            double circleArea = Math.PI * Math.Pow(radius, 2); // Площадь круга
            double squareArea = Math.Pow(length, 2); // Площадь квадрата

            Console.WriteLine($"Площадь круга: {circleArea}");
            Console.WriteLine($"Площадь квадрата: {squareArea}");
            //сравнение 
            if (circleArea > squareArea)
            {
                Console.WriteLine("Площадь круга больше.");
            }
            else if (circleArea < squareArea)
            {
                Console.WriteLine("Площадь квадрата больше.");
            }
            else
            {
                Console.WriteLine("Площади круга и квадрата равны.");
            }

            Console.ReadKey(); 
        }
    }
            }
    


//8
namespace Module_2practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите массу 1:");
            double mass1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите объем 1:");
            double volume1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите массу 2:");
            double mass2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите объем 2:");
            double volume2 = double.Parse(Console.ReadLine());

            // Вычисление плотностей
            double density1 = mass1 / volume1; // Плотность 1
            double density2 = mass2 / volume2; // Плотность 2

            Console.WriteLine($"Плотность первого тела: {density1}");
            Console.WriteLine($"Плотность второго тела: {density2}");
            //сравнение 
            if (density1 > density2)
            {
                Console.WriteLine("Материал 1 имеет большую плотность.");
            }
            else if (density1 < density2)
            {
                Console.WriteLine("Материал 2 имеет большую плотность.");
            }
            else
            {
                Console.WriteLine("Плотности обоих тел равны.");
            }

            Console.ReadKey();
        }
    }
}

//9
namespace Module_2practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите напряжение 1:");
            double voltage1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите сопротивление 1:");
            double resistance1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите напряжение 2:");
            double voltage2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите сопротивление 2:");
            double resistance2 = double.Parse(Console.ReadLine());

            // Вычисление тока 
            double current1 = voltage1 / resistance1;
            double current2 = voltage2 / resistance2;

            Console.WriteLine($"Ток на первом участке: {current1} ");
            Console.WriteLine($"Ток на втором участке: {current2} ");
            // сравнение
            if (current1 < current2)
            {
                Console.WriteLine("Меньший ток протекает по первому участку.");
            }
            else if (current1 > current2)
            {
                Console.WriteLine("Меньший ток протекает по второму участку.");
            }
            else
            {
                Console.WriteLine("Токи на обоих участках равны.");
            }

            Console.ReadKey();
        }
    }
}

//10
namespace Module_2practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // a. Все целые числа от 20 до 35
            Console.WriteLine("a. Все целые числа от 20 до 35:");
            for (int i = 20; i <= 35; i++)
            {
                Console.WriteLine(i);
            }

            // b. Квадраты всех целых чисел от 10 до b
            Console.Write("b. Введите значение b (b > 10): ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Квадраты чисел от 10 до " + b + ":");
            for (int i = 10; i <= b; i++)
            {
                Console.WriteLine(i * i);
            }
            // c. Третьи степени всех целых чисел от a до 50
            Console.Write("c. Введите значение a (a < 50): ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Третьи степени чисел от " + a + " до 50:");
            for (int i = a; i <= 50; i++)
            {
                Console.WriteLine(Math.Pow(i, 3));
            }

            // d. Все целые числа от a до b
            Console.Write("d. Введите значение a: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Введите значение b (b > a): ");
            int end = int.Parse(Console.ReadLine());
            Console.WriteLine("Целые числа от " + start + " до " + end + ":");
            for (int i = start; i <= end; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}

//11
namespace Module_2practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Вид функция  y = ax^2 + bx + c
            double a = 4.0; 
            double b = 5.0; 
            double c = 3.0; 

            Console.WriteLine("Введите значение x:");
            double x = double.Parse(Console.ReadLine());

            double y = a * x * x + b * x + c;
            Console.WriteLine($"Значение функции при x = {x}: y = {y}");

            Console.ReadKey();
        }
    }
}



//12
namespace Module_2practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус круга:");
            double radius = double.Parse(Console.ReadLine());

            // Вычисление площадей
            double circleArea = Math.PI * Math.Pow(radius, 2);
            // Вычисление длинны 
            double cirlength = 2 * Math.PI * radius;
            Console.WriteLine($"Площадь круга: {circleArea}");
            Console.WriteLine($"Длинна окружности: {cirlength}");
            Console.ReadKey();
        }
    }
}



//16
namespace Module_2practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите четырехзначное число:");
            int number = int.Parse(Console.ReadLine());

                // Вычисление цифр числа
                int thousands = number / 1000;
                int hundreds = (number % 1000) / 100;
                int tens = (number % 100) / 10;
                int ones = number % 10;

                // a. Сумма цифр
                int sum = thousands + hundreds + tens + ones;
                Console.WriteLine($"Сумма цифр: {sum}");

                // b. Произведение цифр
                int product = thousands * hundreds * tens * ones;
                Console.WriteLine($"Произведение цифр: {product}");

            Console.ReadKey();
        } 
       
        }
    }


//18
namespace Module_2practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool[] values = { true, false };

            Console.WriteLine("Значения логических выражений:");

            foreach (bool x in values)
            {
                foreach (bool y in values)
                {
                    // a. не X и не Y
                    bool resultA = !x && !y;

                    // b. X или (не X и Y)
                    bool resultB = x || (!x && y);

                    // c. (не X и Y) или Y
                    bool resultC = (!x && y) || y;

                    Console.WriteLine($"X = {x}, Y = {y}");
                    Console.WriteLine($"a. не X и не Y: {resultA}");
                    Console.WriteLine($"b. X или (не X и Y): {resultB}");
                    Console.WriteLine($"c. (не X и Y) или Y: {resultC}");
                    Console.WriteLine();
                }
            }

            Console.ReadKey();
        }
    }
}


//19-20
namespace Module_2practice
{
    internal class Program
    {
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args)
        {
            int x = 5;
            int y = 10;

            Console.WriteLine($"До обмена : x = {x}, y = {y}");

            // Вызываем функцию Swap, передавая параметры по ссылке
            Swap(ref x, ref y);

            Console.WriteLine($"После обмена: x = {x}, y = {y}");

            Console.ReadKey();
        }
    }
}


//21
namespace Module_2practice
{
    internal class Program
    {
        static void f(ref int a, ref int b, int x, int y)
        {
            a = x * y;
            if (y != 0)
            {
                b = x / y;
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int x = 10;
            int y = 2;

            Console.WriteLine($"До: a = {a}, b = {b}");
            Console.WriteLine($"x = {x}, y = {y}");

            f(ref a, ref b, x, y);

            Console.WriteLine($"После: a = {a}, b = {b}");
            Console.ReadKey();
        }
    }
}


//22
namespace Module_2practice
{
    internal class Program
    {

        static int f(int x, int y)
        {
            if (x == 0 && y == 0)
            {
                return 0;
            }
            else if (y == 0)
            {
                return 12 / x;
            }
            else if (x == 0)
            {
                return 12 / y;
            }
            else
            {
                return 144 / (x * y);
            }
        }
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;

            Console.WriteLine($"Значение f({x}, {y}) = {f(x, y)}");
            x = 6;
            y = 0;
            Console.WriteLine($"Значение f({x}, {y}) = {f(x, y)}");
            x = 0;
            y = 4;
            Console.WriteLine($"Значение f({x}, {y}) = {f(x, y)}");
            x = 3;
            y = 2;
            Console.WriteLine($"Значение f({x}, {y}) = {f(x, y)}");
            Console.ReadKey();
        }
    }
}

//23
namespace Module_2practice
{
    internal class Program
    {
        static int f(int h, int m, int s)
        {
            if (h < 0 || h > 23 || m < 0 || m > 59 || s < 0 || s > 59)
            {
                throw new ArgumentException("Не правильное время.");
            }

            // Вычисляем количество секунд с начала дня
            int totalSeconds = h * 3600 + m * 60 + s;
            return totalSeconds;
        }
        static void Main(string[] args)
        {
            int hours = 13;
            int minutes = 30;
            int seconds = 01;

            int totalSeconds = f(hours, minutes, seconds);

            Console.WriteLine($"С начала дня прошло {totalSeconds} секунд.");

            Console.ReadKey();
        }
    }
}

//24
namespace Module_2practice
{
    internal class Program
    {
        static int f(int m, int d)
        {
            if (m < 1 || m > 12 || d < 1 || d > 30)
            {
                throw new ArgumentException("Не правильная дата");
            }

            // Вычисляем количество дней с начала года
            int days = (m - 1) * 30 + d;
            return days;
        }
        static void Main(string[] args)
        {
            int month = 9;
            int day = 24;

            int daysPassed = f(month, day);

            Console.WriteLine($"С начала года прошло {daysPassed} дней.");

            Console.ReadKey();
        }
    }
}


//25
namespace Module_2practice
{
    internal class Program
    {
        static int f(int m, int d)
        {
            if (m < 1 || m > 12 || d < 1 || d > 31)
            {
                throw new ArgumentException("Не правильная дата");
            }

            // количество дней в каждом месяце без февраля
            int[] daysInMonth = { 31, 31, 30, 31, 30, 31, 31, 31, 30, 31, 30, 31 };

            // Вычисляем количество дней с начала года
            int daysPassed = 0;
            for (int i = 0; i < m - 1; i++)
            {
                daysPassed += daysInMonth[i];
            }
            daysPassed += d;

            return daysPassed;
        }
        static void Main(string[] args)
        {
            int month = 9;
            int day = 26;

            int daysPassed = f(month, day);

            Console.WriteLine($"С начала года прошло {daysPassed} дней.");

            Console.ReadKey();
        }
    }
}


//26
namespace Module_2practice
{
    internal class Program
    {
        static int f(int m1 = 999, int m2 = 999, int m3 = 999)
        {
            if (m1 < 1 || m1 > 999 || m2 < 1 || m2 > 999 || m3 < 1 || m3 > 999)
            {
                throw new ArgumentException("число не соответствует");
            }

            // Используем условный оператор if для нахождения наименьшего числа
            int min = m1;

            if (m2 < min)
            {
                min = m2;
            }

            if (m3 < min)
            {
                min = m3;
            }

            return min;
        }
            static void Main(string[] args)
        {
            int num1 = 24;
            int num2 =15;
            int num3 = 19;

            int smallest = f(num1, num2, num3);

            Console.WriteLine($"Наименьшее число: {smallest}");

            Console.ReadKey();
        }
    }
}



//27
namespace Module_2practice
{
    internal class Program
    {
        static bool even(int n)
        {
            return n % 2 == 0;
        }

        static void Main(string[] args)
        {
            int number = 135;

            if (even(number))
            {
                Console.WriteLine($"{number} - четное число.");
            }
            else
            {
                Console.WriteLine($"{number} - нечетное число.");
            }

            Console.ReadKey();
        }
    }
}



//28
namespace Module_2practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите три целых числа:");

            Console.Write("Число 1: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Число 2: ");
            int n2 = int.Parse(Console.ReadLine());

            Console.Write("Число 3: ");
            int n3 = int.Parse(Console.ReadLine());

            int min;

            if (n1 <= n2 && n1 <= n3)
            {
                min = n1;
            }
            else if (n2 <= n1 && n2 <= n3)
            {
                min = n2;
            }
            else
            {
                min = n3;
            }

            Console.WriteLine($"Наименьшее число: {min}");

            Console.ReadKey();
        }
    }
}


//29

namespace Module_2practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаем генератор случайных чисел
        Random random = new Random();

            // Открываем файл протокола для записи
            StreamWriter protocolFile = new StreamWriter("protocol.txt");

            // Генерируем и записываем оценки
            for (int i = 0; i < 10; i++)
            {
                int grade = random.Next(2, 6); // Генерируем оценку от 2 до 5

                // Используем оператор switch для записи слова в файл протокола
                switch (grade)
                {
                    case 2:
                        protocolFile.WriteLine("Неуд");
                        break;
                    case 3:
                        protocolFile.WriteLine("Удовл");
                        break;
                    case 4:
                        protocolFile.WriteLine("Хор");
                        break;
                    case 5:
                        protocolFile.WriteLine("Отл");
                        break;
                    default:
                        protocolFile.WriteLine("Ошибка: неверная оценка");
                        break;
                }
            }

            // Закрываем файл протокола
            protocolFile.Close();

            Console.WriteLine("Оценки записаны в файл протокола.");

            Console.ReadKey();
        }
    }
}

//30
namespace Module_2practice
{
    internal class Program
    {
        static int f(int M, int N)
        {
            int sum = 0;

            if (M % 2 == 0) // Если M четное то +1 чтобы начать с нечетного числа
            {
                M++;
            }

            for (int i = M; i <= N; i += 2)
            {
                sum += i;
            }

            return sum;

        }
            static void Main(string[] args)
        {
            int M = 7;
            int N = 37;

            int result = f(M, N);

            Console.WriteLine($"Сумма всех нечетных чисел от {M} до {N} включительно: {result}");
            Console.ReadKey();
        }

        
        }
    }

//31
namespace Module_2practice
{
    internal class Program
    {
        static int f(int N, int n)
        {
            int result = N;

            while (result % n != 0)
            {
                result++;
            }

            return result;
        }
        static void Main(string[] args)
        {
            int N = 10;
            int n = 3;

            int result = f(N, n);

            Console.WriteLine($"Наименьшее число, большее или равное {N} и кратное {n}: {result}");

            Console.ReadKey();
        }
    }
}*/