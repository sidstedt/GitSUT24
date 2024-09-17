namespace GitSUT24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to this super awesome game!");
            Console.Write("Choose a nickname: ");
            string userNick = Console.ReadLine();
            Console.WriteLine($"Greetings, oh exalted {userNick}");
        }
    }
}
