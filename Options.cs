using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitBite
{
    public class Options
    {
        public void ChooseOption(UserInfo userInfo)
        {
            Console.WriteLine($"{userInfo.Weight} {userInfo.Height}");
            Console.WriteLine("Choose an option:");
            Console.WriteLine("");
            Console.WriteLine("1. Calculate BMI");
            Console.WriteLine("");
            Console.WriteLine("2. Calculate Daily Protain Dose");
            int option = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            switch (option)
            {
                case 1:
                    CalcBMI(userInfo);
                    break;
                case 2:
                    CalcProtein(userInfo);
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }


        private void CalcBMI(UserInfo userinfo)
        {
            BmiCalculator calcBMI = new BmiCalculator();
            double bmi = calcBMI.CalcBMI(userinfo.Weight, userinfo.Height);
            Console.WriteLine($"Your BMI is: {bmi}");
            string bmiLevels = calcBMI.BmiLevels(bmi);
            Console.WriteLine("");
            Console.WriteLine($"*** World Health Organization's recommended body\nweight" +
                $" based on your BMI value is --{bmiLevels}--");
            Console.WriteLine("");
        }

        private void CalcProtein(UserInfo userInfo)
        {
            ProteinCalculator proteinCalc = new ProteinCalculator();
            double dailyProtein = proteinCalc.CalcDailyProtein(userInfo.Weight, userInfo.Height,
                userInfo.Age, userInfo.Gender, userInfo.Activity, userInfo.weightGoal );
            Console.WriteLine($"*** Your Daily Protein Dose is {dailyProtein}");
        }
    }    

}


