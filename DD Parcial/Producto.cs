using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace DD_Parcial
{
    public abstract class Producto
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

        public override string ToString()
        {
            return $" {_Nombre} \n Precio: ${_Precio} \n Valor final: {CalcularPrecioFinal()} \n Vencimiento: {_FechaVencimiento}\n Stock: {_Stock}";
        }

        public override bool Equals(object? obj)
        {
            bool igual = false;

            if(obj == null)
                igual = (this == null);
            else if(this.GetType() == obj.GetType())
            {
                Producto p = (Producto) obj;
                igual = (_Nombre == p.Nombre);
            }
            return igual;         
        }

        public override int GetHashCode()
        {
            return int.Parse(_Nombre) * _Stock;
        }
        #endregion
    }
}
