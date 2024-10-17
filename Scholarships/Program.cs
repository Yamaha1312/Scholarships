using Scholarships.Controllers;

namespace Scholarships
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ScholarshipController controller = new ScholarshipController();
            controller.Run();
        }
    }
}