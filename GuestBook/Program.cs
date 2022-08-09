using GuestBook;


Console.WriteLine("Hello, welcome to the Guest Book App");
Console.WriteLine("************************************");
Console.WriteLine();

(List<string> guests, int totalGuests) = GuestBookInfo.GetAllGuests();

GuestBookInfo.DisplayGuests(guests);

Console.WriteLine("Thank you for attending!");
Console.WriteLine($"The total guest count for this event was {totalGuests}.");







