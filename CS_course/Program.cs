namespace CS_course
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //типы данных
           
            bool alive = true; bool isDead = false;  //bool: хранит значение true или false(логические литералы)
            //byte bit1 = 1; //byte: хранит целое число от 0 до 255 и занимает 1 байт.
            //sbyte bit1 = 101; //sbyte: хранит целое число от -128 до 127 и занимает 1 байт            
            //short n1 = 1; //short: хранит целое число от -32768 до 32767 и занимает 2 байта          
            //ushort n1 = 1; //ushort: хранит целое число от 0 до 65535 и занимает 2 байта            
            int a = 10; //int: хранит целое число от -2147483648 до 2147483647 и занимает 4 байта            
            uint b = 0b101; //uint: хранит целое число от 0 до 4294967295 и занимает 4 байта            
            //long a = -10; //long: хранит целое число от –9 223 372 036 854 775 808 до 9 223 372 036 854 775 807 и занимает 8 байт            
            //ulong b = 0b101; //ulong: хранит целое число от 0 до 18 446 744 073 709 551 615 и занимает 8 байт
            float a1 = 5.7f //float: хранит число с плавающей точкой (до 7 знаков после запятой)
            double d1 = 5.7 //double: хранит число с плавающей точкой (до 15 знаков после запятой)
            //decimal d1 = //decimal: хранит десятичное дробное число. Если употребляется без десятичной запятой, имеет значение от ±1.0 * 10 - 28 до ±7.9228 * 1028, может хранить 28 знаков после запятой и занимает 16 байт
     
            char a = 'A'; //char: хранит одиночный символ в кодировке Unicode и занимает 2 байта   
            string hello = "Hello"; //string: хранит набор символов Unicode

            //object: может хранить значение любого типа данных и занимает 4 байта на 32 - разрядной платформе и 8 байт на 64 - разрядной платформе
            object a = 22;
            object b = 3.14;
            object c = "hello code";

            //Арифметические операторы:  '+', '-', '*', '/', '%'


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

            //array
            int[] cucumber = new int[4] { 4, 1, 7, 9 };
            //2darray
            int[,] array2D = new int[,] { 
                { 1, 2 }, 
                { 3, 4 }, 
                { 5, 6 }, 
                { 7, 8 } 
            };
            Console.WriteLine(array2D[1, 1]);
            Console.WriteLine(array2D.Length);

            for (int i = 0; i < array2D.GetLength(0); i++) 
            {
                for (int j = 0; j < array2D.GetLength(1); j++)
                {
                    Console.Write(array2D[i, j] + " ");
                }
            }   Console.WriteLine();

            //Коллекции
            //List (в отличии от массивом есть функции)
            List<int> number = new List<int>(5);
            numbers[0] = 1;
            numbers.Add(12);    //Добавление значения в конец Листа
            numbers.Add(8);    //Добавление значения в конец Листа
            numbers.AddRange(new int[] { 3, 4, 5, 6 });
            numbers.Remove(4);  //Удаляет элемент коллекции по первому совпадению
            numbers.RemoveAt(4);  //Удаляет элемент коллекции по индексу
            numbers.Clear();  //Очистить коллекцию
            numbers.IndexOff(22);
            for (int l = 0; l < numbers.Count; l++)
                {
                    Console.Write(numbers[l]);
                }

            //Queue --from start
            Queue<string> patients = new Queue<string>();
            patients.Enqueue("Ivan");  //Добавить элемент в очередь
            patients.Enqueue("Igor");
            patients.Enqueue("Oleg");
            patients.Dequeue();    //Удалить первый элемент в очереди

            foreach (var patient in patients)
            {
                Console.WriteLine(patient);
            }

            //Stack --from end
            Stack<int> numbers = new Stack<int>();
            numbers.Push(1);    //Добавить элемент
            numbers.Push(5);
            numbers.Pop();    //Извлеч последний элемент

            //Dictionary
            Dictionary<string, string> countriesCapitals = new Dictionary<string, string>();
            countriesCapitals.Add("Australia", "Kanberra");
            countriesCapitals.Add("Russia", "Moscow");

            foreach (var item in countriesCapitals)
            {
                Console.WriteLine($"Country - {item.Key} capital {item.Value}");
            }
            
            
            

        }
    }
}
