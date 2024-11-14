namespace YourLuckyNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //для нормальноого відображення "і" в консолі
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            Random random = new();
            sbyte luckyNumber = (sbyte)random.Next(0,99); //генерація рандомного числа від 0 до 99

            Console.ForegroundColor = ConsoleColor.Cyan; // зміна кольору тескту в консолі
            Console.WriteLine($"Сьогодні твоє щасливе число {luckyNumber}");
            Console.ResetColor();
        }
    }
}
