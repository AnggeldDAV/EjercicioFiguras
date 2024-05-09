using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFiguras.Modelo
{
    public class Visionador01 : IVisionalble
    {
        public string DameCadena(IMedible elemento)
        {
            return $"Es la figura {elemento.GetType().Name} su perimetro es {elemento.DamePerimetro()} y su superficie {elemento.DameSuperficie()}";
        }
    }
}
