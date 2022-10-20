//Maddie Gowan
//10-18-2022
//Mini Challenge #4 - Mad Lib
//This is a redo of an old assignment

Console.Clear();

Console.WriteLine("Hello! This is Maddie's Madlib. A madlib is a story where various words");
Console.WriteLine("are left blank, giving you the ability to insert various things. These");
Console.WriteLine("may include verbs, nouns, adjectives, etc. They also may get more specific,");
Console.WriteLine("asking for an animal, person, place, etc.");
Console.WriteLine("Would you like to play? Y or N: ");
string play = Console.ReadLine().ToUpper();

if (play != "Y" && play != "N")
{
    Console.WriteLine("This is not a valid response. Try again.");
    Console.WriteLine("Would you like to play? Y or N: ");
    play = Console.ReadLine();
}
else if (play == "N")
{
    Console.WriteLine("Okay, goodbye.");
}
while (play == "Y")
{
    Console.Write("Please enter a place: ");
    string place1 = Console.ReadLine();
    Console.Write("Now please give me an adjective: ");
    string adjective2 = Console.ReadLine();
    Console.Write("How about your favorite animal: ");
    string animal3 = Console.ReadLine();
    Console.Write("Now I need a verb ending in -ing: ");
    string verb4 = Console.ReadLine();
    Console.Write("Okay, I need a person: ");
    string person5 = Console.ReadLine();
    Console.Write("Can I get another verb, ending in -ed: ");
    string verb6 = Console.ReadLine();
    Console.Write("What about a noise: ");
    string noise7 = Console.ReadLine();
    Console.Write("Okay, this time I need a different person: ");
    string person8 = Console.ReadLine();
    Console.Write("I request any object: ");
    string object9 = Console.ReadLine();
    Console.Write("Perhaps another verb ending in -ing: ");
    string verb10 = Console.ReadLine();

    Console.WriteLine("Okay, here's the story we made together!");


    Console.WriteLine($"Once in a place called {place1} there was a/n {adjective2} {animal3}.");
    Console.WriteLine($"They were {verb4} around, when suddenly, {person5}");
    Console.WriteLine($" blocked the way. The little guy {verb6} at them, and in response ");
    Console.WriteLine($"they only heard a {noise7}. So they turned around, intending to leave.");
    Console.WriteLine($"But behind them, they found {person8}. They were surrounded. Suddenly");
    Console.WriteLine($"everyone simultaneously whipped out a/n {object9}. It was a stand off. This little");
    Console.WriteLine($"guy was clearly not going down without a fight. After a tense moment, the people retreated, and satisfied with");
    Console.WriteLine($"their victory, the creature spent the rest of its evening {verb10}.");

    Console.WriteLine("I liked it! Would you like to play again? Y or N: ");
    play = Console.ReadLine().ToUpper();

}
