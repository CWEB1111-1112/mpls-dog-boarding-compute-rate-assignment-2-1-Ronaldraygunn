using System;
//Comment Latest Name and Date
namespace assignment_four
{
    class Program
    {
        static void Main(string[] args)
        {
            //Global Declarations

            welcomeUser();

            double daysOfCare;
            int addOns;
            string serviceCode;

            double serviceCodeA = 169.00;
            double serviceCodeC = 112.00;

            Console.WriteLine("How many days will your dog be staying with us");
            daysOfCare = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Will you require addition services?\nEnter 1 for no and 2 for yes:");
            addOns = Convert.ToInt32(Console.ReadLine());

            if(addOns == 1)
            {
                Console.WriteLine(computeRate(daysOfCare));

            }

            if(addOns == 2)
            {
                Console.WriteLine("Enter the service package you would like to add to the boarding\nA - Bathing and Grooming - $169.00/day\nC - Bathing - $112.00/day");
                serviceCode = Console.ReadLine();
                serviceCode = serviceCode.ToUpper();
                
                

                if(serviceCode == "A")
                {
                    Console.WriteLine(computeRate(daysOfCare, serviceCodeA));

                }
                
                if(serviceCode == "C")
                {
                    Console.WriteLine(computeRate(daysOfCare, serviceCodeC));

                }
                
                else
                {
                    Console.WriteLine("ERROR: Please select a valid service code (A or C)");

                }

                goodbyeUser();
                
            }


            

        }

        //Overloaded method with one argument

        public static string computeRate(double daysOfCare)
        {
            double basePrice = 75.00;

            return string.Format($"The cost for your dog boarding will be {(daysOfCare * basePrice).ToString("c")}");



        }
        
        //Overloaded method with two arguments

        public static string computeRate(double daysOfCare, double serviceCodeCost)
        {

            

            return string.Format($"The cost of boarding with your chosen service package will be {(daysOfCare * serviceCodeCost).ToString("c")}");

        }

        public static void welcomeUser()
        {
             Console.WriteLine("Welcome to MPLS Dog Boarding. Please press enter to begin booking.");
             Console.ReadKey();
        }

        public static void goodbyeUser()
        {
             Console.WriteLine("Thank you for using MPLS dog boarding.");
             Console.ReadKey();
        }

        


    
    }
}
