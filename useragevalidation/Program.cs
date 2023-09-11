// See https://aka.ms/new-console-template for more information

//rakendus k[sib kasutajal valida tema sugu (m/f)
//rakendus k[sib kasutajal sisestada tema perekonnanime
//l'htudes kasutaja valikust, rakendus tervitab kasutaja j'rgmiselt:
//"Welcome, Mr [kasutaja perekonnanimi]" / "Welcome, Ms. [kasutaja perekonnanimi]"

Console.WriteLine("Please, select your gender (m/f):");

char userGender = Char.Parse(Console.ReadLine());

Console.WriteLine("Please, enter your lastname:");
string userLastName = Console.ReadLine();

if (userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {userLastName}!");
}
else if (userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms. {userLastName}!");
}
else 
{
    Console.WriteLine("Welcome!");
}