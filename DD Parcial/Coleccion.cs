using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DD_Parcial
{
    public class Coleccion
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

        public List<Producto> Buscar(Type tipo)
        {
            return _ListaProductos.FindAll(producto => tipo.IsInstanceOfType(producto));
        }
        #endregion
    }
}
