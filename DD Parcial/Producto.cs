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
        protected DateTime _FechaVencimiento;
        protected int _Stock;
        public static DateTime VencimientoPorDefecto = DateTime.Today;
        #endregion

        #region Constructores
        public Producto() { _Nombre = ""; _FechaVencimiento = VencimientoPorDefecto; _Stock = 0; _Precio = 0; }

        public Producto(string _Nombre, DateTime _FechaVencimiento, int _Stock, double _Precio)
        {
            this._Nombre = (_Nombre != null) ? _Nombre : "";
            this._FechaVencimiento = (_FechaVencimiento <= DateTime.Today) ? _FechaVencimiento : VencimientoPorDefecto;
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

        public DateTime FechaVencimiento
        {
            get { return _FechaVencimiento; }
            set { _FechaVencimiento = (value <= DateTime.Today) ? value : VencimientoPorDefecto; }
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
