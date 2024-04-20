using System;

class Program
{
    static void Main()
    {
        Random rand = new Random();

        //1. Esimene ülesanne
        // два случайных числа N и M в диапазоне от -100 до 100
        int N = rand.Next(-100, 101);
        int M = rand.Next(-100, 101);
        long[] numbers = new long[M - (long)N + 1]; // Используем тип long, потому что разброс большой 200 и все не дает запустить
        for (int i = 0; i < numbers.Length; i++) // перебирать каждое число в списке по порядку от начала до конца.
        {
            numbers[i] = rand.Next(N, M + 1);
            Console.WriteLine($"Arv {i + 1} ruut: {numbers[i] * numbers[i]}");
        }

        // Teine ülesanne
        int[] userNumbers = new int[5]; //Создается массив userNumbers размером 5 
        int sum = 0;
        for (int i = 0; i < userNumbers.Length; i++)
        {
            Console.Write($"Sisesta {i + 1}. number: ");
            userNumbers[i] = int.Parse(Console.ReadLine());
            sum += userNumbers[i];
        }
        double average = (double)sum / userNumbers.Length;
        int product = 1; //Инициализируется переменная product значением 1, которая будет использоваться для хранения произведения всех введенных чисел.
        foreach (int num in userNumbers) //Цикл foreach перебирает все числа в массиве userNumbers, умножая их между собой и сохраняя результат в переменной product.
        {
            product *= num;
        }
        Console.WriteLine($"Summa: {sum}, Keskm: {average}, Korrutis: {product}");
        
        
        
        
        // Kolmas ülesanne
        string[] names = new string[5];
        int[] ages = new int[5];
        int totalAge = 0;
        for (int i = 0; i < names.Length; i++)
        {
            Console.Write($"Sisesta {i + 1}. inimese nimi: ");
            names[i] = Console.ReadLine();
            Console.Write($"Sisesta {names[i]}' vanus: ");
            ages[i] = int.Parse(Console.ReadLine());
            totalAge += ages[i];
        }
        double averageAge = (double)totalAge / names.Length;
        //Используется метод Array.IndexOf() для определения индекса самого старшего (oldestIndex) и самого младшего (youngestIndex) человека в массиве ages.
        int oldestIndex = Array.IndexOf(ages, ages.Max());
        int youngestIndex = Array.IndexOf(ages, ages.Min());
        Console.WriteLine($"Keskmine vanus: {averageAge}");
        Console.WriteLine($"Vanim: {names[oldestIndex]}, Vanus: {ages[oldestIndex]}");
        Console.WriteLine($"Noorim: {names[youngestIndex]}, Vanus: {ages[youngestIndex]}");



       // Neljas ülesanne
       string input;
       do
       {
            Console.WriteLine("Osta elevant ära!");
            input = Console.ReadLine();
       } while (input.ToLower() != "elevant");
        //Как только пользователь введет "elevant" (или его перевод в нижний регистр), условие input.ToLower() != "elevant" станет ложным, и выполнение цикла завершится.

        // Viies ülesanne
        int targetNumber = rand.Next(1, 101);
        for (int i = 1; i <= 5; i++)
        {
            //Введенное пользователем число считывается с помощью Console.ReadLine() и преобразуется в тип int с помощью int.Parse(). Результат сохраняется в переменной guess
            Console.Write($"Katse {i}: Sisesta arv: ");
            int guess = int.Parse(Console.ReadLine());
            if (guess == targetNumber)
            {
                Console.WriteLine("Õige! Arvuti mõtles selle arvu välja.");
                break;
            }
            else if (guess < targetNumber)
            {
                Console.WriteLine("Arvuti mõeldud arv on suurem.");  //Если число guess меньше targetNumber
            }
            else
            {
                Console.WriteLine("Arvuti mõeldud arv on väiksem."); //Если число guess больше targetNumber
            }
        }

        // Kuues ülesanne
        int[] fourNumbers = new int[4];
        for (int i = 0; i < fourNumbers.Length; i++)
        {
            Console.Write($"Sisesta {i + 1}. arv: ");
            fourNumbers[i] = int.Parse(Console.ReadLine());
        }
        //Массив fourNumbers сортируется в порядке возрастания с помощью метода Array.Sort().
        Array.Sort(fourNumbers);
        int largestFourDigitNumber = fourNumbers[0] * 1000 + fourNumbers[1] * 100 + fourNumbers[2] * 10 + fourNumbers[3];
        Console.WriteLine($"Suurim neljakohaline arv: {largestFourDigitNumber}");

        // Seitsmes ülesanne
        Console.WriteLine("Korrutustabel:");
        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                //На каждой итерации внутреннего цикла вычисляется произведение i * j
                Console.Write($"{i * j,4}"); //Каждый результат произведения выводится в формате, где числа выравниваются по ширине в 4 символа.
            }
            Console.WriteLine();
        }
    }
}
