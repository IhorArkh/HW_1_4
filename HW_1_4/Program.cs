// <copyright file="Program.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>

// Создать массив на N элементов, где N указывается с консольной строки.Заполнить его случайными числами от 1 до 26 включительно.
// Создать 2 массива, где в 1 массиве будут значение только четных значений, а во втором нечетных.
// Заменить числа в 1 и 2 массиве на буквы английского алфавита.Значения ячеек этих массивов равны порядковому номеру каждой буквы в алфавите.
// Если же буква является одной из списка (a, e, i, d, h, j) то она должна быть в верхнем регистре.
// Вывести на экран результат того, в каком из массивов будет больше букв в верхнем регистре.
// Вывести оба массива на экран.Каждый из массивов должен быть выведен 1 строкой, где его значения будут разделены пробелом.
namespace HW_1_4
{
    /// <summary>
    /// Joins a first name and a last name together into a single string.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Joins a first name and a last name together into a single string.
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine("Enter please number of array elements)");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arrayMain = new int[n];

            // заполнение массива числами от 1 до 26
            for (int i = 0; i < arrayMain.Length; i++)
            {
                arrayMain[i] = new Random().Next(1, 26);
            }

            // вывод исходного массива
            Console.WriteLine("\nRandomly filled from 1 to 26 array: ");
            for (int i = 0; i < arrayMain.Length; i++)
            {
                Console.Write(arrayMain[i] + " ");
            }

            int a = 0; // счетчик количества чет чисел в массиве
            int b = 0; // счетчик количества нечет чисел в массиве
            // цикл подсчета количества чет и нечет элементов
            for (int i = 0; i < arrayMain.Length; i++)
            {
                if (arrayMain[i] % 2 == 0)
                {
                    a++;
                }
                else
                {
                    b++;
                }
            }

            int[] arrayEven = new int[a];
            int[] arrayOdd = new int[b];

            int z = 0; // переменная для перехода на следующий элемент после записи в чет массив
            int y = 0; // переменная для перехода на следующий элемент после записи в нечет массив
            for (int i = 0; i < arrayMain.Length; i++)
            {
                if (arrayMain[i] % 2 == 0)
                {
                    arrayEven[z] = arrayMain[i];
                    z++;
                }
                else
                {
                    arrayOdd[y] = arrayMain[i];
                    y++;
                }
            }

            // вывод массива с чет числами
            Console.WriteLine("\n\nArray with even numbers: ");
            for (int i = 0; i < arrayEven.Length; i++)
            {
                Console.Write(arrayEven[i] + " ");
            }

            // вывод массива с нечет числами
            Console.WriteLine("\n\nArray with odd numbers: ");
            for (int i = 0; i < arrayOdd.Length; i++)
            {
                Console.Write(arrayOdd[i] + " ");
            }

            List<char> list = new List<char>();
            for (char c = 'a'; c <= 'z'; ++c)
            {
                list.Add(c);
            }

            char[] alphabet = list.ToArray(); // массив с англ алфавитом

            char[] arrayEvenLetters = new char[arrayEven.Length];
            char[] arrayOddLetters = new char[arrayOdd.Length];
            int counterBigEven = 0; // счетчик больших букв в "четном" массиве
            int counterBigOdd = 0; // счетчик больших букв в "нечетном" массиве

            // получаем чет массив в котором записаны требуемые буквы
            for (int i = 0; i < arrayEven.Length; i++)
            {
                int q = arrayEven[i];
                switch (alphabet[q])
                {
                    case 'a':
                        arrayEvenLetters[i] = 'A';
                        counterBigEven++;
                        break;
                    case 'e':
                        arrayEvenLetters[i] = 'E';
                        counterBigEven++;
                        break;
                    case 'i':
                        arrayEvenLetters[i] = 'I';
                        counterBigEven++;
                        break;
                    case 'd':
                        arrayEvenLetters[i] = 'D';
                        counterBigEven++;
                        break;
                    case 'h':
                        arrayEvenLetters[i] = 'H';
                        counterBigEven++;
                        break;
                    case 'j':
                        arrayEvenLetters[i] = 'J';
                        counterBigEven++;
                        break;
                    default:
                        arrayEvenLetters[i] = alphabet[q];
                        break;
                }
            }

            // получаем нечет массив в котором записаны требуемые буквы
            for (int i = 0; i < arrayOdd.Length; i++)
            {
                int q = arrayOdd[i];
                switch (alphabet[q])
                {
                    case 'a':
                        arrayOddLetters[i] = 'A';
                        counterBigOdd++;
                        break;
                    case 'e':
                        arrayOddLetters[i] = 'E';
                        counterBigOdd++;
                        break;
                    case 'i':
                        arrayOddLetters[i] = 'I';
                        counterBigOdd++;
                        break;
                    case 'd':
                        arrayOddLetters[i] = 'D';
                        counterBigOdd++;
                        break;
                    case 'h':
                        arrayOddLetters[i] = 'H';
                        counterBigOdd++;
                        break;
                    case 'j':
                        arrayOddLetters[i] = 'J';
                        counterBigOdd++;
                        break;
                    default:
                        arrayOddLetters[i] = alphabet[q];
                        break;
                }
            }

            Console.WriteLine("\n\nArray 1:"); // выводим 1ый массив
            for (int i = 0; i < arrayEvenLetters.Length; i++)
            {
                Console.Write(arrayEvenLetters[i] + " ");
            }

            Console.WriteLine(); // выводим 2ой массив
            Console.WriteLine("\nArray 2:");
            for (int i = 0; i < arrayOddLetters.Length; i++)
            {
                Console.Write(arrayOddLetters[i] + " ");
            }

            Console.WriteLine();// выводим массив в котором больше заглавных букв
            Console.WriteLine("\nArray that have more big letters:");
            if (counterBigEven > counterBigOdd)
            {
                for (int i = 0; i < arrayEvenLetters.Length; i++)
                {
                    Console.Write(arrayEvenLetters[i] + " ");
                }
            }
            else if (counterBigOdd > counterBigEven)
            {
                for (int i = 0; i < arrayOddLetters.Length; i++)
                {
                    Console.Write(arrayOddLetters[i] + " ");
                }
            }
            else
            {
                Console.WriteLine("Number of big letters in both arrays equals!");
            }
        }
    }
}