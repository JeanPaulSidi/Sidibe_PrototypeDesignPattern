namespace Sidibe_PrototypeDesignPattern
{
    internal class Program
    {

        /*  PROTOTYPE DESIGN PATTERN

         Prototype is a creational design pattern that lets you copy existing objects.
         It's mainly useful when creating new objects is more complex or costly than copying existing ones.
         In addition to this, it is useful when we want to hide the creation of object.

        https://simpletechtalks.com/wp-content/uploads/2015/08/prototype_design_pattern.png

        */


        static ConsoleKeyInfo DisplayMenu() 
        {
            ConsoleKeyInfo UserChoice;

            Console.WriteLine("Welcome back! What would you like to do?");
            Console.WriteLine();
            Console.WriteLine("1. Clone the car prototype      2. Clone the motorbike prototype");

            do 
            {
                UserChoice = Console.ReadKey(true);

            }while (UserChoice.Key != ConsoleKey.D1 &&  UserChoice.Key != ConsoleKey.D2);

            return UserChoice;
        }
        static void Main(string[] args)
        {
            ConsoleKeyInfo UserChoice;
            Prototype Clone;
            string Message = string.Empty;

            Console.Clear();
            UserChoice = DisplayMenu();

            if (UserChoice.Key == ConsoleKey.D1)
            {
                Clone = new CarPrototype().CreateClone(); 
            }
            else
            {
                Clone = new MotorBikePrototype().CreateClone();
            }

            Console.WriteLine();

            if (!(Clone == null))
            {
                Console.Clear();
                Message = Clone.PrintCloneInformation();
                Console.WriteLine(Message);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Clone creation failed.");
            }

        }
    }
}