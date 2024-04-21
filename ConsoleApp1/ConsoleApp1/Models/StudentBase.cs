namespace ConsoleApp1.Models
{
    internal class StudentBase
    {
        public void Hunt<T>(T prey) where T : Student;
    }
}