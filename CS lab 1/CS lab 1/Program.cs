using System;

namespace CS_lab_1
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1 Завдання\n2 Завдання\n3 Завдання\n4 Перевірка на палідромність(до 2 завдання)\n");
                int a = Convert.ToInt16(Console.ReadLine());
                if (a == 1)
                {
                    Ex1();
                }
                if (a == 2)
                {
                    Ex2();
                }
                if (a == 3)
                {
                    Ex3();
                }
                if (a == 4)
                {
                    string i;
                    while (true)
                    {
                        Console.WriteLine("Введіть число для перевірки на палідромність або Enter для виходу");
                        i = Console.ReadLine();
                        if (i == "")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine(Palindrome(Convert.ToInt32(i)));
                        }
                    }
                }
                else { continue; }
            }
        }
        public static void Ex1()
        {
            double y = 0;
            Console.WriteLine("Завдання 1 \tВаріант 30\n y=(5x/(x^2+z))-tg(sqrtX/z)\n");
            Console.WriteLine("Введіть значення Х:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть значення Z:");
            int z = Convert.ToInt32(Console.ReadLine());
            y = (5 * x / (x * x + z)) - Math.Tan(Math.Sqrt(x) / z);
            Console.WriteLine("Результатом Y при значеннях X=" + x + " та Z=" + z + " є число " + y);
            Console.WriteLine("Натисніть Enter для  продовження");
            Console.ReadLine();

        }
        public static void Ex2()
        {
            Console.WriteLine("Завдання 2 \tВаріант 5\n Натуральне число називається паліндромом, якщо його запис читається однаково з початку та з кінця " +
                "\n(наприклад, 4884, 393, 1). Знайти всі числа-паліндроми, що не перевищують 100, та при піднесенні\n до квадрату також дають паліндроми. \n");
            Console.WriteLine("Число\tЧисло піднесене до квадрату");
            for (int i = 0; i <= 100; i++)
            {
                if (Palindrome(i))
                {
                    if (Palindrome(i * i))
                    {
                        Console.WriteLine(i + "\t" + i * i);
                    }
                }
            }
            Console.WriteLine("Натисніть Enter для  продовження");
            Console.ReadLine();
        }
        public static bool Palindrome(int num)
        {
            string numStr = num.ToString();
            int length = numStr.Length;

            for (int i = 0; i < length / 2; i++)
            {
                if (numStr[i] != numStr[length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }

        public static void Ex3()
        {
            string a;
            string b;
            Console.WriteLine("Завдання 3:\nСкласти функцію, що дозволяє визначити позицію першого входження в заданий рядок деякого \nсимволу з другого заданого рядка. Результатом роботи функції повинна бути -1, \nякщо перший рядок не містить в собі жодного символа, що належить до другого рядка.\n");
            Console.WriteLine("Введіть 1 рядок:");
            a = Console.ReadLine();
            Console.WriteLine("Введіть 2 рядок:");
            b = Console.ReadLine();
            int pos = StrPos(a, b);
            if(pos != -1)
            {
                pos++;
                Console.WriteLine("Другий рядок має спільний символ для входу в перший в позиції " + pos + " символу");
            }
            else
            {
                Console.WriteLine("Другий рядок не має спільних символів з першим");
            }
            Console.WriteLine("Натисніть Enter для  продовження");
            Console.ReadLine();
        }
        
        static int StrPos(string a, string b)
        {
            for(int i = 0; i<a.Length; i++)
            {
                if (b.Contains(a[i].ToString()))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
