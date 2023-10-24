namespace Part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog("Peter", "Black", 50, 2);
            dog1.Eat();
            Console.WriteLine(dog1.Cry());

            Cat cat1 = new Cat("Angel", "Black", 25, 5);
            cat1.Eat();
            Console.WriteLine(cat1.Cry());
        }
    }
}