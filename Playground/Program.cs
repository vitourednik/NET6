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


Console.Write("switch vystup: ");
switch (vstup)
{
    case 1:
        Console.WriteLine("pondeli");
        break;

    case 2:
        Console.WriteLine("utery");
        break;
    case 3:
        Console.WriteLine("streda");
        break;
    case 4:
        Console.WriteLine("ctvrtek");
        break;
    case 5:
        Console.WriteLine("patek");
        break;
    case 6:
        Console.WriteLine("sobota");
        break;
    case 7:
        Console.WriteLine("nedele");
        break;
    default:
        Console.WriteLine("mimo hodnotu");
            break;
}