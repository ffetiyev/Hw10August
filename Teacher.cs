

namespace HW10August
{
    internal class Teacher : Person
    {

        public Teacher(string message) : base(message)
        {
            Console.WriteLine(message);
        }

        public Teacher(int a) : base(a)
        {
            Console.WriteLine(a);
        }

        public int salary;

    }
}
