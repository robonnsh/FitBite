using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitBite
{
    public class UserInfo
    {
        public int Age { get; set; }
        public int Gender { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public int weightGoal { get; set; }
        public int Activity { get; set; }

        ProteinCalculator proteinCalc = new ProteinCalculator();
        public void AdditionalInfo()
        {
            Console.WriteLine("");
            Console.WriteLine("Enter your age: ");
            Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Gender: ");
            Console.WriteLine("1. Men");
            Console.WriteLine("2. Woman");
            Gender = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Enter your height (in cm): ");
            Height = double.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Enter your weight (in kg): ");
            Weight = double.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Select your exercise mode: ");
            Console.WriteLine("");
            Console.WriteLine("1. Sedentary");
            Console.WriteLine("'Little or no exercise'");
            Console.WriteLine("");
            Console.WriteLine("2. Light");
            Console.WriteLine("'Exercise 1-3 times/week'");
            Console.WriteLine("");
            Console.WriteLine("3. Moderate");
            Console.WriteLine("'Exercise 4-5 times/week'");
            Console.WriteLine("");
            Console.WriteLine("4. Very Active");
            Console.WriteLine("'Intense exercise 6-7 times/week'");
            Console.WriteLine("");
            Console.WriteLine("5. Extra Active");
            Console.WriteLine("'Very intense exercise daily'");
            Console.WriteLine("");
            Activity = int.Parse(Console.ReadLine());
            proteinCalc.ActivityFactor(Activity);
            Console.WriteLine("");
            Console.WriteLine("What is your weight goal?");
            Console.WriteLine("");
            Console.WriteLine("1. Maintain current weight");
            Console.WriteLine("");
            Console.WriteLine("2. Lose Weight");
            Console.WriteLine("");
            Console.WriteLine("3. Gain weight");
            weightGoal = int.Parse(Console.ReadLine());
            proteinCalc.WeightGoalFactor(weightGoal);
            Console.Clear();
            Console.WriteLine("--Your information saved successfully--");
            Console.WriteLine("");
        }


        public void ProcessOptions()
        {
            Options option = new Options();
            option.ChooseOption(this);
        }


        ///// shevcvalo BMI gamotvlis dros santimetri - metrshi ///////


    }
}
