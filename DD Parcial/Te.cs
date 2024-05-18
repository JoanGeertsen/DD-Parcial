using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DD_Parcial
{
    internal class Te: Producto
    {
        #region Atributos
        private string _Tipo;
        public static string TipoPorDefecto="Negro";
        #endregion

        #region Constructores
        public Te() : base() { _Tipo = TipoPorDefecto; }

        public Te(string _Nombre, string _Descripcion, string _FechaIncorporacion, int _Stock, string _Tipo) : base(_Nombre, _Descripcion, _FechaIncorporacion, _Stock)
        {
            this._Tipo = (TipoValido(_Tipo)) ? _Tipo : TipoPorDefecto;
        }
        #endregion

        #region Property        
        public string Tipo
        {
            get { return _Tipo; }
            set { _Tipo = (TipoValido(value)) ? value : TipoPorDefecto; }
        }

      
        #endregion

        #region Static
        public static bool TipoValido(string tipo)
        {
            string[] tiposValidos = { "verde", "blanco", "amarillo", "oolong", "negro", "pu-erh" };
            return (tipo != null && tiposValidos.Contains(tipo.Trim().ToLower()));
        }
        #endregion
    }
}
