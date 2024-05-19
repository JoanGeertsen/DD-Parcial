using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DD_Parcial
{
    internal class Coleccion
    {
        #region Atributos
        private List<Producto> _ListaProductos;
        #endregion

        #region Constructores
        public Coleccion() { _ListaProductos = new List<Producto>(); }
        #endregion

        #region Comandos
        public void Agregar(Producto p)
        {
            if(p != null)            
                _ListaProductos.Add(p);            
        }

        public void Eliminar(Producto p)
        {
            if(p != null)
                _ListaProductos.Remove(p);
        }
        #endregion

        #region consultas
        public List<Producto> Buscar() { return _ListaProductos; }
        #endregion
    }
}
