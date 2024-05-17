using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DD_Parcial
{
    internal abstract class Cafe: Producto
    {
        #region Atributos
        protected string _Tueste;
        protected bool _Molido;
        public static string TuestePorDefecto = "Medio";
        #endregion

        #region Constructores
        public Cafe(): base() { _Tueste = TuestePorDefecto; _Molido = false; }

        public Cafe(string _Nombre, string _Descripcion, string _FechaIncorporacion, int _Stock, string _Tueste, bool _Molido) : base(_Nombre, _Descripcion, _FechaIncorporacion, _Stock)
        {
            this._Tueste = (_Tueste.Trim().ToLower() == "bajo" || _Tueste.Trim().ToLower() == "medio" || _Tueste.Trim().ToLower() == "alto") ? "_Tueste" : "TuestePorDefecto";
        }
        #endregion

        #region Property        
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = (value != null) ? value : ""; }
        }

        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = (value != null) ? value : ""; }
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
        #endregion      
    }
}
