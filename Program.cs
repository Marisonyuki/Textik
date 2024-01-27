namespace TextEditor
{
    internal class Program
    {
        static void Main()
        {
            Animal Lagushka = new Animal()
            {
                Name = "Лягушка",
                Power = 1,
                Speed = 3
            };
            
            Animal Jaba = new Animal()
            {
                Name = "Жаба",
                Power = 3,
                Speed = 2
            };

            Animal Cat = new Animal()
            {
                Name = "Кот",
                Power = 4,
                Speed = 5
            };

            ConsoleKeyInfo key = Console.ReadKey(true);
            while (key.Key != ConsoleKey.Escape)
            {
                FileManager.Read();
                Console.WriteLine("F1 для сохранения|Escape для выхода");
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.F1)
                {
                    FileManager.Save();
                    break;
                }
            }
        }
    }
}