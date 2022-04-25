// See https://aka.ms/new-console-template for more information

Console.WriteLine("Zadejte hodnotu 1-7 pro cislo dne:");
int vstup = int.Parse(Console.ReadLine());

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



Console.WriteLine(vstup);