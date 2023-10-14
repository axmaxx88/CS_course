namespace CS_course
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //типы данных
            //bool: хранит значение true или false(логические литералы)
            bool alive = true;
            bool isDead = false;
            
            //byte: хранит целое число от 0 до 255 и занимает 1 байт.
            byte bit1 = 1;
            //sbyte: хранит целое число от -128 до 127 и занимает 1 байт
            sbyte bit1 = 101;
            //short: хранит целое число от -32768 до 32767 и занимает 2 байта
            short n1 = 1;
            //ushort: хранит целое число от 0 до 65535 и занимает 2 байта
            ushort n1 = 1;
            //int: хранит целое число от -2147483648 до 2147483647 и занимает 4 байта
            int a = 10;
            //uint: хранит целое число от 0 до 4294967295 и занимает 4 байта
            uint b = 0b101;
            //long: хранит целое число от –9 223 372 036 854 775 808 до 9 223 372 036 854 775 807 и занимает 8 байт
            long a = -10;
            //ulong: хранит целое число от 0 до 18 446 744 073 709 551 615 и занимает 8 байт
            ulong b = 0b101;
            //float: хранит число с плавающей точкой от -3.4 * 1038 до 3.4 * 1038 и занимает 4 байта
            //double: хранит число с плавающей точкой от ±5.0 * 10 - 324 до ±1.7 * 10308 и занимает 8 байта
            //decimal: хранит десятичное дробное число. Если употребляется без десятичной запятой, имеет значение от ±1.0 * 10 - 28 до ±7.9228 * 1028, может хранить 28 знаков после запятой и занимает 16 байт

            //char: хранит одиночный символ в кодировке Unicode и занимает 2 байта
            char a = 'A';

            //string: хранит набор символов Unicode
            string hello = "Hello";

            //object: может хранить значение любого типа данных и занимает 4 байта на 32 - разрядной платформе и 8 байт на 64 - разрядной платформе
            object a = 22;
            object b = 3.14;
            object c = "hello code";


            // || Операция логического сложения. Возвращает true, если хотя бы один из операндов возвращает true
            bool x1 = (5 > 6) || (4 < 6); // 5 > 6 - false, 4 < 6 - true, поэтому возвращается true
            // && Операция логического умножения. Возвращает true, если оба операнда одновременно равны true
            bool x1 = (5 > 6) && (4 < 6); // 5 > 6 - false, 4 < 6 - true, поэтому возвращается false


            //Конструкция if..else:
            int num1 = 8;
            int num2 = 6;

            if (num1 > num2)
            {
                Console.WriteLine($"Число {num1} больше числа {num2}");
            }
            else if (num1 < num2)
            {
                Console.WriteLine($"Число {num1} меньше числа {num2}");
            }
            else
            {
                Console.WriteLine("Число num1 равно числу num2");
            }


            //Тернарный оператор:
            int x = 3;
            int y = 2;

            int z = x < y ? (x + y) : (x - y);
            Console.WriteLine(z);   // 1

            //Конструкция Switch:
            string name = "Tom";

            switch (name)
            {
                case "Bob":
                    Console.WriteLine("Ваше имя - Bob");
                    break;
                case "Tom":
                    Console.WriteLine("Ваше имя - Tom");
                    break;
                case "Sam":
                    Console.WriteLine("Ваше имя - Sam");
                    break;
            }

            //Cycles
            //for:
            for (int i = 0; i < 9; i++)
            {
                if (i == 5)
                    break;
                Console.WriteLine(i);
            }

            //do while:
            int i = 6;
            do
            {
                Console.WriteLine(i);
                i--;
            }
            while (i > 0);

            //while:
            int i = 6;
            while (i > 0)
            {
                Console.WriteLine(i);
                i--;
            }

            //foreach:
            foreach (char c in "Tom")
            {
                Console.WriteLine(c);
            }


        }
    }
}