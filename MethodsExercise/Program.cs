namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to this TrueCoders story.");
             
            Console.Write("Enter thy name, brave warrior: ");
            string Name = Console.ReadLine();    
            
            Console.Write("What tis your favorite color? : ");
            string Color = Console.ReadLine(); 
            
            Console.Write("What tis your steed's name? : ");
            string Animal = Console.ReadLine();
            
            Console.Write("Who is thy favorite jester?: ");
            string Jester = Console.ReadLine();
            
            Console.WriteLine($"I am a True Coder's Warrior. My name is {Name}. The color of my shield is {Color}. " +
                              $"The name of my transportation is {Animal}. My favorite rock band is {Jester}.");

        }
        static string MethodsExercise(string Name, string Color, string Animal, string Jester)
        {
            Console.WriteLine($"{Name}, {Color}, {Animal}, {Jester}");
            return $"{Name}, {Color}, {Animal}, {Jester}";
        }

    }
}
