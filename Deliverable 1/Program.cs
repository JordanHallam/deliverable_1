using System;
using System.Runtime.ExceptionServices;
using System.Text.RegularExpressions;

namespace Deliverable_1
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Would you like to go on a musical, tropical, or adventurous vacation?");
            string vacation_type = Console.ReadLine();
            
            Console.WriteLine("How many people are in your group?");
            int group_size = int.Parse(Console.ReadLine());

            string destination= "placeholder";
            if (vacation_type == "musical")
            { destination = " take a trip to New Orleans"; }
            else if (vacation_type == "tropical")
            { destination = "take a beach vacation in Mexico"; }
            else if (vacation_type == "adventurous" )
            { destination = "go whitewater rafting in the Grand Canyon"; }
            

            string travel_suggestion = "placeholder";
            if (group_size > 0 && group_size <= 2)
            { travel_suggestion = "first class"; }
            else if (group_size >= 3 && group_size <= 5)
            { travel_suggestion = "helicopter"; }
            else if (group_size >= 6)
            { travel_suggestion = "chartered flight"; }
            


            string result = ("A " + vacation_type + " vacation sounds great! " +
                "Since you have " + group_size + " people in your group, I suggest you " + destination + " via " + travel_suggestion);

            Console.WriteLine(result);
      
            
         
            }


        }
    }

