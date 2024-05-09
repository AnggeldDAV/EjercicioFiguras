using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFiguras.Modelo
{
    public class Cuadrado : IMedible
    {
        public IVisionalble Visor { get; set; } = new Visionador01();
        public int lado {  get; set; }

        public double DamePerimetro()
        {
            return lado * 4;
        }

        public double DameSuperficie()
        {
            return lado * lado;
        }
        public override string ToString()
        {
            return Visor.DameCadena(this);
        }
    }
}
