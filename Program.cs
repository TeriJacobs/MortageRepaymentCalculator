using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===============================================");
            Console.WriteLine("Mortage Repayment Calculator");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Please enter the required values to determine your monthly loan repayments");
            Console.WriteLine("===============================================");

            Console.WriteLine("What is the value of your Loan?");

            double principalLoan = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your loan term duration in years");
            double yearDuration = Convert.ToInt32(Console.ReadLine());
            double months = yearDuration * 12;

            Console.WriteLine("Enter interest:");
            double interestRate = Convert.ToInt32(Console.ReadLine());


            double rate = ((interestRate / 100) / 12);
            double rateValue = rate + 1;
            double iNumerator = (Math.Pow(rateValue, (-months)));
            double iN = 1 - iNumerator;
            double iM = iN / rate;


            //double interest = Console.ReadLine();

            // Print the value of the variable
            //Console.WriteLine("Your interest is " + interestRate);
            //Console.WriteLine("Your i " + rate);
            //Console.WriteLine(rateValue);
            //Console.WriteLine(iNumerator);
            //Console.WriteLine(iN);

            double R = principalLoan / iM;
            Console.WriteLine("Your monthly repayments are: R" + R);


            Console.WriteLine("===============================================");
            Console.WriteLine("Here are additional details on the affect the interest has on your repayments");
            Console.WriteLine("===============================================");

            //Console.WriteLine("The number of payments it actually would take to clear your loan without interest " + iM);
            double repaidYears = iM / 12;
            Console.WriteLine("The number of years it actually would take to clear your loan without interest " + repaidYears);

            double overAll = R * months;
            Console.WriteLine("Value over the duration R" + overAll);

            double interestRepayments = overAll - principalLoan;
            Console.WriteLine("You would pay R" + interestRepayments + " toward the overall interst on your loan");

        }
    }
}
