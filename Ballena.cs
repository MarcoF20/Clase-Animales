using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Animales
{
    class Ballena : Pet
    {
        public SoundPlayer whaleSound = new SoundPlayer("C:\\Users\\pirat\\source\\repos\\Animales\\Sounds\\whale.wav");

        public Ballena(string nombre, float peso) : base(nombre, peso)
        {
            this.nombre = nombre;
            this.peso = peso;
        }
        public override void jugar()
        {
            Console.WriteLine("La ballena esta nadando");
        }
    }
}
