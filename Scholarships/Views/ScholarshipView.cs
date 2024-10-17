using Scholarships.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scholarships.Views
{
    public class ScholarshipView
    {
        public decimal GetIncome()
        {
            Console.Write("Въведете доход: ");
            return decimal.Parse(Console.ReadLine());
        }

        public decimal GetAverageGrade()
        {
            Console.Write("Въведете средна оценка: ");
            return decimal.Parse(Console.ReadLine());
        }

        public decimal GetMinimumWage()
        {
            Console.Write("Въведете минимална заплата: ");
            return decimal.Parse(Console.ReadLine());
        }

        public void DisplayResult(ScholarshipModel model)
        {
            if (!model.CanGetScholarship)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            else
            {
                if (model.CanGetSocialScholarship && model.SocialScholarship >= model.ExcellentScholarship)
                {
                    Console.WriteLine($"You get a Social scholarship {model.SocialScholarship} BGN");
                }
                else if (model.CanGetExcellentScholarship)
                {
                    Console.WriteLine($"You get a scholarship for excellent results {model.ExcellentScholarship} BGN");
                }
            }
        }
    }
}
