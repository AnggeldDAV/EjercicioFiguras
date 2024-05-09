using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFiguras.Modelo
{
    public interface IFactoriaMedibles
    {
        IMedible Figura(EnumFiguras tipo, int valor);
    }
}
