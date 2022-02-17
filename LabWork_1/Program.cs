using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            TaskManager taskManager = new TaskManager();
            ExamplesManager example = new ExamplesManager();
            do
            {
                Console.Clear();
                taskManager.DisplayMenu();
                switch (taskManager.GetChoice())
                {
                    case 1:
                        example.Task1();
                        break;
                    case 2:
                        example.Task2();
                        break;
                    case 3:
                        example.Task3();
                        break;
                    case 4:
                        example.Task4();
                        break;
                    case 5:
                        example.Task5();
                        break;
                    case 6:
                        exit = true;
                        break;
                    default:
                        break;
                }
                if (exit) break;
            } while (taskManager.Exit() == 'y');
            Console.WriteLine("\n Програма завершила свою роботу (0_0) ");
        }
    }
}
