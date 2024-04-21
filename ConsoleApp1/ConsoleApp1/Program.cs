using ConsoleApp1.Models;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Wolf wolf = new Wolf(10, "Siberian", 70, true, 100, Animal.Gender.Male);
            Console.WriteLine(wolf.Breed);
            Elephant elephant = new Elephant(25, "african", 90, 250, false, Animal.Gender.Female);
            wolf.Hunt(elephant);
            Console.WriteLine(elephant.Hp);
            Meet meet = new Meet(25, Meet.Type.Baliq);

            ZooCage<Wolf, Meet> wolfCage = new ZooCage<Wolf, Meet>(wolf, meet);

            //3
            Student student = new Student("Steve", false, true);
            Lion lion = new Lion(30, "Panthera", 89, Animal.Gender.Male);
            /*if (student is Animal)
            {
                lion.Hunt(student);
            }*/

            lion.Hunt(student);
            /*student.Hunt(student);*/
            Console.WriteLine(student.Name);
        }
    }
}
