// See https://aka.ms/new-console-template for more information

Console.WriteLine("Zadejte hodnotu 1-7 pro cislo dne:");
int vstup = int.Parse(Console.ReadLine());
string vystup;
string vikend = " a neni vikend";
bool vikendb = false;

if (vstup == 1)
{
    Console.WriteLine("pondeli");
}
else if (vstup == 2)
{
    Console.WriteLine("utery");
}
else if (vstup == 3)
{
    Console.WriteLine("streda");
}
else if (vstup == 4)
{
    Console.WriteLine("ctvrtek");
}
else if (vstup == 5)
{
    Console.WriteLine("patek");
}
else if (vstup == 6)
{
    Console.WriteLine("sobota");
}
else if (vstup == 7)
{
    Console.WriteLine("nedele");
}
else 
{
    Console.WriteLine("mimo hodnotu");
}


Console.Write("switch vystup: ");
switch (vstup)
{
    case 1:
        vystup = "pondeli";
        break;

    case 2:
        vystup = "utery";
        break;
    case 3:
        vystup = "streda";
        break;
    case 4:
        vystup = "ctvrtek";
        break;
    case 5:
        vystup = "patek";
        break;
    case 6:
        vystup = "sobota";
        vikend = " a je víkend";
        vikendb = true;
        break;
    case 7:
        vystup = "nedele";
        vikend = " a je víkend";
        vikendb = true;
        break;
    default:
        vystup = "mimo hodnotu";
        vikend = "";
            break;
}

string vikendinfo = vikendb ? " a je to vikend" : "";

Console.WriteLine($"{vystup}{vikend} a vikendinfo: {vikendinfo}");