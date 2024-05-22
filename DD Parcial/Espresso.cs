using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DD_Parcial
{
    public class Espresso : Cafe
    {
        #region Atributos
        public static string MetodosRecomendados = "Espresso, Moka";
        #endregion

        #region Constructores      
        public Espresso() : base() { }

        public Espresso(string _Nombre, int _Codigo, DateTime _FechaVencimiento, int _Stock, double _Precio, string _Tueste, string _Origen, bool _Molido, bool _ConAzucar)
            : base(_Nombre, _Codigo, _FechaVencimiento, _Stock, _Precio, _Tueste, _Origen, _Molido, _ConAzucar) { }
        #endregion
    }
}
