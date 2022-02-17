using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork_1
{
    public class TaskManager
    {
        int choice;
        public void DisplayMenu()
        {
            Console.WriteLine(" ==============================================");
            Console.WriteLine(" 1. Завдання №9");
            Console.WriteLine(" 2. Завдання №10");
            Console.WriteLine(" 3. Завдання №11");
            Console.WriteLine(" 4. Завдання №12");
            Console.WriteLine(" 5. Завдання №13");
            Console.WriteLine(" 6 -> Вихiд");
            Console.WriteLine("==============================================");

        }
        public int GetChoice()
        {
            Console.Write(" Виберiть номер завдання: -> ");
            try
            {
                choice = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
            return choice;
        }
        public char Exit()
        {
            char ans;
            Console.Write("\n> Продовжити? (y/n) -> ");
            ans = Convert.ToChar(Console.ReadLine());
            return ans;
        }
    }
}
