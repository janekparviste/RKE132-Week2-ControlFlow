// See https://aka.ms/new-console-template for more information

//rakendus palub kasutajal sisestada tema vanuse
//kui kasutaja vanus on väiksem kui 13, siis konsoolis kuvatatakse 
//"You are too young to use Instagram"
//Muul juhul
//konsoolis kuvatakse "Welcome to Instagram"

Console.WriteLine("Enter your age:");

string userAge = Console.ReadLine(); //"13" - heap, 13 - stack

int userAgeNum = 0;

//boolean - true/false

bool isAgeNumber = Int32.TryParse(userAge, out userAgeNum);

Console.WriteLine($"Parse result {isAgeNumber}. User is {userAgeNum} years old.");

if(isAgeNumber)
{
    if(userAgeNum >= 13)
    {
        Console.WriteLine("Welcome to Instagram!"); 
    }
    else
    {
        Console.WriteLine("You are too young to use Instagram!");
    }
}
else
{
    Console.WriteLine("Could not read your age.");
}