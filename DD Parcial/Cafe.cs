﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DD_Parcial
{
    public abstract class Cafe: Producto
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

        public Cafe(string _Nombre, int _Codigo, DateTime _FechaVencimiento, int _Stock, double _Precio, string _Tueste, string _Origen, bool _Molido) : base(_Nombre, _Codigo, _FechaVencimiento, _Stock, _Precio)
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

        public override string ToString()
        {
            string molido= _Molido ? "Molido" : "En grano";
            return base.ToString() + $"\n Tueste: {_Tueste}\n Origen: {_Origen}\n {molido}";
        }

        public override bool Equals(object? obj)
        {
            bool igual = false;
            if (base.Equals(obj))
            {
                Cafe c = (Cafe)obj;
                igual = _Tueste == c.Tueste && _Origen == c.Origen && _Molido == c.Molido;
            }
            return igual;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() + (int.Parse(_Tueste) * int.Parse(_Origen));
        }
    }
}
