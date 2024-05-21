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
        protected int _Codigo;
        protected double _Precio;
        protected DateTime _FechaVencimiento;
        protected int _Stock;
        public static DateTime VencimientoPorDefecto = DateTime.Today;
        public static int CodigoPorDefecto = 001;
        #endregion

        #region Constructores
        public Producto() { _Nombre = ""; _Codigo = CodigoPorDefecto; _FechaVencimiento = VencimientoPorDefecto; _Stock = 0; _Precio = 0; }

        public Producto(string _Nombre, int _Codigo, DateTime _FechaVencimiento, int _Stock, double _Precio)
        {
            this._Nombre = (_Nombre != null) ? _Nombre : "";
            this._Codigo = (_Codigo > 0) ? _Codigo : CodigoPorDefecto;
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
        public int Codigo
        {
            get { return _Codigo; }
            set { _Codigo = (value > 0) ? value : CodigoPorDefecto; }
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
                igual = (_Codigo == p.Codigo);
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
