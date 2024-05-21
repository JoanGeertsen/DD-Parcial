using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DD_Parcial
{
    public class Filtro: Cafe
    {
        #region Atributos
        public static string MetodosRecomendados = "V60, Chemex, Prensa Francesa, Aeropress";
        #endregion

        #region Constructores      
        public Filtro() : base() { }

        public Filtro(string _Nombre, int _Codigo, DateTime _FechaVencimiento, int _Stock, double _Precio, string _Tueste, string _Origen, bool _Molido) 
            : base(_Nombre, _Codigo, _FechaVencimiento, _Stock, _Precio, _Tueste, _Origen, _Molido) { }   
        #endregion
    }
}
