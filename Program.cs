using Animales;

class Program
{
    public static void Main(String[] args)
    {
        Ballena b = new Ballena("Monstro", 170.00F);

        Console.WriteLine(b.nombre);
        Console.WriteLine(b.peso+ " Toneladas");
        Console.WriteLine($"{b.nombre} esta cantando!");
        b.whaleSound.Play();
        Console.ReadKey();
        b.whaleSound.Stop();
        b.jugar();

        Console.WriteLine();
        
        Penguin p = new Penguin("Cabo", 18.00F);

        Console.WriteLine(p.nombre);
        Console.WriteLine(p.peso + " Kg");
        p.penguinSound.Play();
        Console.WriteLine($"{p.nombre} esta cantando!");
        Console.ReadKey();
        p.penguinSound.Stop();
        p.jugar();
        Console.ReadKey();
    }
}