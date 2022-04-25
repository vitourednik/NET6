// See https://aka.ms/new-console-template for more information

/*int cislo = -13 + 22;

int a = 10;

int b = 20;

int pom;

double desetinne_cislo = 305.1234;

string retezec = "Ahoj světe!";

char pismenko = 'A';*/

Console.WriteLine("Zadejte teplotu ve stupních celsia a zmáčkni enter (desetinné číslo): ");

string vstup = Console.ReadLine();

double celsius = double.Parse(vstup);

double farenheit = (1.8 * celsius) + 32;

//pom = a;
//a = b;
//b = pom;
Console.WriteLine("Hodnota ferenheita je: " + farenheit);


