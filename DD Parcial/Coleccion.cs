using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;
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

        public List<Producto> Buscar(string caracteristica, Type tipo)
        {
            List<Producto> listaRetorno = new List<Producto>();

            if (tipo == typeof(Cafe))
                listaRetorno = _ListaProductos.FindAll(producto => tipo.IsInstanceOfType(producto) &&
                producto is Cafe cafe && cafe.Tueste.ToLower() == caracteristica.ToLower());

            else if (tipo == typeof(Filtro))
                listaRetorno = _ListaProductos.FindAll(producto => tipo.IsInstanceOfType(producto) &&
                producto is Filtro cafe && cafe.Tueste.ToLower() == caracteristica.ToLower());

            else if (tipo == typeof(Espresso))
                listaRetorno = _ListaProductos.FindAll(producto => tipo.IsInstanceOfType(producto) && 
                producto is Espresso cafe && cafe.Tueste.ToLower() == caracteristica.ToLower());

            else if (tipo == typeof(Te))
                listaRetorno = _ListaProductos.FindAll(producto => tipo.IsInstanceOfType(producto) &&
                producto is Te te && te.Tipo.ToLower() == caracteristica.ToLower());

            return listaRetorno;
        }

        public List<Producto> Buscar(bool caracteristica, Type tipo)
        {
            List<Producto> listaRetorno = new List<Producto>();

            if(tipo == typeof(Te))  
                listaRetorno = _ListaProductos.FindAll(producto => tipo.IsInstanceOfType(producto) && 
                producto is Te te && te.PresentacionEnLata == caracteristica);
            else if(tipo == typeof(Cafe))
                listaRetorno = _ListaProductos.FindAll(producto => tipo.IsInstanceOfType(producto) &&
                producto is Cafe cafe && cafe.Molido == caracteristica);

            return listaRetorno;
        }

        public List<Producto> Buscar(bool caracteristica1, string caracteristica2 ,Type tipo)
        {
            List<Producto> listaRetorno = Buscar(caracteristica2, tipo);

            if(tipo == typeof(Te))
                listaRetorno = listaRetorno.FindAll(producto => tipo.IsInstanceOfType(producto) &&
                producto is Te te && te.PresentacionEnLata == caracteristica1);

            else if (tipo == typeof(Cafe))
                listaRetorno = listaRetorno.FindAll(producto => tipo.IsInstanceOfType(producto) &&
                producto is Cafe cafe && cafe.Molido == caracteristica1);

            return listaRetorno;
        }
        #endregion

    }
}
