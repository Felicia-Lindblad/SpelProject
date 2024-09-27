namespace SpelProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            playerOption();

            Player player = new Player(10, 2);
            Enemy enemy = new Enemy(8, 1);

            string optinChoosed = Console.ReadLine()!;

            if (optinChoosed == "a")
            {
                player.Attack();
            } else if (optinChoosed == "h")
            {
                player.Heal(); 
            }
            
            
            
        }

        static void playerOption()
        {
            Console.WriteLine("Let the game begin");
            Console.WriteLine("Choose your action");
            Console.WriteLine("a - attack");
            Console.WriteLine("h - heal");
        }
    }
}
