using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1
{
    internal class Program {
        private static object myString;

        static void Main(string[] args)
        {
            string data;
            Console.WriteLine( "Введите true или false: ");
            data = Console.ReadLine();
                bool a = Convert.ToBoolean(data);
                if (a == true)
                {
                Console.WriteLine(false);
            }
                else
                {
                Console.WriteLine(true);
                
            }
            Console.WriteLine( "Введите целочисленное число:  ");
            data = Console.ReadLine();
            int b = Convert.ToInt32(data);
            int d = 10;
            int result_1  = b + d;
            if (result_1 > 0)
            {
                Console.WriteLine("Результат введенного целочисленного значения: " + result_1);
            }
            Console.WriteLine("Введите вещественное число:  ");
            data = Console.ReadLine();
            float c =(float) Convert.ToDouble(data);
            
            float result_2 = c * d;
            
            if (result_2 > 0)
            {
                Console.WriteLine("Результат введенного вещественного числа: " + result_2);
            }

            double i = Convert.ToDouble(data);
            double result_3 = i * d;
            if(result_3 > 0)
            {
                Console.WriteLine("Результат введенного вещественного числа с двойной точностью  " + result_3);
            }
            Console.WriteLine("Введите три любых символа: ");
            data = Console.ReadLine();
            Console.WriteLine("Результат преобразования: ");
            Console.WriteLine(data.Insert(3, "-" + data));
            char[] f = data.ToCharArray();
            Console.WriteLine("Преобразованная строка в char: ");
            Console.WriteLine(f);
              
            while (true)
            {
                System.Console.ReadKey();
            }
        }

}


}
    
