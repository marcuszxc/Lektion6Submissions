namespace Övning2
{
    internal class Person
    {
        string name;
        int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public override string ToString()
        {
            return $"The persons name is {this.name} and there age is {this.age}";
        }

    }
}
