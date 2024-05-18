using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace DD_Parcial
{
    internal abstract class Producto
    {
        #region Atributos
        protected string _Nombre;
        protected double _Precio;
        protected string _FechaIncorporacion;
        protected int _Stock;
        public static string FechaInicial = "01/01/2000";
        #endregion

        #region Constructores
        public Producto() { _Nombre = ""; _FechaIncorporacion = FechaInicial; _Stock = 0; _Precio = 0; }

        public Producto(string _Nombre, string _FechaIncorporacion, int _Stock, double _Precio)
        {
            this._Nombre = (_Nombre != null) ? _Nombre : "";
            this._FechaIncorporacion = (_FechaIncorporacion != null) ? _FechaIncorporacion : "";
            this._Stock = (_Stock > 0) ? _Stock : 0;
            this._Precio = (_Precio > 0) ? _Precio : 0;
        }
        #endregion

        #region Property        
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = (value != null) ? value : ""; }
        }

        public string FechaIncorporacion
        {
            get { return _FechaIncorporacion; }
            set { _FechaIncorporacion = (value != null) ? value : ""; }
        }

        public int Stock
        {
            get { return _Stock; }
            set { _Stock = (value > 0) ? value : 0; }
        }

        public double Precio
        {
            get { return _Precio; }
            set { _Precio = (value > 0) ? value : 0; }
        }
        #endregion

        #region Consultas
        public abstract double CalcularPrecioFinal();
        #endregion
    }
}
