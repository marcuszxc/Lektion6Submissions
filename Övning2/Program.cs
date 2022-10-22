using ConsoleClasses;
using System.Collections;
namespace Övning2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ArrayList list = new ArrayList(3);

            Console.WriteLine("Please input the name and age for three people");

            for (int i = 0; i < 3; i++)
            {
                Person person = new Person(UserInput.AskForString("Name: "), UserInput.AskForInt("Age: "));
                list.Add(person);
            }

            foreach (Person person in list)
            {
                Console.WriteLine(person.ToString());
            }

        }
    }
}