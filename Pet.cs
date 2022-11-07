using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales
{
    class Pet
    {
        public string nombre { get; set; }
        public float peso { get; set; }

        public Pet(string nombre, float peso)
        {
            this.nombre = nombre;
            this.peso = peso;
        }

        public virtual void jugar()
        {
            Console.WriteLine("El animal esta jugando");
        }
    }
}
