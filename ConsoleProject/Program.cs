using System;
using TreeParsing.Classes;
using TreeParsing.Controller;

namespace ConsoleProject
{
    internal class Program
    {
        private static Controller _controller;
        static void Main(string[] args)
        {
            _controller = new Controller(new TreeController(new PostOrderTraversal()));

            Console.WriteLine("Type your input with no spaces and each integer separated by commas, i.e.: 10,2,6,7");
            Console.WriteLine("Type close to terminate the execution.");
            Console.WriteLine("");

            Console.Write("Your input: ");
            string input = Console.ReadLine();

            while(input.ToLower() != "close")
            {
                _controller.ProcessInput(input);
                Console.WriteLine("");
                Console.WriteLine("Post-order traversal:");
                Console.WriteLine(_controller.GetPostOrderTraversal());
                Console.WriteLine("__________________________");
                Console.WriteLine("");

                Console.Write("Your input: ");
                input = Console.ReadLine();
            }
        }
    }
}
