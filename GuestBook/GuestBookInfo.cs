using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBook
{
    public static class GuestBookInfo
    {
        public static string GetPartyName()
        {

            Console.Write("What is your party/group name: ");
            string? userOutput = Console.ReadLine();

            return userOutput;
        }

        public static int GetPartySize()
        {
            bool isValidValue;
            int userOutput;

            do
            {
                Console.Write("How many people are in your party group: ");
                string? partySizeText = Console.ReadLine();
                isValidValue = int.TryParse(partySizeText, out userOutput);
                if (!isValidValue)
                {
                    Console.WriteLine("You entered invalid characters!");
                }
            } while (isValidValue == false);

            return userOutput;
        }

        public static (List<string> guests, int total) GetAllGuests()
        {
            int totalGuests = 0;
            List<string> guests = new();

            do
            {
                guests.Add(GetPartyName());

                totalGuests += GetPartySize();

                Console.WriteLine();

            } while (AskToContinue());

            return (guests, totalGuests);
        }

        public static void DisplayGuests(List<string> guests)
        {
            Console.WriteLine("The members of the event were:");
            foreach (string guest in guests)
            {
                Console.WriteLine(guest);
            }
            Console.WriteLine();
        }

        public static bool AskToContinue()
        {
            Console.WriteLine("Are there more guests coming? Type yes or no: ");
            string? userResponse = Console.ReadLine();
            Console.WriteLine();

            bool output = (userResponse.ToLower() == "yes");

            return output;
        }
    }
}
