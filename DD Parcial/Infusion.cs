using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DD_Parcial
{
    public class Infusion: Producto
    {
        #region Atributos
        private string _Descripcion;
        #endregion

        #region Constructores
        public Infusion() : base() { _Descripcion = ""; }

        public Infusion(string _Nombre, int _Codigo, DateTime _FechaVencimiento, int _Stock, double _Precio, string _Descripcion) : base(_Nombre, _Codigo, _FechaVencimiento, _Stock, _Precio)
        {
            this._Descripcion = (_Descripcion != null && _Descripcion.Trim() != "") ? _Descripcion : "";
        }
        #endregion

        #region Property        
        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = (value != null && value.Trim() != "") ? value : ""; }
        }
        #endregion

        #region Consultas
        public override double CalcularPrecioFinal()
        {
            return _Precio;
        }
        #endregion
    }
}
