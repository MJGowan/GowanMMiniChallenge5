//Maddie Gowan
//10-18-2022
//Mini Challenge #4 - Redo
//In this program we have to create a MadLib, allowing the user to input various
//words which will then combine together cleanly into a story.

//Review by Daniel Decoito: Everything works as intended but there are a few issues.
//First I felt that the user experience is not taken into consideration. It works as a
//project because it meets the base criteria but more could have been implemented to
//make the user more aware of what theyre supposed to do. Perhaps explain to them the
//rules of madlibs and inform them that they are supposed to type in responses to
//specific console prompts. Second, nothing was added to improve the base code since
//the initial assignment was given. A good suggestion would be using string
//interplotion to make the code cleaner. Finally, the loop mechanisim has issues.
//If you put in an incorrect Character you will be prompted to renter the character
//correctly. However, whatever the user inputs, correct or incorrect, will cause the
//game to terminate. I think the issue is due to the if statment that triggers the
//terminate game being outside the while loop.

//Response by Madeline Gowan: I did my best to take this advice and make my program
//better in terms of user experience, by explaining the code and the program as well
//as adding friendlier responses. I adjusted the if statements and while loop to
//hopefully fix the issue with the game being terminated. I also used string
//interpolation to clean up the code, as suggested. Thank you very much for the review! It helped a lot.


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
