using System;
using System.Collections.Generic;
using System.Text;

namespace LogicApp
{
   
    public class ExamLogic
    {
        public static void Main(string[] args)
        {
            //Exam Logic
            bool homeworkDone = true;
            bool roomCleaned = false;

            if (homeworkDone && roomCleaned)
            {
                Console.WriteLine("You Can Play");
            }
            else 
            {
                Console.WriteLine("Finish your Task");
            }

            //Is today a day off?
            bool isWeekend = false;
            bool isHoliday = true;

            if(isWeekend && isHoliday)
            {
                Console.WriteLine("Working day");
            }
            else if(isWeekend || isHoliday)
            {
                Console.WriteLine("Day off");
            }
            //Check an age range — AND
            int age = 18;
            if (age >= 18 && age <= 30)
            {
                Console.WriteLine("Age accepted");
            }
            else
            {
                Console.WriteLine("Age not accepted");
            }
            //Join a programming course — AND with OR
            int agee = 20;
            bool knowsCSharp = false;
            bool knowsPython = true;

            if (agee >= 18 && (knowsCSharp || knowsPython))
            {
                Console.WriteLine("Can join");
            }
            else
            {
                Console.WriteLine("Cannot join");
            }

            //Enter an event — two possible routes
            bool hasTicket = true;
            bool hasId = false;

            bool isGuest = true;
            bool hasInvitation = true;
            if ((hasTicket && hasId) || (isGuest && hasInvitation))
            {
                Console.WriteLine("Entry allowed");
            }
            else
            {
                Console.WriteLine("Entry denied");
            }
        }
    }
}
