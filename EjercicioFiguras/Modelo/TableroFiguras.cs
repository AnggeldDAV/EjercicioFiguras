using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFiguras.Modelo
{
    public class TableroFiguras
    {
        public double SuperficieTotal;
        public double PerimetroTotal;
        public List<IMedible> Tablero = new();
        public void Add(IMedible elemento)
        {
            this.Tablero.Add(elemento);
        }
        public int Count()
        {
            return this.Tablero.Count();
        }
        public double DamePerimetroTotal()
        {
            PerimetroTotal = 0;
            Parallel.ForEach(Tablero, number =>
            {
                PerimetroTotal += number.DamePerimetro();
            });
            return PerimetroTotal;
        }
        public double DameSuperficieTotal()
        {
            SuperficieTotal = 0;
            Parallel.ForEach(Tablero, number =>
            {
                SuperficieTotal += number.DameSuperficie();
            });
            return SuperficieTotal;
        }
        public double DameMediaTotalPerimetro()
        {
            return (this.DamePerimetroTotal()) / this.Count();
        }
        public double DameMediaTotalSuperficie()
        {
            return (this.DameSuperficieTotal()) / this.Count();
        }
        public double DameSuperficieGrande()
        {
            double Temp = 0;
            Parallel.ForEach(Tablero, number =>
            {
                if (number.DameSuperficie() > Temp)
                {
                    Temp = number.DameSuperficie();
                }
            });
            return Temp;

        }
        public double DameSuperficiePequena()
        {
            double Temp = 1000000000000000000;
            Parallel.ForEach(Tablero, number =>
            {
                if (number.DameSuperficie() < Temp)
                {
                    Temp = number.DameSuperficie();
                }
            });
            return Temp;

        }
    }
}
