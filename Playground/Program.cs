// See https://aka.ms/new-console-template for more information

//Console.WriteLine("Zadejte mnozstvi prijateho sodiku");
//int vstup = int.Parse(Console.ReadLine());

/*int Suma(int a, int b)
{
    int sum = a + b;
    return sum;
}

Console.WriteLine(Suma(10, 20));*/
Console.WriteLine("Zadejte cislo 1-7 pro den v tydnu: ");
int den = int.Parse(Console.ReadLine());

string denVTydnu (int a)
{
    string vystup;
    switch (a)
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
            break;
        case 7:
            vystup = "nedele";
            break;
        default:
            vystup = "mimo hodnotu";
            break;
    }
    return vystup;
}

Console.WriteLine(denVTydnu(den));

/*Console.WriteLine("Zadejte cele cislo:");
int vstup = int.Parse(Console.ReadLine());
int pom = 0;

for(int i = 1; i <= vstup; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write(i);
    }
    Console.WriteLine("");
    pom = pom + i;
}
Console.WriteLine($"vysledek = {pom}");*/


/*int opakovani = 10;

for (int i = 0; i < opakovani; i++)
{
    Console.WriteLine(i);
}

int a = 10;

while (a > 0)
{
    Console.WriteLine(a);
    a--;
}*/

/*Console.WriteLine("Zadejte hodnotu 1-7 pro cislo dne:");
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

Console.WriteLine($"{vystup}{vikend} a vikendinfo: {vikendinfo}");*/

