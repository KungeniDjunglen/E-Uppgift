using System;

class Program
{
    static int AREA(int höjd, int bas)
    {
        return höjd*bas;
    }
    static void Main()
    {
        Console.Write("Skriv Höjden för rektanglen ");
        int Höjd = int.Parse(Console.ReadLine());
        Console.Write("Skriv Basen för rektanglen ");
        int Bas = int.Parse(Console.ReadLine());

        int area = AREA(Höjd, Bas);
        Console.WriteLine("Arean på rektanglen är " + area);
    }
}