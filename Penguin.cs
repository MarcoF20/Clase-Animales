using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
namespace Animales
{
    class Penguin : Pet
    {
        public SoundPlayer penguinSound = new SoundPlayer("C:\\Users\\pirat\\source\\repos\\Animales\\Sounds\\penguin.wav");

        public Penguin(string nombre, float peso) : base(nombre, peso)
        {
            this.nombre = nombre;
            this.peso = peso;
        }
        public override void jugar()
        {
            Console.WriteLine("El pinguino esta bailando");
        }

    }
}
