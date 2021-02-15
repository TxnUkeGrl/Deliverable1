using System;

namespace Deliverable_1
{
    class Program
    {
		public static void Main()
		{ // continue to ask if new caluclation
			do
			{
				// assuming valid inputs for type
				Console.WriteLine("Please enter a measurement type: ");
				string InputMeasure = Console.ReadLine();
				// assume valid inputs for amount
				Console.WriteLine("Please enter an amount: ");
				double InputAmount = double.Parse(Console.ReadLine());
				// conversion chart
				double Inch = 3.5;
				double Foot = 5;
				double FidgetSpinner = 0.2857142857;
				double Meme = 0.2;
				double Answer = 0;
				string NewMeasure = " ";
				// applying conversions
				if (InputMeasure == "inch")
				{
					Answer = InputAmount * Inch;
					NewMeasure = "fidget spinner";
				}
				else if (InputMeasure == "foot")
				{
					Answer = InputAmount * Foot;
					NewMeasure = "meme";
				}
				else if (InputMeasure == "fidget spinner")
				{
					Answer = InputAmount * FidgetSpinner;
					NewMeasure = "inch";
				}
				else if (InputMeasure == "meme")
				{
					Answer = InputAmount * Meme;
					NewMeasure = "feet";
				}

				// produce answer
				Console.WriteLine(InputAmount + " " + InputMeasure + " is equal to " + Answer + " " + NewMeasure);
				// prompt for new calculation
				Console.WriteLine("Would you like to do another calculation?");
			}
			while (Console.ReadLine() == "yes");
		}
	}
}
