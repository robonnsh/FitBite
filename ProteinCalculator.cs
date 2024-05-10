using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitBite
{
    internal class ProteinCalculator
    {


        public double BmrCalc(double weight, double height, int age, int gender)
        {
            double bmr;

            if (gender == 1)
            {
                bmr = (10 * weight) + (6.25 * height) - (5 * age) + 5;
            }
            else
            {
                bmr = (10 * weight) + (6.25 * height) - (5 * age) - 161;
            }
            return bmr;
        }

        public double AdjustCalories(double bmr, double activityFactor, int goal)
        {
            double adjustCalories = bmr * activityFactor;
            if (goal == 2)
            {
                adjustCalories *= 0.8;
            } else if (goal == 3)
            {
                adjustCalories += 500;
            }

            return adjustCalories;
        }

        public double CalcDailyProtein(double weight, double height, int age, int gender,
                                       double activityFactor, int weightGoal)
        {
            double bmr = BmrCalc(weight, height, age, gender);
            double adjustedCalories = AdjustCalories(bmr, activityFactor, weightGoal);
            double totalProteint = bmr * adjustedCalories;

            return totalProteint;
        }

        public double ActivityFactor(int activityChoice)
        {
            switch (activityChoice)
            {
                case 1: //sedentary
                    return 1.2;
                case 2: //light
                    return 1.375;
                case 3: //moderate
                    return 1.55;
                case 4: //very active
                    return 1.725;
                case 5: //extra active
                    return 1.9;
                default:
                    return 1.2;
            }
        }

        public int WeightGoalFactor(int weightGoal)
        {
            switch (weightGoal)
            {
                case 1:
                    return 1;
                case 2:
                    return 2;
                case 3:
                    return 3;
                default:
                    return 1;
            }
        }

        internal double CalcDailyProtein(double weight, double height, int age, int gender)
        {
            throw new NotImplementedException();
        }
    }
}
