namespace DD_Parcial
{
    internal class Te : Producto
    {
        #region Atributos
        private string _Tipo;
        private bool _PresentacionEnLata;
        public static string TipoPorDefecto = "Negro";
        public static double RecargoPorLata = 775; 
        #endregion

        #region Constructores
        public Te() : base() { _Tipo = TipoPorDefecto; _PresentacionEnLata = false; }

        public Te(string _Nombre, DateTime _FechaVencimiento, int _Stock, double _Precio, string _Tipo) : base(_Nombre, _FechaVencimiento, _Stock, _Precio)
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

        #region Consultas
        public override double CalcularPrecioFinal()
        {
            return (_PresentacionEnLata) ? _Precio + RecargoPorLata : _Precio;
        }
        #endregion
    }
}
