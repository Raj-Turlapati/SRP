using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using URHealth.Service.BMI;

namespace SRPDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********* UR Health BMI Calculator *********** \n");

            Console.WriteLine("********* BMI Categories *********** \n");
            Console.WriteLine(" Under Weight =< 18.5 \n Normal Weight > 18.5 And <= 24.9 \n Overweight > 25 And <= 29.9 \n Obesity >=30\n");
            Console.WriteLine("********* End of BMI Categories *********** \n");

            ICalculate bmiCalculator = new BMICalculator();

            Console.WriteLine("Enter weight in Kilog grams...");

            float weightInKg;
            float.TryParse(Console.ReadLine(), out weightInKg);

            Console.WriteLine("Enter height in Meters...");

            float heightInMeters;
            float.TryParse(Console.ReadLine(), out heightInMeters);

            bmiCalculator.WeightInKg = weightInKg;
            bmiCalculator.HeightInMeters = heightInMeters;

            float BMI = (float)Math.Round(bmiCalculator.Calculate(), 1);

            Console.WriteLine("Your BMI is : {0} && BMI Category : {1}", BMI, BMICategory.GetBMICategory(BMI));

            Console.WriteLine("*********  ***********");
            Console.Read();

        }
    }
}
