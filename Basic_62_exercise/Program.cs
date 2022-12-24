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
            }

        }

        static void ExampleOne() {
            Console.WriteLine("Введите ваше имя");
            var exampleOne = Console.ReadLine();
            Console.WriteLine("Здраствуйте : " + exampleOne);
        }
    }
}