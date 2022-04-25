// See https://aka.ms/new-console-template for more information

/*int cislo = -13 + 22;

int a = 10;

int b = 20;

int pom;

double desetinne_cislo = 305.1234;

string retezec = "Ahoj světe!";

char pismenko = 'A';*/

/*Console.WriteLine("Zadejte teplotu ve stupních celsia a zmáčkni enter (desetinné číslo): ");

string vstup = Console.ReadLine();

double celsius = double.Parse(vstup);

double farenheit = (1.8 * celsius) + 32;

//pom = a;
//a = b;
//b = pom;
Console.WriteLine("Hodnota ferenheita je: " + farenheit);*/
Console.WriteLine("zadejte prvni cele cislo a zmackni enter");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("zadejte druhe cele cislo a zmackni enter");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("zadejte treti cele cislo a zmackni enter");
int c = int.Parse(Console.ReadLine());

if (a > b & a > c)
{
    Console.WriteLine("prvni cislo je nejvetsi");
}
else if (b > c & b > a)
{
    Console.WriteLine("druhe cislo je nejvetsi");
}
else if (c > a & c > b)
{
    Console.WriteLine("treti cislo je nejvetsi");
}

else if (a == b & c < a)
{
    Console.WriteLine("prvni a druhe cislo jsou nejvetsi");
}
else if (a == c & b < a)
{
    Console.WriteLine("prvni a treti cisla jsou nejvetsi");
}
else if (b == c & a < b)
{
    Console.WriteLine("druhe a treti cisla jsou nejvetsi");
}
else if (a == b & b == c)
{
    Console.WriteLine("vsechna 3 cisla jsou stejne velka");
}
