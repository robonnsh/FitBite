using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitBite
{
    internal class BmiCalculator
    {
        public double CalcBMI(double weight, double height)
        {
            if (height <= 0 || weight <= 0)
            {
                Console.WriteLine("Error: Height and weight must be positive values.");
                return 0; 
            }
            double bmi = weight / (height * height);
            return Math.Round(bmi, 1);
        }

       public string BmiLevels(double bmi)
        {
            if (bmi < 18.5)
            {
                return "Underweight";

            }else if (bmi >= 18.5 && bmi < 25)
            {
                return "Normal weight";

            }else if (bmi >= 25 && bmi < 30)
            {
                return "Overweight";

            }else
            {
                return "Obese";
            }
        }
    }
}
