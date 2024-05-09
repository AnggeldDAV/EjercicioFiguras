using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFiguras.Modelo
{
    public class Circulo : IMedible
    {
        public IVisionalble Visor {  get; set; } = new Visionador01();
        public int Radio {  get; set; }

        public double DamePerimetro()
        {
            return 2* Math.PI * Radio;
        }

        public double DameSuperficie()
        {
            return Math.PI * Math.Pow(Radio,2);
        }
        public override string ToString()
        {
            return Visor.DameCadena(this);
        }

    }

}
