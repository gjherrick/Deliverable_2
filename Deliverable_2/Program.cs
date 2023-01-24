namespace Deliverable_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, please input the grade you expect to get in ISM 4300:");
            try
            {
                decimal classGrade = decimal.Parse(Console.ReadLine()); ;
                string letterGrade;

                if ((classGrade > 89) && (classGrade < 100))
                {
                    letterGrade = "A";
                    Console.WriteLine("Your expected letter grade is: " + letterGrade);
                    Console.ReadKey(true);
                }
                else if ((classGrade > 80) && (classGrade < 90))
                {
                    letterGrade = "B";
                    Console.WriteLine("Your expected letter grade is: " + letterGrade);
                    Console.ReadKey(true);
                }
                else if ((classGrade > 70) && (classGrade < 80))
                {
                    letterGrade = "C";
                    Console.WriteLine("Your expected letter grade is: " + letterGrade);
                    Console.ReadKey(true);
                }
                else if ((classGrade > 60) && (classGrade < 70))
                {
                    letterGrade = "D";
                    Console.WriteLine("Your expected letter grade is: " + letterGrade);
                    Console.ReadKey(true);
                }
                else if ((classGrade < 60) && (classGrade > 0))
                {
                    letterGrade = "F";
                    Console.WriteLine("Your expected letter grade is: " + letterGrade);
                    Console.ReadKey(true);
                }
                else if (classGrade < 0)
                {
                    Console.WriteLine("Please input a number greater than 0");
                }
            }
            catch
            {
                Console.WriteLine("Please enter a decimal number");
            }
        }
    }
}