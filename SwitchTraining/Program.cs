namespace SwitchTraining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nu ska vi ut på äventyr! Mata in en bokstav för väderstrecken: ");
            string direction = Console.ReadLine();

            switch (direction)
            {
                case "n":
                case "N":
                    Console.WriteLine("You walk north.");
                    break;
                case "e":
                case "E":
                    Console.WriteLine("You wander east.");
                    break;
                case "s":
                case "S":
                    Console.WriteLine("You travel south.");
                    break;
                case "w":
                case "W":
                    Console.WriteLine("You stroll west.");
                    break;
                default:
                    Console.WriteLine("I don't understand!");
                    break;
            }
        }
    }
}