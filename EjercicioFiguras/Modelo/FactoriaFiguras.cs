using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFiguras.Modelo
{
    public class FactoriaFiguras : IFactoriaMedibles
    {
        public IMedible Figura(EnumFiguras tipo, int valor)
        {
            switch (tipo)
            {
                case EnumFiguras.Cuadrado:return new Cuadrado() { lado= valor};
                case EnumFiguras.Circulo: return new Circulo() { Radio=valor };
                default: return null;
            }
        }
    }
}