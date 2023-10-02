namespace SelStatementsDemoCSharp_41
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //If/Else

            //bool condition = true;

            //if(condition == true)
            //{
            //    Console.WriteLine("Path 1");
            //}
            //else
            //{
            //    Console.WriteLine("Failsafe");
            //}


            //int a = 20;
            //int b = 10;

            //if(a == b)
            //{
            //    Console.WriteLine($"{a} and {b} are equal");
            //}
            //else if(a < b && a == 5)
            //{
            //    Console.WriteLine($"{a} less than {b} and {a} is 5");
            //}
            //else
            //{
            //    Console.WriteLine("None of these were true");
            //}


            //int i = -1;

            //string message = (i > 0) ? "Positive" : (i == 0) ? "Zero" : "Negative";

            //Console.WriteLine(message);

            //Switch/Case

            string day = "Funday";

            switch(day)
            {
                case "Sunday":
                case "sunday":
                    Console.WriteLine("Sunday is cool");
                    break;
                case "Monday":
                    Console.WriteLine("Mondays are tough");
                    break;
                case "Tuesday":
                    Console.WriteLine("Tuesday");
                    break;
                case "Wednesday":
                    Console.WriteLine("Wednesday");
                    break;
                case "Thursday":
                    Console.WriteLine("Thursday");
                    break;
                case "Friday":
                    Console.WriteLine("Friday");
                    break;
                case "Saturday":
                    Console.WriteLine("Saturday is the best");
                    break;
                default:
                    Console.WriteLine("Not a day of the week");
                    break;
            }


        }
    }
}