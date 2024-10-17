using Scholarships.Models;
using Scholarships.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scholarships.Controllers
{
    public class ScholarshipController
    {
        private ScholarshipModel model;
        private ScholarshipView view;

        public ScholarshipController()
        {
            model = new ScholarshipModel();
            view = new ScholarshipView();
        }

        public void Run()
        {
            decimal income = view.GetIncome();
            decimal averageGrade = view.GetAverageGrade();
            decimal minWage = view.GetMinimumWage();

            model.CalculateScholarships(income, averageGrade, minWage);

            view.DisplayResult(model);
        }
    }
}
