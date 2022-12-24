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
                case 1:
                    ExampleOne();
                break;

                case 2:
                    ExampleTwo();
                break;

                case 3:
                    ExampleThree();
                break;
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
            int intNumberThree = intNumberOne + intNumberTwo;
            Console.WriteLine("Сумма двух чисел = " + intNumberThree);
        }

        static void ExampleThree(){
            Console.WriteLine("Введите 2 числа для их деления");
            double doubleNumberOne = Convert.ToDouble(Console.ReadLine());
            double doubleNumberTwo = Convert.ToDouble(Console.ReadLine());
            double doubleNumberTree = doubleNumberOne / doubleNumberTwo;
            Console.WriteLine("Результат деления – частное = " + doubleNumberTree);
        }
    }
}