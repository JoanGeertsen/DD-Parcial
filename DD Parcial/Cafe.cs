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
            this._Tueste = (TuesteValido(_Tueste)) ? _Tueste : TuestePorDefecto;
            this._Molido = _Molido;
        }
        #endregion

        #region Property        
        public string Tueste
        {
            get { return _Tueste; }
            set { _Tueste = (TuesteValido(value)) ? value : TuestePorDefecto; }
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
    }
}
