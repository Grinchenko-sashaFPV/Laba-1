using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork_1
{
    public class ExamplesManager
    {
        public void Task1()
        {
            /*
               9. Написати програму, яка дозволяє під час роботи вводити з клавіатури числові
               значення для двох змінних а та b. Необхідно поміняти значення змінних місцями і
               вивести на екран значення змінних до обміну і після (тобто в змінну a потрібно
               записати те, що с початку зберігалося в b, а в змінну b записати те, що раніше
               зберігалося в a). Не використовувати додаткові змінні.
            */

            Console.Write(" Введiть а: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Введiть b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" =================================");
            Console.WriteLine($"    ДО: A-> {a}; B-> {b}");
            (a, b) = (b, a);
            
            Console.WriteLine($" Пiсля: A-> {a}; B-> {b}");
        }
        public void Task2()
        {
            /*
                10. З клавіатури вводиться N – кількість хвилин, які пройшли з початку доби.
                Необхідно визначити скільки годин та хвилин показує електронний годинник.
                Врахувати, що N може бути більше за кількість хвилин у добі. Значення годин та
                хвилин знаходяться у діапазоні: 0-23 годин, 0-59 хвилин. Вивести результат у
                форматі години:хвилини.
             */
            Console.Write(" Введiть кiлькiсть хвилин: ");
            int minutes = Convert.ToInt32(Console.ReadLine());
            int success = (minutes <= 1440) ? 1 : 0;

            Console.WriteLine(" =================================");
            string result = (success == 1) ? $" Час-> {minutes / 60}:{minutes - (minutes / 60) * 60}"
                : $"Хвилин бiльше, нiж 1440 (24 год = 1440 хв)";
            Console.WriteLine(result);
        }
        public void Task3()
        {
            /*
                11. Написати програму для знаходження і виведення на екран суму цифр
                трьохзначного числа. Трьохзначне число вводиться користувачем з клавіатури
                під час виконання програми.
             */
            Console.Write(" Введiть 3-х значне число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int summ = number % 10;
            Console.Write($" {number % 10} + ");
            number /= 10;
            summ += number % 10;
            Console.Write($"{number % 10} + ");
            number /= 10;
            Console.Write($"{number % 10} = ");
            summ += number;
            Console.WriteLine($"{summ}");
        }
        public void Task4()
        {
            /*
                12. Булочка коштує Х гривень Y копійок. Скільки потрібно заплатити гривень та
                копійок за N булочок. Х, Y та N вводяться користувачем з клавіатури під час
                виконання програми. Результат обчислень виводиться на екран у вигляді: За ?
                булочок необхідно заплатити ? гривень ? копійок. ( ? – обчислені значення).
             */
            Console.Write(" Введiть к-сть N булочок: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Введiть Х гривень: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Введiть Y копiйок: ");
            int y = Convert.ToInt32(Console.ReadLine());
            int res = n * (x * 100 + y);

            Console.WriteLine($"За {n} булочок/ки необхiдно заплатити {res / 100} гривень {res % 100} копiйок.");
        }
        public void Task5()
        {
            /*
                Програма дозволяє вводити з клавіатури кількість копійок, яку треба видати. В
                наявності є монети номіналом 50, 25, 10, 5, 1. Визначити і вивести на екран
                кількість монет кожного номіналу, яку потрібно видати для отримання
                зазначеної суми грошей.
             */
            Console.Write(" Введiть к-сть копiйок: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write($"{n} копiйок вмiщують в себе: ");

            int cent_50 = n / 50;
            n = (cent_50 > 0) ? n - cent_50 * 50 : n;
            int cent_25 = n / 25;
            n = (cent_25 > 0) ? n - cent_25 * 25 : n;
            int cent_10 = n / 10;
            n = (cent_10 > 0) ? n - cent_10 * 10 : n;
            int cent_5 = n / 5;
            n = (cent_5 > 0) ? n - cent_5 * 5 : n;
            int cent_1 = n / 1;

            Console.WriteLine($"{cent_50} (50 коп), {cent_25} (25 коп), {cent_10} (10 коп), {cent_5} (5 коп), {cent_1} (1 коп).");
        }
    }
}
