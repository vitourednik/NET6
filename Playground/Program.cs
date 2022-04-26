// See https://aka.ms/new-console-template for more information
using Playground.Model;
using Playground.Data;

Car car = new Car("1234","bílá",100,"Škoda");
OvereniSPZ.OverSPZ(car.SPZ);

//Console.WriteLine(PorovnaniObsahu.Porovnani());

/*for(int i = 0; i < 10; i++)
{
    Dimension dim1 = RandomPointGenerator.GetRandomPoint();
    Console.WriteLine(dim1);
}*/


//Dimension dimension1 = new Dimension(2,3);
//Dimension dimension2 = new Dimension(4,6.5);
//Dimension dimension3 = new Dimension();
/*dimension1.x = 20.5;
dimension1.y = 22.5;
dimension2.x = 4;
dimension2.y = 6.5;*/
/*Kvadrant a;
dimension1.Print();
a = dimension1.Kvadrant();
Console.WriteLine("Obsah v promenne a je: " + a);*/
//Console.WriteLine($"Hodnota obj 1 x: { dimension1.x} a hodnota y: {dimension1.y}");
//Console.WriteLine($"Hodnota obj 2 x: { dimension2.x} a hodnota y: {dimension2.y}");

/*Person person1 = new Person("Jan","Novák");
person1.DateOfBirth = new DateTime(1999, 12, 31);
Console.WriteLine($"Jméno: {person1.FirstName} {person1.LastName}");*/




/*int pom = 0;

bool konec = true;

while (konec)
{
    Console.WriteLine("Zadavejte cisla, pro ukonceni stisknete Q a enter");
    string vstup = Console.ReadLine();
    bool isNum = int.TryParse(vstup, out _);
    if (vstup == "Q")
        konec = false;
    else if (isNum == true)
        pom += int.Parse(vstup);
    else Console.WriteLine("Zadej cislo...");
}
Console.WriteLine(pom);
*/

/*string denVTydnu(denVTydnuE day)
{
    string vystup;
    switch (day)
    {
        case denVTydnuE.PONDELI:
            vystup = "pondeli";
            break;

        case denVTydnuE.UTERY:
            vystup = "utery";
            break;
        case denVTydnuE.STREDA:
            vystup = "streda";
            break;
        case denVTydnuE.CTVRTEK:
            vystup = "ctvrtek";
            break;
        case denVTydnuE.PATEK:
            vystup = "patek";
            break;
        case denVTydnuE.SOBOTA:
            vystup = "sobota";
            break;
        case denVTydnuE.NEDELE:
            vystup = "nedele";
            break;
        default:
            vystup = "mimo hodnotu";
            break;
    }
    return vystup;
}

Console.WriteLine(denVTydnu(denVTydnuE.STREDA));*/



/*DateTime datum = new DateTime(2000,4,25);

int vek(DateTime datum)
{
    int vek;
    if (datum.Month > DateTime.Now.Month || (datum.Month == DateTime.Now.Month && datum.Day >= DateTime.Now.Day))
        vek = DateTime.Now.Year - datum.Year;
    else vek = DateTime.Now.Year - datum.Year - 1;
    return vek;
}
Console.WriteLine(vek(datum));*/

//Console.WriteLine("Zadejte mnozstvi prijateho sodiku");
//int vstup = int.Parse(Console.ReadLine());

/*int Suma(int a, int b)
{
    int sum = a + b;
    return sum;
}

Console.WriteLine(Suma(10, 20));*/
/*Console.WriteLine("Zadejte cislo 1-7 pro den v tydnu: ");
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

Console.WriteLine(denVTydnu(den));*/

/*void Hello(string name)
{
    Console.WriteLine($"Hello {name}");
}
Hello("Abc");*/

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

Console.WriteLine("konec");

enum denVTydnuE
{
    PONDELI,
    UTERY,
    STREDA,
    CTVRTEK,
    PATEK,
    SOBOTA,
    NEDELE
}