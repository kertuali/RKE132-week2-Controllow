// See https://aka.ms/new-console-template for more information

//rakendus k[sib kasutajal sisestada tema vanus
//kui kasutaja vanus on v'iksem kui 13, siis konsoolis kuvatakse
//"You are too young to use Instagram"
//muuljuhul
//konsoolis kuvatakse "Welcome to Instagram"

Console.WriteLine("Enter your age:");

int userAge = Int32.Parse(Console.ReadLine()); // "13" - heap, 13 - stack

if (userAge >= 13)
{
    Console.WriteLine("Welcome to Instagram!");
}
else //if (userAge < 13)
{
    Console.WriteLine("You are too young for Instagram!");
}