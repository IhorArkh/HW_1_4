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
            Console.WriteLine("Enter please n (number of array elements)");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("n = " + n);

            int[] arrayMain = new int[n];

            // заполнение массива числами от 1 до 26
            for (int i = 0; i < arrayMain.Length; i++)
            {
                arrayMain[i] = new Random().Next(1, 26);
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

            int[] arrayChet = new int[a];
            int[] arrayNeChet = new int[b];

            int z = 0; // переменная для перехода на следующий элемент после записи в чет массив
            int y = 0; // переменная для перехода на следующий элемент после записи в нечет массив
            for (int i = 0; i < arrayMain.Length; i++)
            {
                if (arrayMain[i] % 2 == 0)
                {
                    arrayChet[z] = arrayMain[i];
                    z++;
                }
                else
                {
                    arrayNeChet[y] = arrayMain[i];
                    y++;
                }
            }

            Console.WriteLine();
        }
    }
}