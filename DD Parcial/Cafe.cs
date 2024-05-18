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
        protected string _Origen;
        protected bool _Molido;
        public static string TuestePorDefecto = "Medio";
        public static double RecargoPorMolido = 550;
        #endregion

        #region Constructores
        public Cafe(): base() { _Tueste = TuestePorDefecto; _Origen = "Desconocido"; _Molido = false; }

        public Cafe(string _Nombre, string _FechaIncorporacion, int _Stock, double _Precio, string _Tueste, string _Origen, bool _Molido) : base(_Nombre, _FechaIncorporacion, _Stock, _Precio)
        {
            this._Tueste = (TuesteValido(_Tueste)) ? _Tueste : TuestePorDefecto;
            this._Origen = (_Origen != null && _Origen.Trim() != "") ? _Origen : "Desconocido";
            this._Molido = _Molido;
        }
        #endregion

        #region Property        
        public string Tueste
        {
            get { return _Tueste; }
            set { _Tueste = (TuesteValido(value)) ? value : TuestePorDefecto; }
        }

        public string Origen
        {
            get { return _Origen; }
            set { _Origen = (value != null && value.Trim() != "") ? value : "Desconocido"; }
        }

        public bool Molido
        {
            get { return _Molido; }
            set { _Molido = value; }
        }
        #endregion

        #region Static
        public static bool TuesteValido(string tueste)
        {
            string[] tuestesValidos = { "bajo", "medio", "alto" };
            return (tueste != null && tuestesValidos.Contains(tueste.Trim().ToLower()));
        }
        #endregion

        #region Consultas
        public override double CalcularPrecioFinal()
        {
            return (_Molido) ? _Precio + RecargoPorMolido : _Precio;
        }
        #endregion
    }
}
