namespace YourLuckyNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new();
            byte luckyNumber = (byte)random.Next(0,99); //генерація рандомного числа від 0 до 99
        }
    }
}
