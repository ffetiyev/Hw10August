

namespace HW10August
{
    internal class Person
    {
        public int id;
        public string name;
        public string surname;
        public int age;

        public Person(int a)
        {
            Console.WriteLine("Person ctor1");
        }
        public Person(string text)
        {
            Console.WriteLine("Constructor is working");
        }

        public void Test()
         {
        Console.WriteLine("Test method is working");
         }

    }
}
