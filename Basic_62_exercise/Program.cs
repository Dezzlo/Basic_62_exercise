namespace Basic_62_exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите программу от 1 до 62");
            int a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1: ExampleOne(); break;
                case 2: ExampleTwo(); break;
                case 3: ExampleThree(); break;
                case 4: ExampleFour(); break;
                case 5: ExampleFive(); break;
                case 6: ExampleSix(); break;
                case 7: ExampleSeven(); break;
            }

        }

        static void ExampleOne() {
            Console.WriteLine("Введите ваше имя");
                var exampleOne = Console.ReadLine();
            Console.WriteLine("Здраствуйте : " + exampleOne);
        }

        static void ExampleTwo() {
            Console.WriteLine("Введите 2 числа для их суммы");
                int intNumberOne = Convert.ToInt32(Console.ReadLine());
                int intNumberTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Сумма двух чисел = " + (intNumberOne + intNumberTwo));
        }

        static void ExampleThree(){
            Console.WriteLine("Введите 2 числа для их деления");
                double doubleNumberOne = Convert.ToDouble(Console.ReadLine());
                double doubleNumberTwo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Результат деления – частное = " + (doubleNumberOne / doubleNumberTwo));
        }

        static void ExampleFour()
        {
            Console.WriteLine("Решение примеров :");
                int numberOne = -1 + 4 * 6;
            Console.WriteLine("-1 + 4 * 6 = " + numberOne);
                numberOne = (35 + 5) % 7;
            Console.WriteLine("(35 + 5) % 7 = " + numberOne);
                numberOne = 14 + -4 * 6 / 11;
            Console.WriteLine("14 + -4 * 6 / 11 = " + numberOne);
                numberOne = 2 + 15 / 6 * 1 - 7 % 2;
            Console.WriteLine("2 + 15 / 6 * 1 - 7 % 2 = " + numberOne);
        }

        static void ExampleFive()
        {
            Console.WriteLine("Введите 2 числа, а программа поменяет их местами");
                int numberOne, numberTwo, numberThree;
                numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Первое число : " + numberOne);
                numberTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Второе число : " + numberTwo);
            Console.WriteLine("Меняем числа местами");
                numberThree = numberOne;
                numberOne = numberTwo;
                numberTwo = numberThree;
            Console.WriteLine("Первое число : " + numberOne);
            Console.WriteLine("Второе число : " + numberTwo);
        }

        static void ExampleSix()
        {
            Console.WriteLine("Введите 3 числа для их умножения между собой");
                int numberOne, numberTwo, numberThree;
                numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Первое число : " + numberOne);
                numberTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Второе число : " + numberTwo);
                numberThree = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Третье число : " + numberThree);
            Console.WriteLine(numberOne + " x " + numberTwo + " x " + numberThree + " = " + (numberOne * numberTwo * numberThree));
        }

        static void ExampleSeven()
        {
            Console.WriteLine("Введите 2 числа для операции с ними");
                int numberOne, numberTwo;
                numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Первое число : " + numberOne);
                numberTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Второе число : " + numberTwo);
                Console.WriteLine(numberOne + " + " + numberTwo + " = " + (numberOne + numberTwo));
                Console.WriteLine(numberOne + " - " + numberTwo + " = " + (numberOne - numberTwo));
                Console.WriteLine(numberOne + " * " + numberTwo + " = " + (numberOne * numberTwo));
                Console.WriteLine(numberOne + " / " + numberTwo + " = " + (numberOne / numberTwo));
                Console.WriteLine(numberOne + " % " + numberTwo + " = " + (numberOne % numberTwo));
        }
    }
}