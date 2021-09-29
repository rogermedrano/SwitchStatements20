using System;

namespace SwitchStatements20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess my favorite school subject:");
            var yourAnswer = Console.ReadLine();

            switch (yourAnswer.ToLower())
            {
                case "math":
                    Console.Write("Math is hard, but is a necessesary subject. Not my fvorite though!");
                    break;

                case "english":
                    Console.Write("English is a good subject, but it's rather boring. Try again.");
                    break;

                case "art":
                    Console.Write("Art is great, but it's more of a hobby to me. I don't really consider it a 'subject'");
                    break;

                case "lunch":
                    Console.Write("Come on, let's be real...");
                    break;

                case "physics":
                    Console.Write("You are correct!  Physics is my favorite subject because I love seeing how things work!");
                    break;

                default:
                    Console.Write("I never heard of that subject.  It sounds interesting though.");
                    break;
            }




        }
    }
}
