using Marbles;
using System.Text;


Marble marble1 = new Marble(1, "blue", "Bob", 0.5);
Marble marble2 = new Marble(2, "red", "John Smith", 0.25);
Marble marble3 = new Marble(3, "violet", "Bob O' Bob", 0.5);
Marble marble4 = new Marble(4, "indigo", "Bob Dad-Bob", 0.75);
Marble marble5 = new Marble(5, "yellow", "John", 0.5);
Marble marble6 = new Marble(6, "orange", "Bob", 0.25);
Marble marble7 = new Marble(7, "blue", "Smith", 0.5);
Marble marble8 = new Marble(8, "blue", "Bob", 0.25);
Marble marble9 = new Marble(9, "green", "Bobb Ob", 0.75);
Marble marble10 = new Marble(10, "blue", "Bob", 0.5);



List<Marble> inputMarbles = new List<Marble>();

inputMarbles.Add(marble1);
inputMarbles.Add(marble2);
inputMarbles.Add(marble3);
inputMarbles.Add(marble4);
inputMarbles.Add(marble5);
inputMarbles.Add(marble6);
inputMarbles.Add(marble7);
inputMarbles.Add(marble8);
inputMarbles.Add(marble9);
inputMarbles.Add(marble10);

Console.WriteLine("Input Marbles:");
Console.WriteLine("----------------------------");
foreach (Marble marble in inputMarbles)
{
    Console.WriteLine("Marble - " + marble + ", Palindrome? " + StringHelper.IsPalindrome(marble.Name));
}

Console.WriteLine("");
Console.WriteLine("Sorted and Filtered Marbles");
Console.WriteLine("-----------------------------");

List<Marble> outputMarbles = MarbleProcessor.ShortAndFilter(inputMarbles);

foreach (Marble marble in outputMarbles)
{
    Console.WriteLine("Marble - " + marble + ", Palindrome? " + StringHelper.IsPalindrome(marble.Name));
}