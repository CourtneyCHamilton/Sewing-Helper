using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_Part2
{
    internal class ToDoList
    {
        private string name; //name of person sewing
        private string project; //name of the sewing project
        private string fabric; //type of fabric needed
        private double meters; //number of meters needed
        DateTime today = DateTime.Now;

        public void getName() 
        {
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("Thanks, " + name + " !");
        }

        public void getProjectName() 
        {
            Console.WriteLine("What are you planning to sew today " + name + "?");
            project = Console.ReadLine();
            Console.WriteLine("That sounds like a cool project.");
        }

        public void getFabric()
        {
            Console.WriteLine("What kind of fabric does " + project + " require? ");
            fabric = Console.ReadLine();
        }

        public void getMeters()
        {
            Console.WriteLine("How many meters of " + fabric + " does " + project + " require?");
            meters = double.Parse(Console.ReadLine());
        }

        public void displayInput()
        {
            Console.WriteLine(name + ", you will need " + meters + " meters of " + fabric + " fabric to complete " + project + "!");
            Console.WriteLine(name + ", you started your project: " + project + " on " + today + ". ");
        }

        public void Start()
        {
            Console.WriteLine("Welcome to the Sewing helper program!");
            getName();
            getProjectName();
            getFabric();
            getMeters();
            displayInput();
        }
    }
}
