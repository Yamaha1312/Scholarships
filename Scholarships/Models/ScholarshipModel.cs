using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scholarships.Models
{
    public class ScholarshipModel
    {
        public decimal SocialScholarship { get; private set; }
        public decimal ExcellentScholarship { get; private set; }
        public bool CanGetScholarship { get; private set; }
        public bool CanGetSocialScholarship { get; private set; }
        public bool CanGetExcellentScholarship { get; private set; }

        public void CalculateScholarships(decimal income, decimal averageGrade, decimal minWage)
        {
            SocialScholarship = 0;
            ExcellentScholarship = 0;
            CanGetScholarship = false;
            CanGetSocialScholarship = false;
            CanGetExcellentScholarship = false;

            if (income < minWage && averageGrade > 4.5m)
            {
                SocialScholarship = Math.Floor(0.35m * minWage);
                CanGetSocialScholarship = true;
            }

            if (averageGrade >= 5.5m)
            {
                ExcellentScholarship = Math.Floor(averageGrade * 25);
                CanGetExcellentScholarship = true;
            }

            if (CanGetSocialScholarship || CanGetExcellentScholarship)
            {
                CanGetScholarship = true;
            }
        }
    }
}
